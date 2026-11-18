//Server
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace ServerApp
{
    class ServerTask2
    {
        static void Main()
        {
            TcpListener server = new TcpListener(IPAddress.Any, 8889);
            server.Start();
            Console.WriteLine("The time server is running!");
            while (true)
            {
                using (TcpClient client = server.AcceptTcpClient())
                using (NetworkStream stream = client.GetStream())
                {
                    try
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        string request = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim().ToLower();
                        string response = "";
                        if (request == "time")
                        {
                            response = DateTime.Now.ToString("HH:mm:ss");
                        }
                        else if (request == "date")
                        {
                            response = DateTime.Now.ToString("dd.MM.yyyy");
                        }
                        else
                        {
                            response = "Unknown command";
                        }
                        byte[] responseData = Encoding.UTF8.GetBytes(response);
                        stream.Write(responseData, 0, responseData.Length);
                        Console.WriteLine($"Sent: {response}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }
        }
    }
}
//Client
using System;
using System.Net.Sockets;
using System.Text;
namespace ClientApp
{
    class ClientTask2
    {
        static void Main()
        {
            Console.WriteLine("Enter 'time' for time or 'date' for date");
            string request = Console.ReadLine();
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    client.Connect("127.0.0.1", 8889);
                    using (NetworkStream stream = client.GetStream())
                    {
                        byte[] data = Encoding.UTF8.GetBytes(request);
                        stream.Write(data , 0, data.Length);
                        byte[] buffer = new byte[1024];
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        string respose = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                        Console.WriteLine($"Product response: {respose}");
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
