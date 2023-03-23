using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Services.Models
{
    public class AnnualReportBalanceSheet
    {
        [JsonPropertyName("fiscalDateEnding")]
        public string FiscalDateEnding { get; set; }
        [JsonPropertyName("reportedCurrency")]
        public string ReportedCurrency { get; set; }
        [JsonPropertyName("totalAssets")]
        public string TotalAssets { get; set; }
        [JsonPropertyName("totalCurrentAssets")]
        public string TotalCurrentAssets { get; set; }
        [JsonPropertyName("cashAndCashEquivalentsAtCarryingValue")]
        public string CashAndCashEquivalentsAtCarryingValue { get; set; }
        [JsonPropertyName("cashAndShortTermInvestments")]
        public string CashAndShortTermInvestments { get; set; }
        [JsonPropertyName("inventory")]
        public string Inventory { get; set; }
        [JsonPropertyName("currentNetReceivables")]
        public string CurrentNetReceivables { get; set; }
        [JsonPropertyName("totalNonCurrentAssets")]
        public string TotalNonCurrentAssets { get; set; }
        [JsonPropertyName("propertyPlantEquipment")]
        public string PropertyPlantEquipment { get; set; }
        [JsonPropertyName("accumulatedDepreciationAmortizationPPE")]
        public string AccumulatedDepreciationAmortizationPPE { get; set; }
        [JsonPropertyName("intangibleAssets")]
        public string IntangibleAssets { get; set; }
        [JsonPropertyName("intangibleAssetsExcludingGoodwill")]
        public string IntangibleAssetsExcludingGoodwill { get; set; }
        [JsonPropertyName("goodwill")]
        public string Goodwill { get; set; }
        [JsonPropertyName("investments")]
        public string Investments { get; set; }
        [JsonPropertyName("longTermInvestments")]
        public string LongTermInvestments { get; set; }
        [JsonPropertyName("shortTermInvestments")]
        public string ShortTermInvestments { get; set; }
        [JsonPropertyName("otherCurrentAssets")]
        public string OtherCurrentAssets { get; set; }
        [JsonPropertyName("otherNonCurrentAssets")]
        public string OtherNonCurrentAssets { get; set; }
        [JsonPropertyName("totalLiabilities")]
        public string TotalLiabilities { get; set; }
        [JsonPropertyName("totalCurrentLiabilities")]
        public string TotalCurrentLiabilities { get; set; }
        [JsonPropertyName("currentAccountsPayable")]
        public string CurrentAccountsPayable { get; set; }
        [JsonPropertyName("deferredRevenue")]
        public string DeferredRevenue { get; set; }
        [JsonPropertyName("currentDebt")]
        public string CurrentDebt { get; set; }
        [JsonPropertyName("shortTermDebt")]
        public string ShortTermDebt { get; set; }
        [JsonPropertyName("totalNonCurrentLiabilities")]
        public string TotalNonCurrentLiabilities { get; set; }
        [JsonPropertyName("capitalLeaseObligations")]
        public string CapitalLeaseObligations { get; set; }
        [JsonPropertyName("longTermDebt")]
        public string LongTermDebt { get; set; }
        [JsonPropertyName("currentLongTermDebt")]
        public string currentLongTermDebt { get; set; }
        [JsonPropertyName("longTermDebtNoncurrent")]
        public string LongTermDebtNoncurrent { get; set; }
        [JsonPropertyName("shortLongTermDebtTotal")]
        public string ShortLongTermDebtTotal { get; set; }
        [JsonPropertyName("otherCurrentLiabilities")]
        public string OtherCurrentLiabilities { get; set; }
        [JsonPropertyName("otherNonCurrentLiabilities")]
        public string OtherNonCurrentLiabilities { get; set; }
        [JsonPropertyName("totalShareholderEquity")]
        public string TotalShareholderEquity { get; set; }
        [JsonPropertyName("treasuryStock")]
        public string TreasuryStock { get; set; }
        [JsonPropertyName("retainedEarnings")]
        public string RetainedEarnings { get; set; }
        [JsonPropertyName("commonStock")]
        public string CommonStock { get; set; }
        [JsonPropertyName("commonStockSharesOutstanding")]
        public string CommonStockSharesOutstanding { get; set; }
    }
}

