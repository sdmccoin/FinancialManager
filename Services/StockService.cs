using FinancialManager.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FinancialManager.Services
{
    public class StockService
    {
        public string URL { get; set; }

        public T GetAsync<T>()
        {
            T response = default;
            using (WebClient client = new WebClient())
            {
                Task taskA = Task.Run(() => response = JsonSerializer.Deserialize<T>(client.DownloadString(URL)));
                taskA.Wait();
            }
            return response;
        }
        public T GetAsync<T>(string url)
        {
            T response = default;
            using (WebClient client = new WebClient())
            {
                Task taskA = Task.Run(() => response = JsonSerializer.Deserialize<T>(client.DownloadString(url)));
                taskA.Wait();
            }
            return response;
        }
    }
}
