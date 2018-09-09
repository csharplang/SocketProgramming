using System;
using System.Net;

namespace MethodCallEveryXMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new System.Threading.Timer(
                e => Helper.ReceiveDataFromServer(),
                null,
                TimeSpan.Zero,
                TimeSpan.FromSeconds(5));

  
            Console.ReadLine();
        }
    }
}
