using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace ReceiveDataGUI
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        SerialPort serialPort = new SerialPort();
        FileStream saveDataFS = null;
        public RadForm1()
        {
            InitializeComponent();
        }
        private void RadForm1_Load(object sender, EventArgs e)
        {
            serialPort.PortName = "COM3";
            serialPort.BaudRate = 9600;
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;

            serialPort.DataReceived += new SerialDataReceivedEventHandler(dataReceived);

            serialPort.DtrEnable = true;
            serialPort.RtsEnable = true;
            //Set the data read timeout to 1 second
            serialPort.ReadTimeout = 1000;
            serialPort.Open();
            //serialPort.Close();

            //buttonSendData.Enabled = false;
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                DateTime dateTimeNow = DateTime.Now;
                txtRec.Text += string.Format("{0}\r\n", dateTimeNow);
                txtRec.ForeColor = Color.Red;    //Change the color of the font

                try
                {
                    String input = serialPort.ReadExisting();
                    txtRec.Text += input + "\r\n";
                    // save data to file
                    if (saveDataFS != null)
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(input + "\r\n");
                        saveDataFS.Write(info, 0, info.Length);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Problem");
                    return;
                }

                txtRec.SelectionStart = txtRec.Text.Length;
                txtRec.ScrollToCaret();//Scroll to the cursor
                serialPort.DiscardInBuffer(); //Empty the Buffer of the SerialPort control        
            }
            else
            {
                MessageBox.Show("Please open a serial port", "Error Message");
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }
    }
}
