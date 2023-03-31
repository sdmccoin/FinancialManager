using FinancialManagerLibrary.Data.Repositories;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.UI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Test
{
    [TestClass]
    public class Reporting
    {
        IncomeRepository incomeRepository;

        public Reporting() 
        {
            incomeRepository = new IncomeRepository();
        }
        [TestMethod]
        public void Test1GetMonthlyTotalIncome()
        {
            Assert.IsNotNull(incomeRepository.TotalIncome(1, "Monthly"));
        }
        [TestMethod]
        public void Test2GetYearlyTotalIncome()
        {
            Assert.IsNotNull(incomeRepository.TotalIncome(1, "Yearly"));
        }
        [TestMethod]
        public void Test3GetMonthlyTotalExpenses()
        {
            Assert.IsNotNull(incomeRepository.TotalExpenses(1, "Monthly"));
        }
        [TestMethod]
        public void Test4GetYearlyTotalExpenses()
        {
            Assert.IsNotNull(incomeRepository.TotalExpenses(1, "Yearly"));
        }
        [TestMethod]
        public void Test5GenerateMonthlyIncomeReport()
        {
            IReport incomeReport = ReportFactory.GetReport("Income");
            incomeReport.StartDate = "";
            incomeReport.EndDate = "";
            incomeReport.ReportType = "Monthly";
            incomeReport.Generate();
            Assert.IsNotNull(incomeReport.ToString());
        }
        [TestMethod]
        public void Test6GenerateYearlyIncomeReport()
        {
            IReport incomeReport = ReportFactory.GetReport("Income");
            incomeReport.StartDate = "";
            incomeReport.EndDate = "";
            incomeReport.ReportType = "Yearly";
            incomeReport.Generate();
            Assert.IsNotNull(incomeReport.ToString());
        }
        [TestMethod]
        public void Test7GenerateMonthlyExpenseReport()
        {
            IReport incomeReport = ReportFactory.GetReport("Expense");
            incomeReport.StartDate = "";
            incomeReport.EndDate = "";
            incomeReport.ReportType = "Monthly";
            incomeReport.Generate();
            Assert.IsNotNull(incomeReport.ToString());
        }
        [TestMethod]
        public void Test8GenerateYearlyExpenseReport()
        {
            IReport incomeReport = ReportFactory.GetReport("Expense");
            incomeReport.StartDate = "";
            incomeReport.EndDate = "";
            incomeReport.ReportType = "Yearly";
            incomeReport.Generate();
            Assert.IsNotNull(incomeReport.ToString());
        }
        [TestMethod]
        public void Test9GenerateMonthlyInvestmentReport()
        {
            //IReport incomeReport = ReportFactory.GetReport("Expense");
            //incomeReport.StartDate = "";
            //incomeReport.EndDate = "";
            //incomeReport.ReportType = "Yearly";
            //incomeReport.Generate();
            //Assert.IsNotNull(incomeReport.ToString());
        }
        [TestMethod]
        public void Test10FilterExpenseReportByDate()
        {
            IReport expenseReport = ReportFactory.GetReport("Expense");
            expenseReport.StartDate = "01/01/2023";
            expenseReport.EndDate = "12/01/2023";
            expenseReport.Generate();
            Assert.IsNotNull(expenseReport.ToString());
        }
        [TestMethod]
        public void Test11FilterExpenseReportByDateFail()
        {
            IReport expenseReport = ReportFactory.GetReport("Expense");
            expenseReport.StartDate = "01/01/2024";
            expenseReport.EndDate = "12/01/2024";
            expenseReport.Generate();
            Assert.IsNull(expenseReport.ToString());
        }
        [TestMethod]
        public void Test12FilterIncomeReportByDate()
        {
            IReport incomeReport = ReportFactory.GetReport("Income");
            incomeReport.StartDate = "01/01/2023";
            incomeReport.EndDate = "12/01/2023";
            incomeReport.Generate();
            Assert.IsNotNull(incomeReport.ToString());
        }
        [TestMethod]
        public void Test13FilterIncomeReportByDateFail()
        {
            IReport incomeReport = ReportFactory.GetReport("Income");
            incomeReport.StartDate = "01/01/2024";
            incomeReport.EndDate = "12/01/2024";
            incomeReport.Generate();
            Assert.IsNull(incomeReport.ToString());
        }
        [TestMethod]
        public void Test14FilterInvestmentReportByDate()
        {
            IReport investmentReport = ReportFactory.GetReport("Investment");
            investmentReport.StartDate = "01/01/2023";
            investmentReport.EndDate = "12/01/2023";
            investmentReport.Generate();
            Assert.IsNotNull(investmentReport.ToString());
        }
        [TestMethod]
        public void Test15FilterInvestmentReportByDateFail()
        {
            IReport investmentReport = ReportFactory.GetReport("Investment");
            investmentReport.StartDate = "01/01/2024";
            investmentReport.EndDate = "12/01/2024";
            investmentReport.Generate();
            Assert.IsNull(investmentReport.ToString());
        }
    }
}
