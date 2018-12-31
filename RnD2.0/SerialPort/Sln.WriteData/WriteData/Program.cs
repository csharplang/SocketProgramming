using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace WriteData
{
    class Program
    {
        static void Main(string[] args)
        {
            //var abc = HandleSerialMessage1("ABCD");
            //var ab2 = HandleSerialMessage2("ABCD");

            // Instantiate the communications
            // port with some basic settings
            SerialPort port = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);
            // Open the port for communications
            port.Open();
            // Write a string
            port.Write("Hello World");

            // Write a set of bytes
            port.Write(new byte[] { 0x0A, 0xE2, 0xFF }, 0, 3);

            // Close the port
            port.Close();
            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }

        private static string HandleSerialMessage1(string data)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append('\x0006');
            return stringBuilder.ToString();
        }

        private static string HandleSerialMessage2(string data)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append('\v');
            stringBuilder.Append('\x001C');
            stringBuilder.Append('\r');
            return stringBuilder.ToString();
        }
    }
}
