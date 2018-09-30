using System;
using System.Text;

namespace Uncode
{
    class Program
    {
        static void Main(string[] args)
        {
            //string resultMachine = "O| 1 |S19255 | |^^^T4 | R | | | | | | | | | | | | | | | | | | | | O <CR>";
            string resultNaormalText = "Hello";
            byte[] byteResult = Encoding.ASCII.GetBytes(resultNaormalText);

            string receivedData = Encoding.ASCII.GetString(byteResult);

            Console.WriteLine(receivedData);
            Console.ReadKey();
        }
    }
}

// ASCII UTF7 UTF8 UTF32 Unicode
