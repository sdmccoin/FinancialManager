using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinancialManager.Services.Models
{
    public class AnnualReport
    {
        [JsonPropertyName("fiscalDateEnding")]
        public string FiscalDateEnding { get; set; }
        [JsonPropertyName("reportedCurrency")]
        public string ReportedCurrency { get; set; }
        [JsonPropertyName("grossProfit")]
        public string GrossProfit { get; set; }
        [JsonPropertyName("totalRevenue")]
        public string TotalRevenue { get; set; }
        [JsonPropertyName("costofGoodsAndServicesSold")]
        public string CostofGoodsAndServicesSold { get; set; }
        [JsonPropertyName("operatingIncome")]
        public string OperatingIncome { get; set; }
        [JsonPropertyName("sellingGeneralAndAdministrative")]
        public string SellingGeneralAndAdministrative { get; set; }
        [JsonPropertyName("researchAndDevelopment")]
        public string ResearchAndDevelopment { get; set; }
        [JsonPropertyName("operatingExpenses")]
        public string OperatingExpenses { get; set; }
        [JsonPropertyName("investmentIncomeNet")]
        public string investmentIncomeNet { get; set; }
        [JsonPropertyName("netInterestIncome")]
        public string netInterestIncome { get; set; }
        [JsonPropertyName("interestIncome")]
        public string interestIncome { get; set; }
        [JsonPropertyName("interestExpense")]
        public string interestExpense { get; set; }
        [JsonPropertyName("nonInterestIncome")]
        public string nonInterestIncome { get; set; }
        [JsonPropertyName("otherNonOperatingIncome")]
        public string otherNonOperatingIncome { get; set; }
        [JsonPropertyName("depreciation")]
        public string depreciation { get; set; }
        [JsonPropertyName("depreciationAndAmortization")]
        public string depreciationAndAmortization { get; set; }
        [JsonPropertyName("incomeBeforeTax")]
        public string incomeBeforeTax { get; set; }
        [JsonPropertyName("incomeTaxExpense")]
        public string incomeTaxExpense { get; set; }
        [JsonPropertyName("interestAndDebtExpense")]
        public string interestAndDebtExpense { get; set; }
        [JsonPropertyName("netIncomeFromContinuingOperations")]
        public string netIncomeFromContinuingOperations { get; set; }
        [JsonPropertyName("comprehensiveIncomeNetOfTax")]
        public string comprehensiveIncomeNetOfTax { get; set; }
        [JsonPropertyName("ebit")]
        public string ebit { get; set; }
        [JsonPropertyName("ebitda")]
        public string ebitda { get; set; }
        [JsonPropertyName("netIncome")]
        public string netIncome { get; set; }      
    }
}
