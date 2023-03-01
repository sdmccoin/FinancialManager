using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinancialManager.Services.Models
{
    public class CompanyCashFlow
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
        [JsonPropertyName("annualReports")]
        public List<AnnualReportCashFlow> AnnualReportsCashFlow { get; set; }
       
    }
}
