//Server
//NetworkLogic
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
namespace QuoteApp.Server
{
    public class QuoteServer
    {
        private TcpListener _listener;
        private List<string> _quotes = new List<string>
        {
            "To be, or not to be — that is the question.",
            "Knowledge is power.",
            "Live and learn.",
            "The hardest part is taking the first step; everything else depends solely on perseverance.",
            "Success is the ability to go from failure to failure without losing enthusiasm."
        };
        private Random _random = new Random();
        private int _maxClient = 3;
        private int _currentClient = 0;
        private const int MAX_QUOTES_PER_CLIENT = 5;
        private const string VALID_USER = "Admin";
        private const string VALID_PASSWORD = "228";
        public QuoteServer(int port)
        {
            _listener = new TcpListener(IPAddress.Any, port);
        }
        public async Task StartAsync()
        {
            _listener.Start();
            Console.WriteLine($"Server started, Max clients: {_maxClient}");
            while (true)
            {   
                TcpClient client = await _listener.AcceptTcpClientAsync();
                if (_currentClient >= _maxClient)
                {
                    _ = RejectClientsAsync(client);
                }
                else
                {
                    Interlocked.Increment(ref _currentClient);
                    _ = HandClientAsync(client);
                }
            }
        }
        private async Task RejectClientsAsync(TcpClient client)
        {
            using (client)
            using (NetworkStream stream = client.GetStream())
            {
                var response = new ServerResponse
                {
                    Message = "Server overloaded!",
                    Disconnect = true
                };
                byte[] bytes = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(response));
                await stream.WriteAsync(bytes, 0, bytes.Length);
            }
        }
        private async Task HandClientAsync(TcpClient client)
        {
            string clientIP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.MapToIPv4().ToString();
            Console.WriteLine($"[LOG] connected client: {clientIP} in {DateTime.Now:HH:mm:ss}");
            int quotesGiven = 0;
            try
            {
                using (client)
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] buffer = new byte[2048];
                    int authBytes = await stream.ReadAsync(buffer, 0, buffer.Length);
                    string authJson = Encoding.UTF8.GetString(buffer, 0, authBytes);
                    var request = JsonSerializer.Deserialize<ClientRequest>(authJson);
                    if (request?.Username != VALID_USER || request?.Password != VALID_PASSWORD)
                    {
                        var failResponse = new ServerResponse
                        {
                            Message = "Wrong login or password",
                            Disconnect = true
                        };
                        byte[] failBytes = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(failResponse));
                        await stream.WriteAsync(failBytes, 0, failBytes.Length);
                        return;
                    }
                    var okResponse = new ServerResponse
                    {
                        Message = "Authorization successful!",
                        Disconnect = false
                    };
                    byte[] okBytes = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(okResponse));
                    await stream.WriteAsync(okBytes, 0, okBytes.Length);
                    while (true)
                        {
                            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                            if (bytesRead == 0)
                            {
                                break;
                            }
                            if (quotesGiven >= MAX_QUOTES_PER_CLIENT)
                            {
                                var limitResponse = new ServerResponse
                                {
                                    Message = "Limit exhausted",
                                    Disconnect = true
                                };
                                byte[] limitBytes = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(limitResponse));
                                await stream.WriteAsync(limitBytes, 0, limitBytes.Length);
                                break;
                            }
                            string quote = _quotes[_random.Next(_quotes.Count)];
                            quotesGiven++;
                            var response = new ServerResponse
                            {
                                Message = quote,
                                Disconnect = false
                            };
                            byte[] responseBytes = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(response));
                            await stream.WriteAsync(responseBytes, 0, responseBytes.Length);
                        }
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] {clientIP} : {ex.Message}");
            }
            finally
            {
                Interlocked.Decrement(ref _currentClient);
                Console.WriteLine($"[Log] Unconnecting client: {clientIP} in {DateTime.Now:HH:mm:ss}");
            }
        }
    }
}
//models
using System;
public class ServerResponse
{
    public string Message { get; set; } = "";
    public bool Disconnect { get; set; }
}
public class ClientRequest
{
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";
}
//Program
using QuoteApp.Server;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        var server = new QuoteServer(9000);
        await server.StartAsync();
    }
}
//Client
/NetworkLogic
using System;
using System.Text;
using System.Text.Json;
using System.Net.Sockets;
using System.Threading.Tasks;
namespace QuoteApp.Client
{
    public class QuoteClient
    {
        private string _ip;
        private int _port;
        private TcpClient _client;
        private NetworkStream _stream;
        public QuoteClient(string ip, int port)
        {
            _ip = ip;
            _port = port;
        }
        public async Task<bool> ConnectAndAuthAsync(string user, string password)
        {
            _client = new TcpClient();
            await _client.ConnectAsync(_ip, _port);
            _stream = _client.GetStream();
            var request = new ClientRequest
            {
                Username = user,
                Password = password
            };
            byte[] reqBytes = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(request));
            await _stream.WriteAsync(reqBytes, 0, reqBytes.Length);
            byte[] buffer = new byte[1024];
            int bytesRead = await _stream.ReadAsync(buffer, 0, buffer.Length);
            var response = JsonSerializer.Deserialize<ServerResponse>(Encoding.UTF8.GetString(buffer, 0, bytesRead));
            Console.WriteLine($"Server: {response.Message}");
            if (response.Disconnect)
            {
                Disconnect();
                return false;
            }
            return true;
        }
        public async Task RequestQuoteAsync()
        {
            byte[] requestBytes = Encoding.UTF8.GetBytes("get");
            await _stream.WriteAsync(requestBytes,0, requestBytes.Length);
            byte[] buffer = new byte[1024];
            int bytesRead = await _stream.ReadAsync(buffer, 0, buffer.Length);
            var response = JsonSerializer.Deserialize<ServerResponse>(Encoding.UTF8.GetString(buffer, 0, bytesRead));
            Console.WriteLine($"Quote: {response.Message}");
            if (response.Disconnect)
            {
                Console.WriteLine("Server terminated the connection!");
                Disconnect();
            }
        }
        public void Disconnect()
        {
            _stream.Close();
            _client.Close();
        }
    }
}
//Program
using QuoteApp.Client;
using QuoteApp.Server;
using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        var client = new QuoteClient("127.0.0.1", 9000);
        try
        {
            Console.Write("Enter the username(admin): ");
            string user = Console.ReadLine();
            Console.Write("Enter the password: ");
            string password = Console.ReadLine();
            if (!await client.ConnectAndAuthAsync(user, password))
            {
                return;
            }
            Console.WriteLine("Press enter to ger quote or q to exit");
            while (true)
            {
                string input = Console.ReadLine();
                if (input?.ToLower() == "q")
                {
                    break;
                }
                await client.RequestQuoteAsync();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            client.Disconnect();
        }
    }
}
