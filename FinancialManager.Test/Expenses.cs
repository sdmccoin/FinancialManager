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
    public class Expenses
    {
        IController controller;
        public Expenses()
        {
            controller = ControllerFactory.GetController("Expense");
        }

        [TestMethod]
        public void AddExpense()
        {
            Expense expense = new Expense()
            {
                Source = "Car Payment",
                Amount = "420",
                Address = "1234 address",
                Frequency = "Monthly"
            };

            Action act = () => { controller.Add(expense); };

            // null means insert was a success
            Assert.ThrowsException<SqliteException>(act);
        }

        [TestMethod]
        public void ExpenseSelect()
        {
            Expense expense = new Expense()
            {
                Source = "Car Payment",
                Amount = "420",
                Address = "1234 address",
                Frequency = "Monthly",
                Id = 1
            };

            Assert.AreEqual(expense.Source, ((Expense)controller.Exists(expense)).Source);            
        }

        [TestMethod]
        public void UpdateExpense()
        {
            Expense expense = new Expense()
            {
                Source = "Car Payment",
                Amount = "420",
                Address = "1234 address",
                Frequency = "Monthly",
                Id = 1
            };

            Action act = () => { controller.Update(expense); };

            // null means insert was a success
            Assert.ThrowsException<SqliteException>(act);
        }

        [TestMethod]
        public void DeleteExpense()
        {
            Expense expense = new Expense()
            {
                Source = "Car Payment",
                Amount = "420",
                Address = "1234 address",
                Frequency = "Monthly",
                Id = 1
            };

            Action act = () => { controller.Delete(expense); };

            // null means insert was a success
            Assert.ThrowsException<SqliteException>(act);
        }
    }
}
