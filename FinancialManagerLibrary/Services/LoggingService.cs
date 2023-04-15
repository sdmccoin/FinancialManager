using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Services
{
    /// <summary>
    /// singleton logging service
    /// </summary>
    public sealed class LoggingService
    {
        private static readonly LoggingService instance = new LoggingService();

        static LoggingService() { }
        private LoggingService() { }

        public static LoggingService GetInstance { get { return instance; } }

        public void Log(string message)
        {
            using (StreamWriter w = File.AppendText(ConfigurationService.GetInstance.GetAllConfigItems().Get("LogLocation") + "log.txt"))
            {
                Log(message, w);
                //Log("Test2", w);
            }
        }
        public void ClearLogs()
        {
            using (StreamWriter w = File.CreateText(ConfigurationService.GetInstance.GetAllConfigItems().Get("LogLocation") + "log.txt"))
            {
                Log("Log File Created", w);
                //Log("Test2", w);
            }
        }

        public string ReadFromFile()
        {
            string dump = "";
            using (StreamReader r = File.OpenText(ConfigurationService.GetInstance.GetAllConfigItems().Get("LogLocation") + "log.txt"))
            {
                dump = DumpLog(r);
            }

            return dump;
        }

        private void Log(string logMessage, TextWriter w)
        {
            w.Write("`"); // create new line
            w.WriteLine("Log Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
        }

        private string DumpLog(StreamReader r)
        {
            StringBuilder stringBuilder= new StringBuilder();
            string line;
            while ((line = r.ReadLine()) != null)
            {
                if (line.Contains("`"))
                    stringBuilder.Append(Environment.NewLine);
                else
                    stringBuilder.Append(line);
            }

            return stringBuilder.ToString();
        }
    }
}
