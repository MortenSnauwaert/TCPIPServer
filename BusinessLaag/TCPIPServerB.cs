using DataAccess;
using System.Net;
using System.Net.Sockets;

namespace BusinessLaag;

public class TCPIPServerB : IDisposable
{
    TCPIPServerDA _tcpipServer;
    public event EventHandler<string> OnDataReceived;
    public event EventHandler<string> OnClientConnected;
    public event EventHandler<string> OnClientDisconnected;
    private Dictionary<TcpClient, string> clients = new Dictionary<TcpClient, string>();
    public TCPIPServerB ()
    {
        _tcpipServer = new TCPIPServerDA(IPAddress.Parse("127.0.0.1"), 3000);
        if (_tcpipServer != null && _tcpipServer.isRunning)
        {
            _tcpipServer.DataReceived += OnDataReceivedFromDA;
            _tcpipServer.ClientDisconnected += OnClientDisconnectedFromDA;
            _tcpipServer.ClientConnected += OnClientConnectedFromDA;
        }
        else
        {
            throw new Exception("Fout bij opstarten Server");
        }
    }
    public TCPIPServerB(IPAddress ipAddress, int port)
    {
        _tcpipServer = new TCPIPServerDA(ipAddress, port);
        if (_tcpipServer != null && _tcpipServer.isRunning)
        {
            _tcpipServer.DataReceived += OnDataReceivedFromDA;
            _tcpipServer.ClientDisconnected += OnClientDisconnectedFromDA;
            _tcpipServer.ClientConnected += OnClientConnectedFromDA;
        }
        else
        {
            throw new Exception("Fout bij opstarten Server");
        }
    }
    private void OnDataReceivedFromDA(TcpClient client, string data)
    { OnDataReceived?.Invoke(client, data); }
    private void OnClientConnectedFromDA(TcpClient client, string data)
    { OnClientConnected?.Invoke(client, data); }
    private void OnClientDisconnectedFromDA(TcpClient client, string data)
    { OnClientDisconnected?.Invoke(client, data); }
    public void SendMessageToAllClients(string message)
    {
        try
        {
            if (_tcpipServer != null && _tcpipServer.isRunning)
                _tcpipServer?.SendMessageToAllClients(message);
            else throw new Exception("Server kan niet verzenden. Server niet opgestart");
        }
        catch { }
    }
    public void SendMessageToClient(TcpClient client, string message)
    {
        if (_tcpipServer.isRunning && client != null && client.Connected)
        {
            try
            {
                var writer = new StreamWriter(client.GetStream()) { AutoFlush = true };
                writer.WriteLine(message);
            }
            catch (IOException)
            { }
        }
    }
    public void StopClient(TcpClient client)
    {
        try
        {
            lock (clients)
            {
                if (_tcpipServer.isRunning && clients.ContainsKey(client))
                {
                    OnClientDisconnected?.Invoke(client, "verbinding verbroken");
                    client.Dispose();
                    clients.Remove(client);
                }
            }
        }
        catch { }
    }
    public void StopServer()
    {
        _tcpipServer?.StopServer();
        if (!_tcpipServer.isRunning)
        {
            _tcpipServer.DataReceived -= OnDataReceivedFromDA;
            _tcpipServer.ClientDisconnected -= OnClientDisconnectedFromDA;
            _tcpipServer.ClientConnected -= OnClientConnectedFromDA;
        }
        else
        {
            throw new Exception("Kan server niet stoppen!");
        }
    }
    public Dictionary<Tcp>
    public void Dispose()
    {
        if (isRunning) StopServer();
        listener.Dispose();
    }
}
