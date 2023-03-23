using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Services.Models
{
    public class CompanyOverviewResponse
    {
        [JsonPropertyName("Symbol")]    //"Symbol": "IBM",
        public string Symbol { get; set; }
        [JsonPropertyName("AssetType")] //    "AssetType": "Common Stock",
        public string AssetType { get; set; }
        [JsonPropertyName("Name")]  //    "Name": "International Business Machines",
        public string Name { get; set; }
        [JsonPropertyName("Description")]   //    "Description": "International
        public string Description { get; set; }
        [JsonPropertyName("CIK")]   //    "CIK": "51143",
        public string CIK { get; set; }
        [JsonPropertyName("Exchange")]  //    "Exchange": "NYSE",
        public string Exchange { get; set; }
        [JsonPropertyName("Currency")]  //    "Currency": "USD",
        public string Currency { get; set; }
        [JsonPropertyName("Country")]   //    "Country": "USA",
        public string Country { get; set; }
        [JsonPropertyName("Sector")]
        public string Sector { get; set; }
        [JsonPropertyName("Industry")]
        public string Industry { get; set; }
        [JsonPropertyName("Address")]
        public string Address { get; set; }
        [JsonPropertyName("FiscalYearEnd")]
        public string FiscalYearEnd { get; set; }
        [JsonPropertyName("LatestQuarter")]
        public string LatestQuarter { get; set; }
        [JsonPropertyName("MarketCapitalization")]
        public string MarketCapitalization { get; set; }
        [JsonPropertyName("EBITDA")]
        public string EBITDA { get; set; }
        [JsonPropertyName("PERatio")]
        public string PERatio { get; set; }
        [JsonPropertyName("PEGRatio")]
        public string PEGRatio { get; set; }
        [JsonPropertyName("BookValue")]
        public string BookValue { get; set; }
        [JsonPropertyName("DividendPerShare")]
        public string DividendPerShare { get; set; }
        [JsonPropertyName("DividendYield")]
        public string DividendYield { get; set; }
        [JsonPropertyName("EPS")]
        public string EPS { get; set; }
        [JsonPropertyName("RevenuePerShareTTM")]
        public string RevenuePerShareTTM { get; set; }
        [JsonPropertyName("ProfitMargin")]
        public string ProfitMargin { get; set; }
        [JsonPropertyName("OperatingMarginTTM")]
        public string OperatingMarginTTM { get; set; }
        [JsonPropertyName("ReturnOnAssetsTTM")]
        public string ReturnOnAssetsTTM { get; set; }
        [JsonPropertyName("ReturnOnEquityTTM")]
        public string ReturnOnEquityTTM { get; set; }
        [JsonPropertyName("RevenueTTM")]
        public string RevenueTTM { get; set; }
        [JsonPropertyName("GrossProfitTTM")]
        public string GrossProfitTTM { get; set; }
        [JsonPropertyName("DilutedEPSTTM")]
        public string DilutedEPSTTM { get; set; }
        [JsonPropertyName("QuarterlyEarningsGrowthYOY")]
        public string QuarterlyEarningsGrowthYOY { get; set; }
        [JsonPropertyName("QuarterlyRevenueGrowthYOY")]
        public string QuarterlyRevenueGrowthYOY { get; set; }
        [JsonPropertyName("AnalystTargetPrice")]
        public string AnalystTargetPrice { get; set; }
        [JsonPropertyName("TrailingPE")]
        public string TrailingPE { get; set; }
        [JsonPropertyName("ForwardPE")]
        public string ForwardPE { get; set; }
        [JsonPropertyName("PriceToSalesRatioTTM")]
        public string PriceToSalesRatioTTM { get; set; }
        [JsonPropertyName("PriceToBookRatio")]
        public string PriceToBookRatio { get; set; }
        [JsonPropertyName("EVToRevenue")]
        public string EVToRevenue { get; set; }
        [JsonPropertyName("EVToEBITDA")]
        public string EVToEBITDA { get; set; }
        [JsonPropertyName("Beta")]
        public string Beta { get; set; }
        [JsonPropertyName("52WeekHigh")]
        public string FiftyTwoWeekHigh { get; set; }
        [JsonPropertyName("52WeekLow")]
        public string FiftyTwoWeekLow { get; set; }
        [JsonPropertyName("50DayMovingAverage")]
        public string FiftyDayMovingAverage { get; set; }
        [JsonPropertyName("200DayMovingAverage")]
        public string TwoHundredDayMovingAverage { get; set; }
        [JsonPropertyName("SharesOutstanding")]
        public string SharesOutstanding { get; set; }
        [JsonPropertyName("DividendDate")]
        public string DividendDate { get; set; }
        [JsonPropertyName("ExDividendDate")]
        public string ExDividendDate { get; set; }        
    }
}
//


// Business Machines Corporation (IBM) is an American multinational technology company headquartered in Armonk, New York, with operations in over 170 countries. The company began in 1911, founded in Endicott, New York, as the Computing-Tabulating-Recording Company (CTR) and was renamed International Business Machines in 1924. IBM is incorporated in New York. IBM produces and sells computer hardware, middleware and software, and provides hosting and consulting services in areas ranging from mainframe computers to nanotechnology. IBM is also a major research organization, holding the record for most annual U.S. patents generated by a business (as of 2020) for 28 consecutive years. Inventions by IBM include the automated teller machine (ATM), the floppy disk, the hard disk drive, the magnetic stripe card, the relational database, the SQL programming language, the UPC barcode, and dynamic random-access memory (DRAM). The IBM mainframe, exemplified by the System/360, was the dominant computing platform during the 1960s and 1970s.",




//    "Sector": "TECHNOLOGY",
//    "Industry": "COMPUTER & OFFICE EQUIPMENT",
//    "Address": "1 NEW ORCHARD ROAD, ARMONK, NY, US",
//    "FiscalYearEnd": "December",
//    "LatestQuarter": "2022-12-31",
//    "MarketCapitalization": "121541001000",
//    "EBITDA": "12327999000",
//    "PERatio": "22.27",
//    "PEGRatio": "1.276",
//    "BookValue": "24.23",
//    "DividendPerShare": "6.59",
//    "DividendYield": "0.0487",
//    "EPS": "6.09",
//    "RevenuePerShareTTM": "67.05",
//    "ProfitMargin": "0.0271",
//    "OperatingMarginTTM": "0.124",
//    "ReturnOnAssetsTTM": "0.0363",
//    "ReturnOnEquityTTM": "0.0869",
//    "RevenueTTM": "60530000000",
//    "GrossProfitTTM": "32687000000",
//    "DilutedEPSTTM": "6.09",
//    "QuarterlyEarningsGrowthYOY": "0.147",
//    "QuarterlyRevenueGrowthYOY": "4.123",
//    "AnalystTargetPrice": "146.76",
//    "TrailingPE": "22.27",
//    "ForwardPE": "15.55",
//    "PriceToSalesRatioTTM": "2.108",
//    "PriceToBookRatio": "6.75",
//    "EVToRevenue": "2.969",
//    "EVToEBITDA": "25.81",
//    "Beta": "0.852",
//    "52WeekHigh": "151.35",
//    "52WeekLow": "112.8",
//    "50DayMovingAverage": "141.91",
//    "200DayMovingAverage": "135.7",
//    "SharesOutstanding": "896320000",
//    "DividendDate": "2023-03-10",
//    "ExDividendDate": "2023-02-09"