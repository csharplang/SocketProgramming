using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace MethodCallEveryXMinutes
{
    public static class Helper
    {
        private static bool IsConnectionSuccessful = false;
        private static Exception socketexception;
        private static ManualResetEvent TimeoutObject = new ManualResetEvent(false);


        public static void ReceiveDataFromServer()
        {
            string receiveData=string.Empty;
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(Common.ServerIP), Convert.ToInt16(Common.ServerPort));
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                server.Connect(ip);
            }
            catch (SocketException e)
            {
                receiveData = e.Message + "---" + DateTime.Now;
                Console.WriteLine(receiveData);
                return;
            }

            byte[] data = new byte[10240];
            int receivedDataLength = server.Receive(data);
            string stringData = Encoding.ASCII.GetString(data, 0, receivedDataLength);

            Console.WriteLine(" Time: " + DateTime.Now + "  " + stringData);

            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        public static void SendData()
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("172.16.1.50"), 5000);

            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                server.Connect(ip);
            }
            catch (SocketException e)
            {
                Console.WriteLine("Unable to connect to server.");
                return;
            }

            Console.WriteLine("Type 'exit' to exit.");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exit")
                    break;
                server.Send(Encoding.ASCII.GetBytes(input));
                byte[] data = new byte[1024];
                int receivedDataLength = server.Receive(data);
                string stringData = Encoding.ASCII.GetString(data, 0, receivedDataLength);
                Console.WriteLine(stringData);
            }

            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }



        public static TcpClient Connect(int timeoutMSec)
        {
            TimeoutObject.Reset();
            socketexception = null;

            string serverip = Common.ServerIP;
            int serverport = Convert.ToInt16(Common.ServerPort);
            TcpClient tcpclient = new TcpClient();

            tcpclient.BeginConnect(serverip, serverport,
                new AsyncCallback(CallBackMethod), tcpclient);

            if (TimeoutObject.WaitOne(timeoutMSec, false))
            {
                if (IsConnectionSuccessful)
                {
                    return tcpclient;
                }
                else
                {
                    throw socketexception;
                }
            }
            else
            {
                tcpclient.Close();
                throw new TimeoutException("TimeOut Exception");
                //Console.WriteLine(" TimeOut Exception: " + DateTime.Now);
            }
        }

        private static void CallBackMethod(IAsyncResult asyncresult)
        {
            try
            {
                IsConnectionSuccessful = false;
                TcpClient tcpclient = asyncresult.AsyncState as TcpClient;

                if (tcpclient.Client != null)
                {
                    tcpclient.EndConnect(asyncresult);
                    IsConnectionSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                IsConnectionSuccessful = false;
                socketexception = ex;
            }
            finally
            {
                TimeoutObject.Set();
            }
        }

        static void ConfigureTcpSocket(Socket tcpSocket)
        {
            // Don't allow another socket to bind to this port.
            tcpSocket.ExclusiveAddressUse = true;

            // The socket will linger for 10 seconds after 
            // Socket.Close is called.
            tcpSocket.LingerState = new LingerOption(true, 10);

            // Disable the Nagle Algorithm for this tcp socket.
            tcpSocket.NoDelay = true;

            // Set the receive buffer size to 8k
            tcpSocket.ReceiveBufferSize = 8192;

            // Set the timeout for synchronous receive methods to 
            // 1 second (1000 milliseconds.)
            tcpSocket.ReceiveTimeout = 1000;

            // Set the send buffer size to 8k.
            tcpSocket.SendBufferSize = 8192;

            // Set the timeout for synchronous send methods
            // to 1 second (1000 milliseconds.)			
            tcpSocket.SendTimeout = 1000;

            // Set the Time To Live (TTL) to 42 router hops.
            tcpSocket.Ttl = 42;

            Console.WriteLine("Tcp Socket configured:");

            Console.WriteLine("  ExclusiveAddressUse {0}",
                        tcpSocket.ExclusiveAddressUse);

            Console.WriteLine("  LingerState {0}, {1}",
                         tcpSocket.LingerState.Enabled,
                             tcpSocket.LingerState.LingerTime);

            Console.WriteLine("  NoDelay {0}",
                                                      tcpSocket.NoDelay);

            Console.WriteLine("  ReceiveBufferSize {0}",
                        tcpSocket.ReceiveBufferSize);

            Console.WriteLine("  ReceiveTimeout {0}",
                        tcpSocket.ReceiveTimeout);

            Console.WriteLine("  SendBufferSize {0}",
                        tcpSocket.SendBufferSize);

            Console.WriteLine("  SendTimeout {0}",
                                                      tcpSocket.SendTimeout);

            Console.WriteLine("  Ttl {0}",
                                                      tcpSocket.Ttl);

            Console.WriteLine("  IsBound {0}",
                                    tcpSocket.IsBound);

            Console.WriteLine("");
        }




    }
}
