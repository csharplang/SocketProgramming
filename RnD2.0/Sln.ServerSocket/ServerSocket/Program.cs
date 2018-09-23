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
            Console.WriteLine(" >> Server Started");
            clientSocket = serverSocket.AcceptTcpClient();
            Console.WriteLine(" >> Accept connection from client");

            while ((true))
            {
                try
                {
                    //requestCount = requestCount + 1;
                    //NetworkStream networkStream = clientSocket.GetStream();
                    //byte[] buffer = new byte[1000025];

                    //var abc = networkStream.Read(buffer, 0, 1000025);  //(int)clientSocket.ReceiveBufferSize

                    //BinaryReader bReader = new BinaryReader(clientSocket.GetStream());
                    //string receiveData = bReader.ReadString();

                    //Console.WriteLine(" >> Data from client - " + receiveData);


                    // read and display the response
                    NetworkStream networkStream = clientSocket.GetStream();
                    byte[] bytes = new byte[clientSocket.ReceiveBufferSize];
                    int bytesRead = networkStream.Read(bytes, 0, clientSocket.ReceiveBufferSize);
                    string receivedData = Encoding.ASCII.GetString(bytes);

                    receivedData = receivedData.Replace("\0", String.Empty);
                    receivedData = receivedData.Replace("$", String.Empty);
                    Console.WriteLine(" >> Data from client - " + receivedData);



                    //string serverResponse = "Last Message from Server: " + receiveData;
                    //Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    //networkStream.Write(sendBytes, 0, sendBytes.Length);
                    //networkStream.Flush();
                    //Console.WriteLine(" >> " + serverResponse);
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
                        Console.WriteLine(" >> Server Started after connection lost:" + DateTime.Now);
                        clientSocket = serverSocket.AcceptTcpClient();
                        Console.WriteLine(" >> Accept connection from client:" + DateTime.Now);
                    }

                }
            }
        }
    }
}
