using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SendDataGUI
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        private SerialPort port = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port.Open();
            // Write a string
            port.Write(txtSend.Text);

            // Write a set of bytes
            port.Write(new byte[] { 0x0A, 0xE2, 0xFF }, 0, 3);

            // Close the port
            port.Close();
            txtSend.Text = "";
            txtSend.Focus();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            txtSend.Text += string.Format("{0}\r\n", DateTime.Now);
        }
    }
}
