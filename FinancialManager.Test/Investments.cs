using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Test
{
    using FinancialManager.Data.Repositories;
    using FinancialManager.Data.Models;
    using FinancialManager.Interfaces;
    using FinancialManager.UI.Controllers;
    using Microsoft.Data.Sqlite;
    using FinancialManager.Services;
    using FinancialManager.Services.Models;

    [TestClass]
    public class Investments
    {
        IController controller;
        StockService ss;
        public Investments()
        {
            controller = ControllerFactory.GetController("Investment");
            ss = new StockService();
        }

        [TestMethod]
        public void AddInvestment()
        {
            Investment investment = new Investment()
            {
                Source = "401k",
                Amount = "200"
            };

            Action act = () => { controller.Add(investment); };

            // null means insert was a success
            Assert.ThrowsException<SqliteException>(act);
        }

        [TestMethod]
        public void InvestmentSelect()
        {
            Investment investment = new Investment()
            {
                Source = "401k",
                Amount = "200",
                Id = 1
            };

            Assert.AreEqual(investment.Source, ((Investment)controller.Exists(investment)).Source);
        }

        [TestMethod]
        public void InvestmentNoSelectionFailure()
        {
            Investment investment = new Investment()
            {
                Source = "401k",
                Amount = "200"
            };

            Assert.AreNotEqual(investment.Source, ((Investment)controller.Exists(null)).Source);
        }

        [TestMethod]
        public void UpdateExpense()
        {
            Investment investment = new Investment()
            {
                Source = "401k",
                Amount = "200",
                Id = 1
            };

            Action act = () => { controller.Update(investment); };

            // null means insert was a success
            Assert.ThrowsException<SqliteException>(act);
        }

        [TestMethod]
        public void DeleteExpense()
        {
            Investment investment = new Investment()
            {
                Source = "401k",
                Amount = "200",
                Id = 1
            };

            Action act = () => { controller.Delete(investment); };

            // null means insert was a success
            Assert.ThrowsException<SqliteException>(act);
        }

        [TestMethod]
        public void SymbolSearch()
        {
            ss.URL =API.StockSearchURL + "IBM&apikey=" + API.StockKey;
            Assert.IsNotNull(ss.GetAsync<StockSearchResponse>());
        }

        [TestMethod]
        public void GetStockDailies()
        {
            ss.URL = API.StockSearchDailies + "IBM&apikey=" + API.StockKey;
            Assert.IsNotNull(ss.GetAsync<StockDailiesResponse>());
        }

        [TestMethod]
        public void GetStockOverview()
        {
            ss.URL = API.StockCompanyOverview + "IBM&apikey=" + API.StockKey;
            Assert.IsNotNull(ss.GetAsync<CompanyOverviewResponse>());
        }

        [TestMethod]
        public void GetStockIncomeStatement()
        {
            ss.URL = API.StockIncomeStatement + "IBM&apikey=" + API.StockKey;
            Assert.IsNotNull(ss.GetAsync<CompanyIncomeStatement>());
        }


         [TestMethod]
        public void InvalidSymbolSearch()
        {
            ss.URL =API.StockSearchURL + "IBMMM&apikey=" + API.StockKey;
            Assert.AreEqual(ss.GetAsync<StockSearchResponse>().bestMatches.Count,0);
        }

        [TestMethod]
        public void GetStockDailiesInvalidStock()
        {
            ss.URL = API.StockSearchDailies + "IBMMM&apikey=" + API.StockKey;
            Assert.IsNotNull(ss.GetAsync<StockDailiesResponse>());
        }

        [TestMethod]
        public void GetStockOverviewInvalidStock()
        {
            ss.URL = API.StockCompanyOverview + "IBMMM&apikey=" + API.StockKey;
            Assert.IsNull(ss.GetAsync<CompanyOverviewResponse>().Industry);
        }

        [TestMethod]
        public void GetStockIncomeStatementInvalidStock()
        {
            ss.URL = API.StockIncomeStatement + "IBMMM&apikey=" + API.StockKey;
            Assert.IsNull(ss.GetAsync<CompanyIncomeStatement>().AnnualReports);
        }

        [TestMethod]
        public void GetStockBalanceSheet()
        {
            ss.URL = API.StockIncomeStatement + "IBM&apikey=" + API.StockKey;
            Assert.IsNotNull(ss.GetAsync<CompanyBalanceSheet>());
        }
        [TestMethod]
        public void GetStockBalanceSheetInvalidStock()
        {
            ss.URL = API.StockIncomeStatement + "IBMMM&apikey=" + API.StockKey;
            Assert.IsNull(ss.GetAsync<CompanyBalanceSheet>().AnnualReportsBalanceSheet);
        }
        [TestMethod]
        public void GetStockCashFlow()
        {
            ss.URL = API.StockCashFlow + "IBM&apikey=" + API.StockKey;
            Assert.IsNotNull(ss.GetAsync<CompanyCashFlow>());
        }
        [TestMethod]
        public void GetStockCashFlowInvalidStock()
        {
            ss.URL = API.StockCashFlow + "IBMMMM&apikey=" + API.StockKey;
            Assert.IsNull(ss.GetAsync<CompanyCashFlow>().AnnualReportsCashFlow);
        }
    }
}
