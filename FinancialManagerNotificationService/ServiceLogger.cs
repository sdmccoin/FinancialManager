using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerNotificationService
{
    public class ServiceLogger
    {
        public static void WriteToFile(string message)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                Log(message, w);
            }
        }

        public static string ReadFromFile()
        {
            string dump = "";
            using (StreamReader r = File.OpenText("log.txt"))
            {
                dump = DumpLog(r);
            }

            return dump;
        }

        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
        }

        private static string DumpLog(StreamReader r)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string line;
            while ((line = r.ReadLine()) != null)
            {
                stringBuilder.Append(line);
            }

            return stringBuilder.ToString();
        }
    }
}
