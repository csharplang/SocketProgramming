using System;
using System.IO;

namespace ServerSocket.Logs
{
    public static class Helper
    {
        public static void WrittingLogs(string message)
        {
            string fileLoc = Path.GetFullPath(Path.Combine(GlobalVariables.strFilesLocs, @"..\")) + "\\Logs\\Messages.txt";

            if (!File.Exists(fileLoc)) File.Create(fileLoc).Close();

            if (File.Exists(fileLoc))
            {
                using (StreamWriter w = File.AppendText(fileLoc))
                {
                    Log(message, w);
                }

                //using (StreamReader r = File.OpenText(fileLoc))
                //{
                //    DumpLog(r);
                //}
            }
        }

        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("-------------------------------");
        }

        public static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
