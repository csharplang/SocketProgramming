using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ClientSocketProgramGUI
{
    public static class Helper
    {      
        public static void SendDataToServer(RichTextBox richTextBox2)
        {
            TcpClient clientSocket = new TcpClient();
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = Encoding.ASCII.GetBytes(richTextBox2.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            byte[] inStream = new byte[1000025];
            serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
            string returndata = System.Text.Encoding.ASCII.GetString(inStream);
            //msg(returndata); ???
            richTextBox2.Text = "";
            richTextBox2.Focus();
        }
    }
}
