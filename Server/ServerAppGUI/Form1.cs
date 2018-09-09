using System;
using System.Windows.Forms;

namespace ServerAppGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSendData_Click(object sender, EventArgs e)
        {
            Helper.SendData(richSendData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
