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

    [TestClass]
    public class Expenses
    {
        IController controller;
        IController expenseReminderController;
        IController expenseNotificationController;

        public Expenses()
        {
            controller = ControllerFactory.GetController("Expense");
            expenseReminderController = ControllerFactory.GetController("ExpenseReminder");
            expenseNotificationController = ControllerFactory.GetController("ExpenseNotification");
        }

        [TestMethod]
        public void Test1AddExpense()
        {
            Expense expense = new Expense()
            {
                Source = "Car Payment",
                Amount = "420",
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
                Id = 1
            };

            controller.Delete(expense); 

            // null means insert was a success
            Assert.IsNull(expense);
        }

        [TestMethod]
        public void LoadUpCommingEventsAlertsSuccess()
        {
            List<Expense> expenses = (List<Expense>)controller.GetAll(1);
            List<ExpenseReminder> reminders = (List<ExpenseReminder>)expenseReminderController.GetAll(1);
            bool match = false;

            foreach (Expense expense in expenses)
            {
                foreach (ExpenseReminder reminder in reminders)
                {
                    if (reminder.ReminderId == expense.Id)
                    {
                        match = true;
                        break;
                    }
                }
            }

            Assert.IsTrue(match);
        }

        [TestMethod]
        public void LoadUpCommingEventsAlertsFailure()
        {
            List<Expense> expenses = (List<Expense>)controller.GetAll(0);
            List<ExpenseReminder> reminders = (List<ExpenseReminder>)expenseReminderController.GetAll(0);
            bool match = false;

            foreach (Expense expense in expenses)
            {
                foreach (ExpenseReminder reminder in reminders)
                {
                    if (reminder.ReminderId == expense.Id)
                    {
                        match = true;
                        break;
                    }
                }
            }

            Assert.IsFalse(match);
        }

        [TestMethod]
        public void LoadUpCommingEventsNotificationSuccess()
        {
            //List<Expense> expenses = (List<Expense>)controller.GetAll(1);
            //List<ExpenseNotification> notifications = (List<IncomeNotification>)incomeNotificationController.GetAll(1);
            //bool match = false;

            //foreach (Income income in incomes)
            //{
            //    foreach (IncomeNotification notification in notifications)
            //    {
            //        if (notification.IncomeId == income.Id)
            //        {
            //            match = true;
            //            break;
            //        }
            //    }
            //}

            //Assert.IsTrue(match);
        }

        [TestMethod]
        public void LoadUpCommingEventsNotificationFailure()
        {
            //List<Income> incomes = (List<Income>)controller.GetAll(0);
            //List<IncomeNotification> notifications = (List<IncomeNotification>)incomeNotificationController.GetAll(1);
            //bool match = false;

            //foreach (Income income in incomes)
            //{
            //    foreach (IncomeNotification notification in notifications)
            //    {
            //        if (notification.IncomeId == income.Id)
            //        {
            //            match = true;
            //            break;
            //        }
            //    }
            //}

            //Assert.IsFalse(match);
        }
    }
}
