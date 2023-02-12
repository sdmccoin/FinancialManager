using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinancialManager.Services.Models
{
    public class Dailies
    {
        [JsonPropertyName("1. open")]
        public string Open { get; set; }
        [JsonPropertyName("2. high")]
        public string High { get; set; }
        [JsonPropertyName("3. low")]
        public string Low { get; set; }
        [JsonPropertyName("4. close")]
        public string Close { get; set; }
        [JsonPropertyName("5. adjusted")]
        public string Adjusted { get; set; }
        [JsonPropertyName("6. volume")]
        public string Volume { get; set; }
        [JsonPropertyName("7. dividend amount")]
        public string DividendAmount { get; set; }
        [JsonPropertyName("5. split coefficient")]
        public string SplitCoefficient { get; set; }
    }
}
/*"Time Series (Daily)": {
        "2023-02-10": {
          
    "1. open": "133.78",
            "2. high": "135.77",
            "3. low": "133.5",
            "4. close": "135.6",
            "5. adjusted close": "135.6",
            "6. volume": "5049571",
            "7. dividend amount": "0.0000",
            "8. split coefficient": "1.0"

        },*/