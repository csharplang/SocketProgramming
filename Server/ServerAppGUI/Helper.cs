using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ServerAppGUI
{
    public static class Helper
    {
        public static void SendData(RichTextBox richSendData)
        {
            //richSendData.Text = DateTime.Now.ToString();
            string textToSend = richSendData.Text;
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);


            //---listen at the specified IP and port no.---
            IPAddress localAdd = IPAddress.Parse(Common.ServerIP);
            TcpListener listener = new TcpListener(localAdd, Convert.ToInt16(Common.ServerPort));
            listener.Start();

            //---incoming client connected---
            TcpClient client = listener.AcceptTcpClient();

            //---get the incoming data through a network stream---
            NetworkStream nwStream = client.GetStream();
            //byte[] buffer = new byte[client.ReceiveBufferSize];


            //---send the text---
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);


            client.Close();
            listener.Stop();
        }
    }
}
