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
    public class Incomes
    {
        IController controller;
        public Incomes()
        {
            controller = ControllerFactory.GetController("Income");
        }

        [TestMethod]
        public void AddIncome()
        {
            Income income = new Income()
            {
                Source = "Work",
                Amount = "2,000",
                Address = "5811 Rosebay Forest Road",
                Frequency = "Weekly",
                Id = 1
            };

            Action act = () => { controller.Add(income); };

            // null means insert was a success
            Assert.ThrowsException<SqliteException>(act);
        }

        [TestMethod]
        public void IncomeSelect()
        {
            Income income = new Income()
            {
                Source = "Work",
                Amount = "2,000",
                Address = "5811 Rosebay Forest Road",
                Frequency = "Weekly",
                Id = 1
            };

            Assert.AreEqual(income.Source, ((Income)controller.Exists(income)).Source);
        }

        [TestMethod]
        public void UpdateIncome()
        {
            Income income = new Income()
            {
                Source = "Work",
                Amount = "2,000",
                Address = "5811 Rosebay Forest Road",
                Frequency = "Weekly",
                Id = 1
            };

            Action act = () => { controller.Update(income); };

            // null means insert was a success
            Assert.ThrowsException<SqliteException>(act);
        }

        [TestMethod]
        public void DeleteIncome()
        {
            Income income = new Income()
            {
                Source = "Work",
                Amount = "2,000",
                Address = "5811 Rosebay Forest Road",
                Frequency = "Weekly",
                Id = 1
            };

            Action act = () => { controller.Delete(income); };

            // null means insert was a success
            Assert.ThrowsException<SqliteException>(act);
        }

        [TestMethod]
        public void GetAllIncomeByUserSuccess()
        {
            Assert.IsNotNull(controller.GetAll(1));
        }
        [TestMethod]
        public void GetAllIncomeByUserFailure()
        {
            Assert.IsNull(controller.GetAll(1000));
        }

        [TestMethod]
        public void InsertNewIncome()
        {
            Income income = new Income()
            {
                Source = "Work",
                Amount = "2,000",
                Address = "5811 Rosebay Forest Street",
                Frequency = "Weekly"
            };

            if ((Income?)controller.Exists(income) == null)
            {
                Action act = () => { controller.Add(income); };
                               
                // null means insert was a success
                Assert.IsNotNull(Assert.ThrowsException<SqliteException>(act));                
            }
        }

        [TestMethod]
        public void InsertNewIncomeFailure()
        {
            Income income = new Income()
            {
                Source = "Work",
                Amount = "2,000",
                Address = "5811 Rosebay Forest Street",
                Frequency = "Weekly"
            };

            if ((Income?)controller.Exists(income) != null)
            {
                Action act = () => { controller.Add(income); };

                // null means insert was a success
                Assert.ThrowsException<SqliteException>(act);
            }
        }
    }
}
