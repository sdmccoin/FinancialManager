using FinancialManager.Data.Models;
using FinancialManager.Interfaces;
using FinancialManager.UI.Controllers;
using FinancialManager.Utilities;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManager.Test
{
    [TestClass]
    public class Reminders
    {
        IController incomeReminderController;
        IController expenseReminderController;
        IController investmentReminderController;
        IController reminderController;
        Reminder reminder;
        Reminder newReminder;

        IncomeReminder ir;
        ExpenseReminder er;
        InvestmentReminder invR;

        public Reminders()
        {
            InitializeVariablesAndTestData();            
        }

        private void InitializeVariablesAndTestData()
        {
            reminderController = ControllerFactory.GetController("Reminder");
            incomeReminderController = ControllerFactory.GetController("IncomeReminder");

            reminder = new Reminder()
            {
                Date = "01/25/2023",
                Time = "10:30 PM",
                Message = "Add Income Unit Test Case",
                Frequency = "Daily",
                UserId = 0
            };

            ir = new IncomeReminder()
            {
                IncomeId = 0,
                ReminderId = 0
            };
            er = new ExpenseReminder()
            {
                ExpenseId = 0,
                ReminderId = 0
            };
            invR = new InvestmentReminder()
            {
                InvestmentId = 0,
                ReminderId = 0
            };
        }

        [TestMethod]
        public void Test1AddIncomeReminder()
        {
            var returned = (Reminder)reminderController.Add(reminder);

            ir.ReminderId = returned.Id;            

            var incomeReminderAdded = incomeReminderController.Add(ir);
                        
            Assert.IsNotNull(incomeReminderAdded);
        }

        [TestMethod]
        public void Test2UpdateIncomeReminder()
        {
            reminder.Date = "02/25/2023";

            reminderController.Update(reminder);
            reminder = (Reminder)reminderController.GetById(int.Parse(reminder.Id.ToString()));

            Assert.AreEqual(reminder.Date, "02/25/2023");
        }
        [TestMethod]
        public void Test3DeleteIncomeReminder()
        {
            incomeReminderController.Delete(ir);
            Assert.IsNull(incomeReminderController.GetById(int.Parse(ir.ReminderId.ToString())));
        }
        [TestMethod]
        public void Test4AddExpenseReminder()
        {
            var returned = (Reminder)reminderController.Add(reminder);
            er.ReminderId = returned.Id;
            var expenseReminderAdded = expenseReminderController.Add(ir);

            Assert.IsNotNull(expenseReminderAdded);
        }
        [TestMethod]
        public void Test5UpdateExpenseReminder()
        {
            reminder.Date = "02/25/2023";

            reminderController.Update(reminder);
            reminder = (Reminder)reminderController.GetById(int.Parse(reminder.Id.ToString()));

            Assert.AreEqual(reminder.Date, "02/25/2023");
        }
        [TestMethod]
        public void Test6DeleteIncomeReminder()
        {
            expenseReminderController.Delete(er);
            Assert.IsNull(expenseReminderController.GetById(int.Parse(er.ReminderId.ToString())));
        }
    }
}
