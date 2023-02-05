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

    [TestClass]
    public class Investments
    {
        IController controller;
        public Investments()
        {
            controller = ControllerFactory.GetController("Investment");
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
    }
}
