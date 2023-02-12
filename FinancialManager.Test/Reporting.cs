using FinancialManager.Data.Repositories;
using FinancialManager.Interfaces;
using FinancialManager.UI.Controllers;
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
    }
}
