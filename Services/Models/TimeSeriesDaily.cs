using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinancialManager.Services.Models
{
    public class TimeSeriesDaily
    {
        public Dictionary<string,Dailies> Dailies { get; set; }
    }
}
/*"Time Series (Daily)": {
        "2023-02-10": {
            "1. open": "133.7800",
            "2. high": "135.7700",
            "3. low": "133.5000",
            "4. close": "135.6000",
            "5. volume": "5049571"
        },*/