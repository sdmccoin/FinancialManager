using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Services
{
    public static class API
    {
        public static string StockKey { get { return "PW20D2R6TX4Y8B5A"; } }
        public static string StockSearchURL {  get { return "https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords="; } }
        public static string StockSearchDailies { get { return "https://www.alphavantage.co/query?function=TIME_SERIES_DAILY_ADJUSTED&symbol="; } }
        public static string SymbolSearch { get { return "https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords="; } }
        public static string StockCompanyOverview { get { return "https://www.alphavantage.co/query?function=OVERVIEW&symbol="; } }
        public static string StockIncomeStatement { get { return "https://www.alphavantage.co/query?function=INCOME_STATEMENT&symbol="; } }
        public static string StockBalanceSheet { get { return "https://www.alphavantage.co/query?function=BALANCE_SHEET&symbol="; } }
        public static string StockCashFlow { get { return "https://www.alphavantage.co/query?function=CASH_FLOW&symbol="; } }
    }
}
