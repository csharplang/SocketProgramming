﻿using ServerSocket.Logs;
using ServerSocket.Resources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

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
            string serverStarted = " >> Server Started: " + DateTime.Now + " \n ## Waiting for connection... ";
            Console.WriteLine(serverStarted);
            Helper.WrittingLogs(serverStarted);
            clientSocket = serverSocket.AcceptTcpClient();
            string acceptConnection = " >> Accept connection from client: " + DateTime.Now;
            Console.WriteLine(acceptConnection);
            Helper.WrittingLogs(acceptConnection);


            while ((true))
            {
                try
                {
                    requestCount = requestCount + 1;

                    NetworkStream networkStream = clientSocket.GetStream();
                    StreamReader sr = new StreamReader(networkStream);
                    string result = sr.ReadToEnd();
                    byte[] data = FromHex(result);
                    string s = Encoding.BigEndianUnicode.GetString(data); // GatewayServer

                    byte[] bytes = new byte[400000000000000];
                    int bytesRead = networkStream.Read(bytes, 0, clientSocket.ReceiveBufferSize);
                    string receivedData = Encoding.ASCII.GetString(bytes);




                    //byte[] bytes2 = ASCIIEncoding.ASCII.GetBytes(bytes);
                    //string receivedData2 = Convert.ToBase64String(bytes);

                    receivedData = receivedData.Replace("\0", String.Empty);

                    receivedData = receivedData.Replace("$", String.Empty);
                    Console.WriteLine(" >> Data from client - " + receivedData);
                    Helper.WrittingLogs(receivedData);


                    //Reply to client***
                    string serverResponse = "Last Message from Server: Status Code: OK >>" + DateTime.Now;
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString()); 
                    if (ex.Message == ConstantVar.ClientConnLost || ex.InnerException.Message == ConstantVar.innerExceptionClientConnLost)
                    {
                        clientSocket.Close();
                        serverSocket.Stop();
                        serverSocket = new TcpListener(IPAddress.Parse(Common.ServerIP), Convert.ToInt16(Common.ServerPort));
                        requestCount = 0;
                        clientSocket = default(TcpClient);
                        serverSocket.Start();
                        Console.WriteLine(" >> Connection lost... :" + DateTime.Now);
                        Helper.WrittingLogs(" >> Connection lost... :" + DateTime.Now);
                        Console.WriteLine(" >> Server Started after connection lost: " + DateTime.Now + " \n ## Waiting for connection... ");
                        Helper.WrittingLogs(" >> Server Started after connection lost: " + DateTime.Now + " \n ## Waiting for connection... ");
                        clientSocket = serverSocket.AcceptTcpClient();
                        Console.WriteLine(" >> Accept connection from client: " + DateTime.Now);
                        Helper.WrittingLogs(" >> Accept connection from client: " + DateTime.Now);
                    }

                }
            }
        }

        public static byte[] FromHex(string hex)
        {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;
        }



    }
}
