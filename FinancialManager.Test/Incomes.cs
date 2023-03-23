using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Test
{
    using FinancialManagerLibrary.Data.Repositories;
    using FinancialManagerLibrary.Data.Models;
    using FinancialManagerLibrary.Interfaces;
    using FinancialManagerLibrary.UI.Controllers;
    using Microsoft.Data.Sqlite;
    using FinancialManagerLibrary.Data.Interfaces;

    [TestClass]
    public class Incomes
    {
        IController controller;
        public Incomes()
        {
            controller = ControllerFactory.GetController("Income");
        }

        [TestMethod]
        public void Test1AddIncome()
        {
            Income income = new Income()
            {
                Source = "Work",
                Amount = "2,000",
                Id = 1
            };

            Income returned = (Income)controller.Add(income);

            // null means insert was a success            
            Assert.AreEqual(income, returned);
        }

        [TestMethod]
        public void Test2IncomeSelect()
        {
            Income income = new Income()
            {
                Source = "Work",
                Amount = "2,000",
                Id = 1
            };

            Assert.AreEqual(income.Source, ((Income)controller.Exists(income)).Source);
        }

        [TestMethod]
        public void Test3UpdateIncome()
        {
            Income income = new Income()
            {
                Source = "Work",
                Amount = "2,000",
                Id = 1
            };

            controller.Update(income);
            Income exists = (Income)controller.Exists(income);

            // null means insert was a success
            Assert.AreEqual(income.Source, exists.Source);
        }

        [TestMethod]
        public void Test4DeleteIncome()
        {
            Income income = new Income()
            {
                Source = "Work",
                Amount = "2,000",
                Id = 1
            };

            controller.Delete(income);

            // null means insert was a success
            Assert.IsNull(income);
        }

        [TestMethod]
        public void Test5GetAllIncomeByUserSuccess()
        {
            Assert.IsNotNull(controller.GetAll(1));
        }
        [TestMethod]
        public void Test6GetAllIncomeByUserFailure()
        {
            Assert.AreNotEqual(controller.GetAll(1000).ToList().Count,1);
        }

        [TestMethod]
        public void Test7InsertNewIncome()
        {
            Income income = new Income()
            {
                Source = "Work",
                Amount = "2,000",
            };

            if ((Income?)controller.Exists(income) == null)
            {
                Action act = () => { controller.Add(income); };
                               
                // null means insert was a success
                Assert.IsNotNull(Assert.ThrowsException<SqliteException>(act));                
            }
        }

        [TestMethod]
        public void Test8InsertNewIncomeFailure()
        {
            Income income = new Income()
            {
                Source = "Work",
                Amount = "2,000",
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
