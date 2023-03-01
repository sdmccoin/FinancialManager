﻿using System;
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
        public void Test1AddExpense()
        {
            Expense expense = new Expense()
            {
                Source = "Car Payment",
                Amount = "420",
                Address = "1234 address",
                Frequency = "Monthly"
            };

            Expense returned = (Expense)controller.Add(expense); 

            // null means insert was a success            
            Assert.AreEqual(expense, returned);
        }

        [TestMethod]
        public void Test2ExpenseSelect()
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
        public void Test3UpdateExpense()
        {
            Expense expense = new Expense()
            {
                Source = "Car Payment",
                Amount = "420",
                Address = "1234 address",
                Frequency = "Monthly",
                Id = 1
            };

            controller.Update(expense);
            Expense exists = (Expense)controller.Exists(expense);

            // null means insert was a success
            Assert.AreEqual(expense.Source, exists.Source);
        }

        [TestMethod]
        public void Test4DeleteExpense()
        {
            Expense expense = new Expense()
            {
                Source = "Car Payment",
                Amount = "420",
                Address = "1234 address",
                Frequency = "Monthly",
                Id = 1
            };

            controller.Delete(expense); 

            // null means insert was a success
            Assert.IsNull(expense);
        }
    }
}
