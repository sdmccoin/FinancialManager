using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.UI.Controllers;
using FinancialManagerLibrary.Utilities;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialManagerLibrary.Services;

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
        [TestMethod]
        public void Test7CreateUIIncomeAlert()
        {

        }
        [TestMethod]
        public void Test8CreateUIExpenseAlert()
        {

        }
        [TestMethod]
        public void Test9CreateUIInvestmentAlert()
        {

        }
        [TestMethod]
        public void GetActiveIncomeAlert()
        {
            ReminderService reminderService = new ReminderService();
            Assert.IsNotNull(reminderService.GetActiveIncomeReminder(25));
        }
        [TestMethod]
        public void NoActiveIncomeAlert()
        {
            ReminderService reminderService = new ReminderService();
            Assert.IsNotNull(reminderService.GetActiveIncomeReminder(2500));
        }
        [TestMethod]
        public void GetActiveExpenseAlert()
        {
            ReminderService reminderService = new ReminderService();
            Assert.IsNotNull(reminderService.GetActiveExpenseReminder(25));
        }
        [TestMethod]
        public void NoActiveExpenseAlert()
        {
            ReminderService reminderService = new ReminderService();
            Assert.IsNotNull(reminderService.GetActiveExpenseReminder(2500));
        }
        [TestMethod]
        public void GetActiveInvestmentAlert()
        {
            ReminderService reminderService = new ReminderService();
            Assert.IsNotNull(reminderService.GetActiveInvestmentReminder(25));
        }
        [TestMethod]
        public void NoActiveInvestmentAlert()
        {
            ReminderService reminderService = new ReminderService();
            Assert.IsNotNull(reminderService.GetActiveInvestmentReminder(2500));
        }
        [TestMethod]
        public void GetAllActiveAlerts()
        {
            ReminderService reminderService = new ReminderService();
            Assert.IsNotNull(reminderService.GetAllActiveReminders());
        }
    }
}
