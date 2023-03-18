using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerNotificationService
{
    /// <summary>
    /// Singleton class used for reading and writing log files
    /// </summary>
    public sealed class ServiceLogger
    {
        private static readonly ServiceLogger instance = new ServiceLogger();

        static ServiceLogger() { }
        private ServiceLogger() { }

        public static void Log(string message)
        {
            using (StreamWriter w = File.AppendText("C:\\FinancialManager\\log.txt"))
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
            w.WriteLine($"{DateTime.Now.ToShortDateString()}");            
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
