using FinancialManager.Data.Repositories;
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
        public void GetMonthlyTotalIncome()
        {
            Assert.IsNotNull(incomeRepository.TotalIncome(1, "Monthly"));
        }
        [TestMethod]
        public void GetYearlyTotalIncome()
        {
            Assert.IsNotNull(incomeRepository.TotalIncome(1, "Yearly"));
        }
        [TestMethod]
        public void GetMonthlyTotalExpenses()
        {
            Assert.IsNotNull(incomeRepository.TotalExpenses(1, "Monthly"));
        }
        [TestMethod]
        public void GetYearlyTotalExpenses()
        {
            Assert.IsNotNull(incomeRepository.TotalExpenses(1, "Yearly"));
        }
    }
}
