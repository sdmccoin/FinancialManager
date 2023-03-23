using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Services.Models
{
    public class CompanyBalanceSheet
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
        [JsonPropertyName("annualReports")]
        public List<AnnualReportBalanceSheet> AnnualReportsBalanceSheet { get; set; }
    }
}


