using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinancialManager.Services.Models
{
    public class AnnualReportCashFlow
    {
        [JsonPropertyName("fiscalDateEnding")]
        public string FiscalDateEnding { get; set; }
        [JsonPropertyName("reportedCurrency")]
        public string ReportedCurrency { get; set; }
        [JsonPropertyName("operatingCashflow")]
        public string OperatingCashflow { get; set; }
        [JsonPropertyName("paymentsForOperatingActivities")]
        public string PaymentsForOperatingActivities { get; set; }
        [JsonPropertyName("proceedsFromOperatingActivities")]
        public string ProceedsFromOperatingActivities { get; set; }
        [JsonPropertyName("changeInOperatingLiabilities")]
        public string ChangeInOperatingLiabilities { get; set; }
        [JsonPropertyName("changeInOperatingAssets")]
        public string ChangeInOperatingAssets { get; set; }
        [JsonPropertyName("depreciationDepletionAndAmortization")]
        public string DepreciationDepletionAndAmortization { get; set; }
        [JsonPropertyName("capitalExpenditures")]
        public string CapitalExpenditures { get; set; }
        [JsonPropertyName("changeInReceivables")]
        public string ChangeInReceivables { get; set; }
        [JsonPropertyName("changeInInventory")]
        public string ChangeInInventory { get; set; }
        [JsonPropertyName("profitLoss")]
        public string ProfitLoss { get; set; }
        [JsonPropertyName("cashflowFromInvestment")]
        public string CashflowFromInvestment { get; set; }
        [JsonPropertyName("cashflowFromFinancing")]
        public string CashflowFromFinancing { get; set; }
        [JsonPropertyName("proceedsFromRepaymentsOfShortTermDebt")]
        public string ProceedsFromRepaymentsOfShortTermDebt { get; set; }
        [JsonPropertyName("paymentsForRepurchaseOfCommonStock")]
        public string PaymentsForRepurchaseOfCommonStock { get; set; }
        [JsonPropertyName("paymentsForRepurchaseOfEquity")]
        public string PaymentsForRepurchaseOfEquity { get; set; }
        [JsonPropertyName("paymentsForRepurchaseOfPreferredStock")]
        public string PaymentsForRepurchaseOfPreferredStock { get; set; }
        [JsonPropertyName("dividendPayout")]
        public string DividendPayout { get; set; }
        [JsonPropertyName("dividendPayoutCommonStock")]
        public string DividendPayoutCommonStock { get; set; }
        [JsonPropertyName("dividendPayoutPreferredStock")]
        public string DividendPayoutPreferredStock { get; set; }
        [JsonPropertyName("proceedsFromIssuanceOfCommonStock")]
        public string ProceedsFromIssuanceOfCommonStock { get; set; }
        [JsonPropertyName("proceedsFromIssuanceOfLongTermDebtAndCapitalSecuritiesNet")]
        public string ProceedsFromIssuanceOfLongTermDebtAndCapitalSecuritiesNet { get; set; }
        [JsonPropertyName("proceedsFromIssuanceOfPreferredStock")]
        public string ProceedsFromIssuanceOfPreferredStock { get; set; }
        [JsonPropertyName("proceedsFromRepurchaseOfEquity")]
        public string ProceedsFromRepurchaseOfEquity { get; set; }
        [JsonPropertyName("proceedsFromSaleOfTreasuryStock")]
        public string ProceedsFromSaleOfTreasuryStock { get; set; }
        [JsonPropertyName("changeInCashAndCashEquivalents")]
        public string ChangeInCashAndCashEquivalents { get; set; }
        [JsonPropertyName("changeInExchangeRate")]
        public string ChangeInExchangeRate { get; set; }
        [JsonPropertyName("netIncome")]
        public string NetIncome { get; set; }       
    }
}