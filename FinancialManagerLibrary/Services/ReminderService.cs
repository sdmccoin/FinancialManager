using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.UI.Controllers;
using FinancialManagerLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Services
{
    public class ReminderService
    {
        IController reminderController;
        IController expenseController;
        IController settingsController;

        IController incomeReminderController;
        IController expenseReminderController;
        IController investmentReminderController;

        public ReminderService()
        {
            incomeReminderController = ControllerFactory.GetController("IncomeReminder");
            expenseReminderController = ControllerFactory.GetController("ExpenseReminder");
            investmentReminderController = ControllerFactory.GetController("InvestmentReminder");

            reminderController = ControllerFactory.GetController("Reminder");
            settingsController = ControllerFactory.GetController("Settings");
        }
        public Reminder GetActiveIncomeReminder(int incomeId)
        {
            // call the link table to get the reminder id based on income id
            IncomeReminder incomeReminder = (IncomeReminder)incomeReminderController.GetById(incomeId);

            int reminderId = int.Parse(incomeReminder.ReminderId.ToString());
            Reminder reminder = (Reminder)reminderController.GetById(reminderId);

            // get the alert window
            long alertWindow = ((List<Setting>)settingsController.GetAll(ActiveUser.id)).FirstOrDefault().AlertWindowDays;

            // only load if they match our date window
            if (DateTime.Compare(DateTime.Parse(reminder.Date), DateTime.Now) <= 0 &&
                DateTime.Compare(DateTime.Parse(reminder.Date), DateTime.Now.AddDays(alertWindow)) <= 0)
            {
                return reminder;
            }
            else
            {
                return null;
            }
        }
        public Reminder GetActiveExpenseReminder(int expenseId)
        {
            // call the link table to get the reminder id based on income id
            ExpenseReminder expenseReminder = (ExpenseReminder)expenseReminderController.GetById(expenseId);

            int reminderId = int.Parse(expenseReminder.ReminderId.ToString());
            Reminder reminder = (Reminder)reminderController.GetById(reminderId);

            // get the alert window
            long alertWindow = ((List<Setting>)settingsController.GetAll(ActiveUser.id)).FirstOrDefault().AlertWindowDays;

            // only load if they match our date window
            if (DateTime.Compare(DateTime.Parse(reminder.Date), DateTime.Now) <= 0 &&
                DateTime.Compare(DateTime.Parse(reminder.Date), DateTime.Now.AddDays(alertWindow)) <= 0)
            {
                return reminder;
            }
            else
            {
                return null;
            }
        }
        public Reminder GetActiveInvestmentReminder(int investmentId)
        {
            // call the link table to get the reminder id based on income id
            InvestmentReminder investmentReminder = (InvestmentReminder)investmentReminderController.GetById(investmentId);

            if (investmentReminder == null)
                return null;
            
            int reminderId = int.Parse(investmentReminder.ReminderId.ToString());
            Reminder reminder = (Reminder)reminderController.GetById(reminderId);

            // get the alert window
            long alertWindow = ((List<Setting>)settingsController.GetAll(ActiveUser.id)).FirstOrDefault().AlertWindowDays;

            // only load if they match our date window
            if (DateTime.Compare(DateTime.Parse(reminder.Date), DateTime.Now) <= 0 &&
                DateTime.Compare(DateTime.Parse(reminder.Date), DateTime.Now.AddDays(alertWindow)) <= 0)
            {
                return reminder;
            }
            else
            {
                return null;
            }            
        }

        public List<Reminder> GetAllActiveReminders()
        {
            IController reminders = ControllerFactory.GetController("Reminder");
            List<Reminder> remindersList = (List<Reminder>)reminders.GetAll(ActiveUser.id);
            var orderedList = remindersList.OrderByDescending(x => DateTime.Parse(x.Date)).ToList();
            List<Reminder> filteredList = new List<Reminder>();

            // get the alert window
            long alertWindow = ((List<Setting>)settingsController.GetAll(ActiveUser.id)).FirstOrDefault().AlertWindowDays;

            foreach (Reminder reminder in orderedList)
            {
                // make sure the reminder date is earlier than the current date/time and within 1 day of
                // predefined limit (i.e., 1 day)
                if (DateTime.Compare(DateTime.Parse(reminder.Date), DateTime.Now) <= 0 &&
                   DateTime.Compare(DateTime.Parse(reminder.Date), DateTime.Now.AddDays(alertWindow)) <= 0)
                {
                    if (reminder.Enabled == 1)
                        filteredList.Add(reminder);
                }
            }

            return filteredList;
        }
    }
}
