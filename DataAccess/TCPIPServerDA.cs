using System.Net;
using System.Net.Http.Headers;
using System.Net.Sockets;

namespace DataAccess;

public class TCPIPServerDA : IDisposable
{
    private TcpListener listener;
    public bool isRunning;
    private Dictionary<TcpClient, string> clients = new Dictionary<TcpClient, string>();
    private readonly object clientsLock = new object();
    System.Threading.Thread acceptThread;

    // gebeurtenissen om wijzigingen door te geven
    public event Action<TcpClient, string> DataReceived;
    public event Action<TcpClient, string> ClientConnected;
    public event Action<TcpClient, string> ClientDisconnected;
    public TCPIPServerDA(IPAddress ipAddressServer, int poortnummerServer)
    {
        try
        {
            clients.Clear();
            listener = new TcpListener(ipAddressServer, poortnummerServer);
            listener.Start();
            isRunning = true;
            // Start een nieuwe thread om na te gaan als er berichten binnen komen
            acceptThread = new Thread(AcceptClients);
            acceptThread.Start();
        }
        catch
        {
            isRunning = false;
            Console.Write("Server opstarten mislukt");
        }
    }
    private void AcceptClients()
    {
        try
        {
            while (isRunning)
            {
                TcpClient client = listener.AcceptTcpClient();
                string clientEndPoint = client.Client.RemoteEndPoint.ToString();
                lock (clientsLock)
                {
                    clients.Add(client, clientEndPoint);
                }
                ClientConnected?.Invoke(client, "Nieuwe client");
                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.Start();
            }
        }
        catch { }
    }
    //Afhandelen van ontvangen data
    private void HandleClient(TcpClient client)
    {
        try
        {
            using (Stream stream = client.GetStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                while (isRunning && client.Connected)
                {
                    string data = reader.ReadLine();
                    if (data != null && data != "Disconnected")
                    {
                        DataReceived?.Invoke(client, data);
                    }
                    else
                    {
                        break;
                    }
                }
                lock (clients)
                {
                    if (clients.Keys.Contains(client)) clients.Remove(client);
                }
                if (client.Connected)
                {
                    ClientDisconnected?.Invoke(client, "verbinding verbroken");
                    client.Close();
                }
            }
        }
        catch { }
    }
    public void SendMessageToAllClients(string message)
    {
        lock (clients)
        {
            foreach(var client in clients.Keys)
            {
                if (isRunning && client != null && client.Connected)
                {
                    try
                    {
                        var writer = new StreamWriter(client.GetStream()) { AutoFlush = true };
                        writer.WriteLine(message);
                    }
                    catch (IOException)
                    {
                        // Handle write error
                    }
                }
            }
        }
    }
    public void SendMessageToClient(TcpClient client, string message)
    {
        if (isRunning && client != null && client.Connected)
        {
            try
            {
                var writer = new StreamWriter(client.GetStream()) { AutoFlush = true };
                writer.WriteLine(message);
            }
            catch (IOException)
            {
                // Handle write error
            }
        }
    }
    public void StopClient(TcpClient client)
    {
        try
        {
            lock (clients)
            {
                if (isRunning && clients.ContainsKey(client))
                {
                    ClientDisconnected?.Invoke(client, "verbinding verborken");
                    client.Dispose();
                    clients.Remove(client);
                }
            }
        } catch { }
    }
    // Listener stoppen
    public void StopServer()
    {
        isRunning = false;
        lock (clients)
        {
            foreach (var client in clients.Keys)
            {
                StopClient(client);
            }
            clients.Clear();
        }
        if (listener != null) listener.Stop();
    }
    public void Dispose()
    {
        if (isRunning) StopServer();
        listener.Dispose();
    }
    public Dictionary<TcpClient, string> GetConnectedClients()
    {
        try
        {
            lock (clients)
            {
                return new Dictionary<TcpClient, string>(clients);
            }
        }
        catch { return null; }
    }
}
