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

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
