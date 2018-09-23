using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerSocketProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstWay();

            ForthWay();          
        }

        static void FirstWay()
        {
            TcpListener serverSocket = new TcpListener(IPAddress.Parse(Common.ServerIP), 5000);
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
                    requestCount = requestCount + 1;
                    NetworkStream networkStream = clientSocket.GetStream();
                    byte[] buffer = new byte[1000025];
                    networkStream.Read(buffer, 0, (int)clientSocket.ReceiveBufferSize);
                    string dataFromClient = System.Text.Encoding.ASCII.GetString(buffer);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    Console.WriteLine(" >> Data from client - " + dataFromClient);
                    string serverResponse = "Last Message from client" + dataFromClient;
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();
                    Console.WriteLine(" >> " + serverResponse);
                }
                catch (Exception ex)
                {
                    //Message = "Unable to read data from the transport connection: An existing connection was forcibly closed by the remote host."
                    Console.WriteLine(ex.ToString());
                    return;
                }
            }

            clientSocket.Close();
            serverSocket.Stop();
            Console.WriteLine(" >> exit");
            Console.ReadLine();
        }

        static void SecondWay() //dataFromClient.Length: dataFromClient.IndexOf("$")
        {
            TcpListener serverSocket = new TcpListener(IPAddress.Parse(Common.ServerIP), 5000);
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
                    requestCount = requestCount + 1;
                    NetworkStream networkStream = clientSocket.GetStream();
                    byte[] buffer = new byte[1000025];
                    networkStream.Read(buffer, 0, (int)clientSocket.ReceiveBufferSize);
                    string dataFromClient = Encoding.ASCII.GetString(buffer);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.Length);
                    Console.WriteLine(" >> Data from client - " + dataFromClient);
                    string serverResponse = "Last Message from client" + dataFromClient;
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();
                    Console.WriteLine(" >> " + serverResponse);
                }
                catch (Exception ex)
                {
                    //Message = "Unable to read data from the transport connection: An existing connection was forcibly closed by the remote host."
                    Console.WriteLine(ex.ToString());
                    return;
                }
            }

            clientSocket.Close();
            serverSocket.Stop();
            Console.WriteLine(" >> exit");
            Console.ReadLine();
        }

        static void ThirdWay() //BinaryReader
        {
            TcpListener serverSocket = new TcpListener(IPAddress.Parse(Common.ServerIP), 5000);
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
                    requestCount = requestCount + 1;
                    NetworkStream networkStream = clientSocket.GetStream();
                    byte[] buffer = new byte[1000025];
                    networkStream.Read(buffer, 0, (int)clientSocket.ReceiveBufferSize);

                    BinaryReader bReader = new BinaryReader(networkStream);
                    string receiveData = bReader.ReadString();


                    //string dataFromClient = System.Text.Encoding.ASCII.GetString(buffer);
                    //dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    Console.WriteLine(" >> Data from client - " + receiveData);
                    string serverResponse = "Last Message from client" + receiveData;
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();
                    Console.WriteLine(" >> " + serverResponse);
                }
                catch (Exception ex)
                {
                    //Message = "Unable to read data from the transport connection: An existing connection was forcibly closed by the remote host."
                    Console.WriteLine(ex.ToString());
                    return;
                }
            }

            clientSocket.Close();
            serverSocket.Stop();
            Console.WriteLine(" >> exit");
            Console.ReadLine();
        }


        static void ForthWay()
        {
            TcpListener serverSocket = new TcpListener(IPAddress.Parse(Common.ServerIP), 5000);
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
                    requestCount = requestCount + 1;
                    NetworkStream networkStream = clientSocket.GetStream();
                    byte[] buffer = new byte[1000025];
                    networkStream.Read(buffer, 0, (int)clientSocket.ReceiveBufferSize);                  

                    //string dataFromClient = Encoding.ASCII.GetString(buffer);
                    string dataFromClient = Encoding.UTF8.GetString(buffer);

                    //BinaryReader bReader = new BinaryReader(networkStream);
                    //string dataFromClient = bReader.ReadString();

                    var abc = dataFromClient.Length;
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    //dataFromClient = dataFromClient.Substring(0, 100);

                    Console.WriteLine(" >> Data from client - " + dataFromClient);
                    string serverResponse = "Last Message from client" + dataFromClient;
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();
                    Console.WriteLine(" >> " + serverResponse);
                }
                catch (Exception ex)
                {
                    //Message = "Unable to read data from the transport connection: An existing connection was forcibly closed by the remote host."
                    Console.WriteLine(ex.ToString());
                    clientSocket.Close();
                    serverSocket.Stop();
                    return;
                }
            }
        }

    }
}
