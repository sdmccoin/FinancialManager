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
    using FinancialManagerLibrary.Services.Models;
    using FinancialManagerLibrary.Services;
    using FinancialManagerLibrary.Utilities;
    using System.Drawing;

    [TestClass]
    public class Incomes
    {
        IController controller;
        IController incomeReminderController;
        IController incomeNotificationController;

        public Incomes()
        {
            controller = ControllerFactory.GetController("Income");
            incomeReminderController = ControllerFactory.GetController("IncomeReminder");
            incomeNotificationController = ControllerFactory.GetController("IncomeNotification");
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

        [TestMethod]
        public void LoadUpCommingEventsAlertsSuccess()
        {
            List<Income> incomes = (List<Income>)controller.GetAll(1);
            List<IncomeReminder> reminders = (List<IncomeReminder>)incomeReminderController.GetAll(1);
            bool match = false;

            foreach (Income income in incomes)
            {               
                foreach (IncomeReminder reminder in reminders)
                {
                    if (reminder.IncomeId == income.Id)
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
            List<Income> incomes = (List<Income>)controller.GetAll(0);
            List<IncomeReminder> reminders = (List<IncomeReminder>)incomeReminderController.GetAll(0);
            bool match = false;

            foreach (Income income in incomes)
            {
                foreach (IncomeReminder reminder in reminders)
                {
                    if (reminder.IncomeId == income.Id)
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
            List<Income> incomes = (List<Income>)controller.GetAll(1);
            List<IncomeNotification> notifications = (List<IncomeNotification>)incomeNotificationController.GetAll(1);
            bool match = false;

            foreach (Income income in incomes)
            {
                foreach (IncomeNotification notification in notifications)
                {
                    if (notification.IncomeId == income.Id)
                    {
                        match = true;
                        break;
                    }
                }
            }

            Assert.IsTrue(match);
        }

        [TestMethod]
        public void LoadUpCommingEventsNotificationFailure()
        {
            List<Income> incomes = (List<Income>)controller.GetAll(0);
            List<IncomeNotification> notifications = (List<IncomeNotification>)incomeNotificationController.GetAll(1);
            bool match = false;

            foreach (Income income in incomes)
            {
                foreach (IncomeNotification notification in notifications)
                {
                    if (notification.IncomeId == income.Id)
                    {
                        match = true;
                        break;
                    }
                }
            }

            Assert.IsFalse(match);
        }
    }
}
