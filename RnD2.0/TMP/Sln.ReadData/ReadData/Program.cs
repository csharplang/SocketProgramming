using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadData
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Instatiate this class
            SerialPortProgram();

            Console.ReadLine();
        }

        private static void SerialPortProgram()
        {
            // Create the serial port with basic settings
            SerialPort port = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);

            Console.WriteLine("Incoming Data:");

            // Attach a method to be called when there
            // is data waiting in the port's buffer
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

            // Begin communications
            port.Open();

            var abc = port.ReadExisting();

            // Enter an application loop to keep this thread alive
            // Application.Run();
        }

        private static void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Create the serial port with basic settings
            SerialPort port = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);

            // Show all the incoming data in the port's buffer
            Console.WriteLine(port.ReadExisting());
        }
    }
}
