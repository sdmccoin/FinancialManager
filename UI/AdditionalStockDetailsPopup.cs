using FinancialManager.Services.Models;
using FinancialManager.Services;
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

namespace FinancialManager.UI
{
    public partial class AdditionalStockDetailsPopup : Form
    {
        private string stockName;
        private string symbol;

        public AdditionalStockDetailsPopup(string stockName, string symbol)
        {
            InitializeComponent();
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
            //LoadBalanceSheetInformation();
           
        }

        private void LoadOverviewInformation()
        {
            string overviewSearchUrl = API.StockCompanyOverview + symbol + "&apikey=" + API.StockKey;
            CompanyOverviewResponse response = new CompanyOverviewResponse();

            using (WebClient client = new WebClient())
            {
                Task taskA = Task.Run(() => response = JsonSerializer.Deserialize<CompanyOverviewResponse>(client.DownloadString(overviewSearchUrl)));
                taskA.Wait();
                if (response != null)
                {
                    DisplayOverViewInformation(response);
                }
            }
        }
        private void LoadIncomeStatementInformation()
        {
            string overviewSearchUrl = API.StockIncomeStatement + symbol + "&apikey=" + API.StockKey;
            CompanyIncomeStatement response = new CompanyIncomeStatement();

            using (WebClient client = new WebClient())
            {
                Task taskA = Task.Run(() => response = JsonSerializer.Deserialize<CompanyIncomeStatement>(client.DownloadString(overviewSearchUrl)));
                taskA.Wait();
                if (response != null)
                {
                    if (response.AnnualReports.Count > 0)
                    {
                        DisplayIncomeStatementInformation(response.AnnualReports[0]);
                    }                    
                }
            }
        }
        private void LoadBalanceSheetInformation()
        {
            string balanceSheetUrl = API.StockBalanceSheet + symbol + "&apikey=" + API.StockKey;
            CompanyBalanceSheet response = new CompanyBalanceSheet();

            using (WebClient client = new WebClient())
            {
                Task taskA = Task.Run(() => response = JsonSerializer.Deserialize<CompanyBalanceSheet>(client.DownloadString(balanceSheetUrl)));
                taskA.Wait();
                if (response != null)
                {
                    if (response.AnnualReportsBalanceSheet.Count > 0)
                    {
                        DisplayBalanceSheetInformation(response.AnnualReportsBalanceSheet[0]);
                    }
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

        }
    }
}
