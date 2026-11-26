//Server
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace ServerApp
{
    class ServerTask1
    {
        static void Main()
        {
            TcpListener server = new TcpListener(IPAddress.Any, 8888);
            server.Start();
            Console.WriteLine("Server started! Waiting client...");
            try
            {
                using (TcpClient client = server.AcceptTcpClient())
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string receiver = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    string clientIP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.MapToIPv4().ToString();
                    Console.WriteLine($"Server: \nB {DateTime.Now:HH:mm} from [{clientIP}] resulting string: " + $"{receiver}");
                    string response = "Hello, client!";
                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                    stream.Write(responseBytes, 0, responseBytes.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                server.Stop();
            }
        }
    }
}
//Client
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace ClientApp
{
    class ClientTask1
    {
        static void Main()
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    client.Connect("127.0.0.1", 8888);
                    using (NetworkStream stream = client.GetStream())
                    {
                        string message = "Hello, server!";
                        byte[] data = Encoding.UTF8.GetBytes(message);
                        stream.Write(data, 0, data.Length);
                        byte[] buffer = new byte[1024];
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        string received = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        string serverIP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.MapToIPv4().ToString();
                        Console.WriteLine($"Client \bin {DateTime.Now:HH:mm} from " + $"[{serverIP}] get string: {received}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
