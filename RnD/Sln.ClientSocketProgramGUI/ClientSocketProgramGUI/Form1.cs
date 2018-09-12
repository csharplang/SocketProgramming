using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ClientSocketProgramGUI
{
    public partial class Form1 : Form
    {

        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            msg("Client Started");
            clientSocket.Connect("192.168.0.107", 5000);
            label1.Text = "Client Socket Program - Server Connected ...";
        }

        

        private void btnSend_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(richTextBox2.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            byte[] inStream = new byte[1000025];
            serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
            string returndata = System.Text.Encoding.ASCII.GetString(inStream);
            msg(returndata);
            richTextBox2.Text = "";
            richTextBox2.Focus();
        }

        public void msg(string mesg)
        {
            richTextBox1.Text = richTextBox1.Text + Environment.NewLine + " >> " + mesg;
        }

       
    }
}
