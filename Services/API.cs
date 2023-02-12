using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Services
{
    public static class API
    {
        public static string StockKey { get { return "PW20D2R6TX4Y8B5A"; } }

        public static string StockSearchURL {  get { return "https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords="; } }
        public static string StockSearchDailies { get { return "https://www.alphavantage.co/query?function=TIME_SERIES_DAILY_ADJUSTED&symbol="; } }
    }
}
