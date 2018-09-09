using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ServerAppGUI
{
    public partial class Form1 : Form
    {
        const int PORT_NO = 5000;
        const string SERVER_IP = "192.168.0.100";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            //richSendData.Text = DateTime.Now.ToString();
            string textToSend = richSendData.Text;
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);


            //---listen at the specified IP and port no.---
            IPAddress localAdd = IPAddress.Parse(SERVER_IP);
            TcpListener listener = new TcpListener(localAdd, PORT_NO);
            lblListening.Text = "Listening...";
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
