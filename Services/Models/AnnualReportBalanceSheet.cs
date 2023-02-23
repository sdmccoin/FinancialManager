using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinancialManager.Services.Models
{
    public class AnnualReportBalanceSheet
    {
        [JsonPropertyName("fiscalDateEnding")]
        public string FiscalDateEnding { get; set; }
        [JsonPropertyName("reportedCurrency")]
        public string ReportedCurrency { get; set; }
        [JsonPropertyName("totalAssets")]
        public string totalAssets { get; set; }
    }
}
/* "symbol": "IBM",
    "annualReports": [
        {
            "fiscalDateEnding": "2021-12-31",
            "reportedCurrency": "USD",
            "": "132001000000",
            "totalCurrentAssets": "29539000000",
            "cashAndCashEquivalentsAtCarryingValue": "6650000000",
            "cashAndShortTermInvestments": "6650000000",
            "inventory": "1649000000",
            "currentNetReceivables": "14977000000",
            "totalNonCurrentAssets": "101786000000",
            "propertyPlantEquipment": "5694000000",
            "accumulatedDepreciationAmortizationPPE": "14390000000",
            "intangibleAssets": "68154000000",
            "intangibleAssetsExcludingGoodwill": "12511000000",
            "goodwill": "55643000000",
            "investments": "199000000",
            "longTermInvestments": "159000000",
            "shortTermInvestments": "600000000",
            "otherCurrentAssets": "5663000000",
            "otherNonCurrentAssets": "None",
            "totalLiabilities": "113005000000",
            "totalCurrentLiabilities": "33619000000",
            "currentAccountsPayable": "3955000000",
            "deferredRevenue": "16095000000",
            "currentDebt": "13551000000",
            "shortTermDebt": "6787000000",
            "totalNonCurrentLiabilities": "90188000000",
            "capitalLeaseObligations": "63000000",
            "longTermDebt": "56193000000",
            "currentLongTermDebt": "6728000000",
            "longTermDebtNoncurrent": "44917000000",
            "shortLongTermDebtTotal": "110496000000",
            "otherCurrentLiabilities": "9386000000",
            "otherNonCurrentLiabilities": "13996000000",
            "totalShareholderEquity": "18901000000",
            "treasuryStock": "169392000000",
            "retainedEarnings": "154209000000",
            "commonStock": "57319000000",
            "commonStockSharesOutstanding": "898068600"
        },
        {*/
