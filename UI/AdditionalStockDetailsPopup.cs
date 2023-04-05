using FinancialManagerLibrary.Services.Models;
using FinancialManagerLibrary.Services;
using FinancialManagerLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.Json;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms.TimeSeries;
using Microsoft.ML;
using System.Data.SQLite;
using FinancialManagerLibrary.Utilities;

namespace FinancialManager.UI
{
    public partial class AdditionalStockDetailsPopup : Form
    {
        private string stockName;
        private string symbol;
        private StockService ss;

        public AdditionalStockDetailsPopup(string stockName, string symbol)
        {
            InitializeComponent();
            ss = new StockService();
            this.stockName = stockName; 
            this.symbol = symbol;
            this.Text = stockName+ " (" + symbol + ")";            
        }

        private void AdditionalStockDetailsPopup_Load(object sender, EventArgs e)
        {
            this.Text= this.stockName;
            this.Icon = SystemIcons.Information;

            LoadOverviewInformation();
            LoadIncomeStatementInformation();
            LoadBalanceSheetInformation();
            LoadCashFlowInformation();
            RunStockAnalytics();
        }

        private void LoadOverviewInformation()
        {
            CompanyOverviewResponse response = new CompanyOverviewResponse();
            response = ss.GetAsync<CompanyOverviewResponse>(API.StockCompanyOverview + symbol + "&apikey=" + API.StockKey);
                        
            if (response != null)
            {
                DisplayOverViewInformation(response);
            }
            
        }
        private void LoadIncomeStatementInformation()
        {            
            CompanyIncomeStatement response = new CompanyIncomeStatement();
            response = ss.GetAsync<CompanyIncomeStatement>(API.StockIncomeStatement + symbol + "&apikey=" + API.StockKey);

            if (response != null)
            {
                if (response.AnnualReports != null)
                {
                    DisplayIncomeStatementInformation(response.AnnualReports[0]);
                }                    
            }            
        }
        private void LoadBalanceSheetInformation()
        {
            CompanyBalanceSheet response = new CompanyBalanceSheet();            
            response = ss.GetAsync<CompanyBalanceSheet>(API.StockBalanceSheet + symbol + "&apikey=" + API.StockKey);
           
            if (response != null)
            {
                if (response.AnnualReportsBalanceSheet != null)
                {
                    DisplayBalanceSheetInformation(response.AnnualReportsBalanceSheet[0]);
                }
            }            
        }

        private void LoadCashFlowInformation()
        {
            CompanyCashFlow response = new CompanyCashFlow();
            response = ss.GetAsync<CompanyCashFlow>(API.StockCashFlow + symbol + "&apikey=" + API.StockKey);

            if (response != null)
            {
                if (response.AnnualReportsCashFlow != null)
                {
                    DisplayCashFlowInformation(response.AnnualReportsCashFlow[0]);
                }
            }
        }

        private void DisplayOverViewInformation(CompanyOverviewResponse response)
        {
            lblSymbol.Text = (response.Symbol == null) ? "-" : response.Symbol;
            lblAssetType.Text = (response.AssetType == null) ? "-" : response.AssetType;
            lblName.Text = (response.Name == null) ? "-" : response.Name;
            lblDescription.Text = (response.Description == null) ? "-" : response.Description;
            lblSector.Text = (response.Sector == null) ? "-" : response.Sector;
            lblIndustry.Text = (response.Industry == null) ? "-" : response.Industry;
            lblAddress.Text = (response.Address == null) ? "-" : response.Address;
            lblExchange.Text = (response.Exchange == null) ? "-" : response.Exchange;
            lblCurrency.Text = (response.Currency == null) ? "-" : response.Currency;
            lblCountry.Text = (response.Country == null) ? "-" : response.Country;
            lblSector.Text = (response.Sector == null) ? "-" : response.Sector;
            lblIndustry.Text = (response.Industry == null) ? "-" : response.Industry;
            lblMarketCapitalization.Text = Utilities.FormatCurrency(response.MarketCapitalization);
            lblBookValue.Text = Utilities.FormatCurrency(response.BookValue);
            lblDividendPerShare.Text = Utilities.FormatCurrency(response.DividendPerShare);
            lblDividendYield.Text = Utilities.FormatCurrency(response.DividendYield);
            lblEPS.Text = Utilities.FormatCurrency(response.EPS);
            lblRevenuePerShareTTM.Text = Utilities.FormatCurrency(response.RevenuePerShareTTM);
            lblProfitMargin.Text = Utilities.FormatCurrency(response.ProfitMargin);
            lblOperatingMarginTTM.Text = Utilities.FormatCurrency(response.OperatingMarginTTM);
            lblReturnOnAssetsTTM.Text = Utilities.FormatCurrency(response.ReturnOnAssetsTTM);
            lblReturnOnEquity.Text = Utilities.FormatCurrency(response.ReturnOnEquityTTM);
            lblRevenueTTM.Text = Utilities.FormatCurrency(response.RevenueTTM);
            lblGrossProfitTTM.Text = Utilities.FormatCurrency(response.GrossProfitTTM);
            lblSharesOutstanding.Text = (response.SharesOutstanding == null) ? "-" : response.SharesOutstanding;
            lblQuarterlyEarningsGrowthYOY.Text = Utilities.FormatCurrency(response.QuarterlyEarningsGrowthYOY);
            lblQuarterlyRevenueGrowthYOY.Text = Utilities.FormatCurrency(response.QuarterlyRevenueGrowthYOY);
            lblAnalystTargetPrice.Text = Utilities.FormatCurrency(response.AnalystTargetPrice);
            lblTrailingPE.Text = Utilities.FormatCurrency(response.TrailingPE);
            lblForwardPE.Text = Utilities.FormatCurrency(response.ForwardPE);
            lblPriceToSalesRatioTTM.Text = Utilities.FormatCurrency(response.PriceToSalesRatioTTM);
            lblPriceToBookRatio.Text = Utilities.FormatCurrency(response.PriceToBookRatio);
            lblEVToRevenue.Text = Utilities.FormatCurrency(response.EVToRevenue);
            lblFiftyTwoWeekHigh.Text = Utilities.FormatCurrency(response.FiftyTwoWeekHigh);
            lblFiftyTwoWeekLow.Text = Utilities.FormatCurrency(response.FiftyTwoWeekLow);
            lblFiftyDayMovingAverage.Text = Utilities.FormatCurrency(response.FiftyDayMovingAverage);
            lblTwoHundredDayMovingAverage.Text = Utilities.FormatCurrency(response.TwoHundredDayMovingAverage);
        }
        private void DisplayIncomeStatementInformation(AnnualReport response)
        {

            lblFiscalDateEnding.Text = (response.FiscalDateEnding == null) ? "-" : response.FiscalDateEnding;
            lblReportedCurrency.Text = (response.ReportedCurrency == null) ? "-" : response.ReportedCurrency;
            lblGrossProfit.Text = Utilities.FormatCurrency(response.GrossProfit);
            lblTotalRevenue.Text = (response.TotalRevenue == null) ? "-" : response.TotalRevenue;
            lblCostofGoodsAndServicesSold.Text = Utilities.FormatCurrency(response.CostofGoodsAndServicesSold);
            lblOperatingIncome.Text = Utilities.FormatCurrency(response.OperatingIncome);
            lblSellingGeneralAndAdministrative.Text = Utilities.FormatCurrency(response.SellingGeneralAndAdministrative);
            lblResearchAndDevelopment.Text = Utilities.FormatCurrency(response.ResearchAndDevelopment);
            lblOperatingExpenses.Text = Utilities.FormatCurrency(response.OperatingExpenses);
            lblinvestmentIncomeNet.Text = Utilities.FormatCurrency(response.investmentIncomeNet);
            lblnetInterestIncome.Text = Utilities.FormatCurrency(response.netInterestIncome);
            lblinterestIncome.Text = Utilities.FormatCurrency(response.interestExpense);
            lblnonInterestIncome.Text = Utilities.FormatCurrency(response.nonInterestIncome);
            lblotherNonOperatingIncome.Text = Utilities.FormatCurrency(response.otherNonOperatingIncome);
            lblDepreciation.Text = Utilities.FormatCurrency(response.depreciation);
            lbldepreciationAndAmortization.Text = response.depreciationAndAmortization;
            lblincomeBeforeTax.Text = Utilities.FormatCurrency(response.incomeBeforeTax);
            lblincomeTaxExpense.Text = Utilities.FormatCurrency(response.incomeTaxExpense);
            lblinterestAndDebtExpense.Text = Utilities.FormatCurrency(response.interestAndDebtExpense);
            lblnetIncomeFromContinuingOperations.Text = Utilities.FormatCurrency(response.netIncomeFromContinuingOperations);
            lblcomprehensiveIncomeNetOfTax.Text = Utilities.FormatCurrency(response.comprehensiveIncomeNetOfTax);
            lblnetIncome.Text = Utilities.FormatCurrency(response.netIncome);
        }
        private void DisplayBalanceSheetInformation(AnnualReportBalanceSheet response)
        {
            lblFiscalDateEndingBS.Text = response.FiscalDateEnding;
            lblReportedCurrencyBS.Text = response.ReportedCurrency;
            lblTotalAssets.Text = Utilities.FormatCurrency(response.TotalAssets);
            lblTotalCurrentAssets.Text = Utilities.FormatCurrency(response.TotalCurrentAssets);
            lblCashAndCashEquiv.Text = Utilities.FormatCurrency(response.CashAndCashEquivalentsAtCarryingValue);
            lblCashAndShortTerm.Text = Utilities.FormatCurrency(response.CashAndShortTermInvestments);
            lblInventory.Text = Utilities.FormatCurrency(response.Inventory);
            lblCurrentNetReceivables.Text = Utilities.FormatCurrency(response.CurrentNetReceivables);
            lblTotalNonCurrentAssets.Text = Utilities.FormatCurrency(response.TotalNonCurrentAssets);
            lblPropertyPlanEquip.Text = Utilities.FormatCurrency(response.PropertyPlantEquipment);
            lblAccumulatedDepreciation.Text = Utilities.FormatCurrency(response.AccumulatedDepreciationAmortizationPPE);
            lblIntangibleAssets.Text = Utilities.FormatCurrency(response.IntangibleAssets);
            lblIntangibleAssetsExcluding.Text = Utilities.FormatCurrency(response.IntangibleAssetsExcludingGoodwill);
            lblGoodwill.Text = Utilities.FormatCurrency(response.Goodwill);
            lblInvestments.Text = Utilities.FormatCurrency(response.Investments);
            lblLongTermInvestments.Text = Utilities.FormatCurrency(response.LongTermInvestments);
            lblShortTermInvestments.Text = Utilities.FormatCurrency(response.ShortTermInvestments);
            lblOtherCurrentAssets.Text = Utilities.FormatCurrency(response.OtherCurrentAssets);
            lblOtherNonCurrentAssets.Text = Utilities.FormatCurrency(response.OtherNonCurrentAssets);
            lblTotalLiabilities.Text = Utilities.FormatCurrency(response.TotalLiabilities);
            lblTotalCurrentLiabilities.Text = Utilities.FormatCurrency(response.TotalCurrentLiabilities);
            lblCurrentAccountsPayable.Text = Utilities.FormatCurrency(response.CurrentAccountsPayable);
            lblDeferredRevenue.Text = Utilities.FormatCurrency(response.DeferredRevenue);
            lblCurrentDebt.Text = Utilities.FormatCurrency(response.CurrentDebt);
            lblShortTermDebt.Text = Utilities.FormatCurrency(response.ShortTermDebt);
            lblTotalNonCurrentLiab.Text = Utilities.FormatCurrency(response.TotalNonCurrentLiabilities);
            lblCapitalLeaseObligations.Text = Utilities.FormatCurrency(response.CapitalLeaseObligations);
            lblLongTermDebt.Text = Utilities.FormatCurrency(response.LongTermDebt);
            lblCurrentLongTermDebt.Text = Utilities.FormatCurrency(response.currentLongTermDebt);
            lblLongTermDebtNonCurrent.Text = Utilities.FormatCurrency(response.LongTermDebtNoncurrent);
            lblShortLongTermDebtTotal.Text = Utilities.FormatCurrency(response.ShortLongTermDebtTotal);
            lblOtherCurrentLiabilities.Text = Utilities.FormatCurrency(response.OtherCurrentLiabilities);
            lblOtherNonCurrentLiabilities.Text = Utilities.FormatCurrency(response.OtherNonCurrentLiabilities);
            lblTotalShareholderEquity.Text = Utilities.FormatCurrency(response.TotalShareholderEquity);
            lblTreasuryStock.Text = Utilities.FormatCurrency(response.TreasuryStock);
            lblRetainedEarnings.Text = Utilities.FormatCurrency(response.RetainedEarnings);
            lblCommonStock.Text = Utilities.FormatCurrency(response.CommonStock);
            lblCommonStockSharesOut.Text = response.CommonStockSharesOutstanding;
        }
        private void DisplayCashFlowInformation(AnnualReportCashFlow response)
        {
            lblFiscalEndingCF.Text = response.FiscalDateEnding;
            lblReportedCurrencyCF.Text = response.ReportedCurrency;
            lblOperatingCashflow.Text = Utilities.FormatCurrency(response.OperatingCashflow);
            lblPaymentsForOperatingActivities.Text = Utilities.FormatCurrency(response.PaymentsForOperatingActivities);
            lblProceedsFromOperatingActivities.Text = Utilities.FormatCurrency(response.ProceedsFromOperatingActivities);
            lblChangeInOperatingLiabilities.Text = Utilities.FormatCurrency(response.ChangeInOperatingLiabilities);
            lblChangeInOperatingAssets.Text = Utilities.FormatCurrency(response.ChangeInOperatingAssets);
            lblDepreciationDepletionAndAmortization.Text = Utilities.FormatCurrency(response.DepreciationDepletionAndAmortization);
            lblCapitalExpenditures.Text = Utilities.FormatCurrency(response.CapitalExpenditures);
            lblChangeInReceivables.Text = Utilities.FormatCurrency(response.ChangeInReceivables);
            lblChangeInInventory.Text = Utilities.FormatCurrency(response.ChangeInInventory);
            lblProfitLoss.Text = Utilities.FormatCurrency(response.ProfitLoss);
            lblCashflowFromInvestment.Text = Utilities.FormatCurrency(response.CashflowFromInvestment);
            lblCashflowFromFinancing.Text = Utilities.FormatCurrency(response.CashflowFromFinancing);
            lblProceedsFromRepaymentsOfShortTermDebt.Text = Utilities.FormatCurrency(response.ProceedsFromRepaymentsOfShortTermDebt);
            lblPaymentsForRepurchaseOfCommonStock.Text = Utilities.FormatCurrency(response.PaymentsForRepurchaseOfCommonStock);
            lblPaymentsForRepurchaseOfEquity.Text = Utilities.FormatCurrency(response.PaymentsForRepurchaseOfEquity);
            lblPaymentsForRepurchaseOfPreferredStock.Text = Utilities.FormatCurrency(response.PaymentsForRepurchaseOfPreferredStock);
            lblDividendPayout.Text = Utilities.FormatCurrency(response.DividendPayout);
            lblDividendPayoutCommonStock.Text = Utilities.FormatCurrency(response.DividendPayoutCommonStock);
            lblDividendPayoutPreferredStock.Text = Utilities.FormatCurrency(response.DividendPayoutPreferredStock);
            lblProceedsFromIssuanceOfCommonStock.Text = Utilities.FormatCurrency(response.ProceedsFromIssuanceOfCommonStock);
            lblProceedsFromIssuanceOfPreferredStock.Text = Utilities.FormatCurrency(response.ProceedsFromIssuanceOfPreferredStock);
            lblProceedsFromRepurchaseOfEquity.Text = Utilities.FormatCurrency(response.ProceedsFromRepurchaseOfEquity);
            lblProceedsFromSaleOfTreasuryStock.Text = Utilities.FormatCurrency(response.ProceedsFromSaleOfTreasuryStock);
            lblChangeInCashAndCashEquivalents.Text = Utilities.FormatCurrency(response.ChangeInCashAndCashEquivalents);
            lblChangeInExchangeRate.Text = Utilities.FormatCurrency(response.ChangeInExchangeRate);
            lblNetIncomeCashFlow.Text = Utilities.FormatCurrency(response.NetIncome);
            /*
            "lblProceedsFromIssuanceOfLongTermDebtAndCapitalSecuritiesNet": "522000000",
            */
        }

        private void RunStockAnalytics()
        {
            MachineLearning ml = new MachineLearning();            
            DiaplayStockAnalyticsResults(ml.RunStockAnalytics(symbol, int.Parse(ActiveUser.id.ToString())));
        }
       
        private void DiaplayStockAnalyticsResults(IEnumerable<ChartData> data)
        {
            var series1 = new Series("Actual Values");
            series1.BorderWidth = 5;
            series1.MarkerColor = Color.Blue;

            var series2 = new Series("Lower Values");
            series2.BorderWidth = 5;
            series2.MarkerColor = Color.Red;

            var series3 = new Series("Upper Values");
            series3.BorderWidth = 5;
            series3.MarkerColor = Color.Pink;

            var series4 = new Series("Forecasted Values");
            series4.BorderWidth = 5;
            series4.MarkerColor = Color.DarkGreen;

            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Series.Add(series4);

            IEnumerable<ChartData> filtered = data.OrderBy(x => x.Date);

            chart1.ChartAreas[0].AxisY.Maximum = Math.Round(filtered.Select(v => v.Upper).Max() + 10,0);
            chart1.ChartAreas[0].AxisY.Minimum = Math.Round(filtered.Select(v => v.Lower).Max() - 10,0);
            //chart1.f .ChartAreas[0].AxisY. = "C0";

            foreach (var prediction in filtered)
            {
                series1.Points.AddXY(prediction.Date.ToShortDateString(), Math.Round(prediction.Actual, 0)); 
                series2.Points.AddXY(prediction.Date.ToShortDateString(), Math.Round(prediction.Lower, 0));
                series3.Points.AddXY(prediction.Date.ToShortDateString(), Math.Round(prediction.Upper, 0));
                series4.Points.AddXY(prediction.Date.ToShortDateString(), Math.Round(prediction.Forecast, 0));
            }
                              
            series1.ChartType = SeriesChartType.Line;
            series2.ChartType= SeriesChartType.Line;
            series3.ChartType = SeriesChartType.Line;
            series4.ChartType = SeriesChartType.Line;            
        }
    }

    //public class ChartData
    //{
    //    public DateTime Date { get; set; }
    //    public float Actual { get; set; }
    //    public float Lower { get; set; }
    //    public float Forecast { get; set; }
    //    public float Upper { get; set; }
    //}

    //public class ModelInput
    //{
    //    public DateTime Date { get; set; }

    //    public float Year { get; set; }

    //    public float ClosingValue { get; set; }
    //}

    //public class ModelOutput
    //{
    //    public float[] ForecastedClosingValue { get; set; }

    //    public float[] LowerBoundClosingValue { get; set; }

    //    public float[] UpperBoundClosingValue { get; set; }
    //}
}
