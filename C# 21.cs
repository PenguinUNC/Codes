//Server
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
class ServerTask3
{
    static async Task Main()
    {
        TcpListener server = new TcpListener(IPAddress.Any, 8890);
        server.Start();
        Console.WriteLine("Async server started!");
        using (TcpClient client = await server.AcceptTcpClientAsync())
        using (NetworkStream stream = client.GetStream())
        {
            byte[] buffer = new byte[1024];
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            string reveived = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            string clientIP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.MapToIPv4().ToString();
            Console.WriteLine($"In {DateTime.Now:HH:mm} from [{clientIP}] get string: {reveived}");
            byte[] responceData = Encoding.UTF8.GetBytes("Hello, Client!");
            await stream.WriteAsync(responceData, 0, responceData.Length);
        }
        Console.ReadKey();
    }
}
//Client
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
class ClientTask3
{
    static async Task Main()
    {
        try
        {
            using (TcpClient client  = new TcpClient ())
            {
                await client.ConnectAsync("127.0.0.1", 8890);
                using (NetworkStream stream = client.GetStream ())
                {
                    string message = "Hello, Server!";
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    await stream.WriteAsync(data, 0, data.Length);
                    byte[] buffer = new byte[1024];
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    string received = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    string serverIP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.MapToIPv4().ToString();
                    Console.WriteLine($"In {DateTime.Now:HH:mm} from [{serverIP}] get string: {received}");
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
