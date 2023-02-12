using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinancialManager.Services.Models
{
    public class MetaData
    {
        [JsonPropertyName("1. Information")]
        public string Information { get; set; }
        [JsonPropertyName("2. Symbol")]
        public string Symbol { get; set; }
        [JsonPropertyName("3. Last Refreshed")]
        public string LastRefreshed { get; set; }
        [JsonPropertyName("4. Output Size")]
        public string OutputSize { get; set; }
        [JsonPropertyName("5. Time Zone")]
        public string TimeZone { get; set; }
    }
}
/*"1. Information": "Daily Prices (open, high, low, close) and Volumes",
        "2. Symbol": "IBM",
        "3. Last Refreshed": "2023-02-10",
        "4. Output Size": "Compact",
        "5. Time Zone": "US/Eastern"*/