using ServerSocket.Resources;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener serverSocket = new TcpListener(IPAddress.Parse(Common.ServerIP), Convert.ToInt16(Common.ServerPort));
            int requestCount = 0;
            TcpClient clientSocket = default(TcpClient);
            serverSocket.Start();
            Console.WriteLine(" >> Server Started: " + DateTime.Now + " \nWaiting for connection... ");
            clientSocket = serverSocket.AcceptTcpClient();
            Console.WriteLine(" >> Accept connection from client: " + DateTime.Now);

            while ((true))
            {
                try
                {
                    requestCount = requestCount + 1;

                    NetworkStream networkStream = clientSocket.GetStream();
                    byte[] bytes = new byte[clientSocket.ReceiveBufferSize];
                    int bytesRead = networkStream.Read(bytes, 0, clientSocket.ReceiveBufferSize);
                    string receivedData = Encoding.ASCII.GetString(bytes);

                    receivedData = receivedData.Replace("\0", String.Empty);
                    receivedData = receivedData.Replace("$", String.Empty);
                    Console.WriteLine(" >> Data from client - " + receivedData);


                    //Reply to client***
                    string serverResponse = "Last Message from Server: Status Code: OK >>" + DateTime.Now;
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString()); 
                    if (ex.Message == ConstantVar.ClientConnLost)
                    {
                        clientSocket.Close();
                        serverSocket.Stop();
                        serverSocket = new TcpListener(IPAddress.Parse(Common.ServerIP), Convert.ToInt16(Common.ServerPort));
                        requestCount = 0;
                        clientSocket = default(TcpClient);
                        serverSocket.Start();
                        Console.WriteLine(" >> Connection lost... :" + DateTime.Now);
                        Console.WriteLine(" >> Server Started after connection lost: " + DateTime.Now + " \nWaiting for connection... ");
                        clientSocket = serverSocket.AcceptTcpClient();
                        Console.WriteLine(" >> Accept connection from client:" + DateTime.Now);
                    }

                }
            }
        }
    }
}
