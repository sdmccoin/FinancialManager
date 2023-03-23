using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.UI.Controllers;
using FinancialManagerLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinancialManager.UI.Controls
{
    public partial class ucReminderForm : UserControl
    {
        IController reminderController;
        IController incomeReminderController;
        IController expenseReminderController;
        IController investmentReminderController;
        ReminderType reminderType;

        int typeId;

        public ucReminderForm(ReminderType rType, int typeId)
        {
            InitializeComponent();
            LoadForm();

            reminderType = rType;
            this.typeId = typeId;

            // user a factory pattern to get an income controller
            reminderController = ControllerFactory.GetController("Reminder");
            incomeReminderController = ControllerFactory.GetController("IncomeReminder");
            expenseReminderController = ControllerFactory.GetController("ExpenseReminder");
            investmentReminderController = ControllerFactory.GetController("InvestmentReminder");

        }

        private void LoadForm()
        {
            switch (reminderType)
            {
                case ReminderType.INCOME:
                    //Income income = (Income)incomeReminderController.GetById(typeId);
                    
                    break;
                case ReminderType.EXPENSE:
                    break;
                case ReminderType.INVESTMENT:
                    break;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (FormIsValid(ref errorMessage))
            {
                switch (reminderType)
                {
                    case ReminderType.INCOME:
                        CreateIncomeReminder();
                        break;
                    case ReminderType.EXPENSE:
                        CreateExpenseReminder();
                        break;
                    case ReminderType.INVESTMENT:
                        CreateInvestmentReminder();
                        break;
                    default:
                        break;
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private bool FormIsValid(ref string errorMessage)
        {
            bool isValid = false;

            if (Utilities.GetSelectedRadioButton(groupBox1) == null)
                errorMessage += " - You must select a report type\r\n";

            return isValid;
        }

        private void CreateIncomeReminder()
        {
            try
            {
                // Add the reminder
                Reminder reminder = new Reminder()
                {
                    Date = monthCalendar1.SelectionRange.Start.ToString(),
                    Time = dtpTime.Text,
                    Message = txtMessage.Text,
                    Frequency = Utilities.GetSelectedRadioButton(groupBox1).Text,
                    UserId = ActiveUser.id,
                    //Foreign Key needed to tie this reminder to an investment, income, or expense
                };

                // make sure the entry doesn't already exist
                if (reminderController.Exists(reminder) == null)
                {
                    var returned = (Reminder)reminderController.Add(reminder);

                    // add the entry to the link table
                    IncomeReminder incomeReminder = new IncomeReminder()
                    {
                        IncomeId = typeId,
                        ReminderId = returned.Id
                    };

                    incomeReminderController.Add(incomeReminder);

                    MessageBox.Show("Reminder Added", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Add Income", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateExpenseReminder()
        {
            try
            {
                // Add the reminder
                Reminder reminder = new Reminder()
                {
                    Date = monthCalendar1.SelectionRange.Start.ToString(),
                    Time = dtpTime.Text,
                    Message = txtMessage.Text,
                    Frequency = Utilities.GetSelectedRadioButton(groupBox1).Text,
                    UserId = ActiveUser.id,
                    //Foreign Key needed to tie this reminder to an investment, income, or expense
                };

                // make sure the entry doesn't already exist
                if (reminderController.Exists(reminder) == null)
                {
                    var returned = (Reminder)reminderController.Add(reminder);

                    // add the entry to the link table
                    ExpenseReminder expenseReminder = new ExpenseReminder()
                    {
                        ExpenseId = typeId,
                        ReminderId = returned.Id
                    };

                    expenseReminderController.Add(expenseReminder);

                    MessageBox.Show("Reminder Added", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Add Income", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CreateInvestmentReminder()
        {
            try
            {
                // Add the reminder
                Reminder reminder = new Reminder()
                {
                    Date = monthCalendar1.SelectionRange.Start.ToString(),
                    Time = dtpTime.Text,
                    Message = txtMessage.Text,
                    Frequency = Utilities.GetSelectedRadioButton(groupBox1).Text,
                    UserId = ActiveUser.id,
                    //Foreign Key needed to tie this reminder to an investment, income, or expense
                };

                // make sure the entry doesn't already exist
                if (reminderController.Exists(reminder) == null)
                {
                    var returned = (Reminder)reminderController.Add(reminder);

                    // add the entry to the link table
                    InvestmentReminder investmentReminder = new InvestmentReminder()
                    {
                        InvestmentId = typeId,
                        ReminderId = returned.Id
                    };

                    investmentReminderController.Add(investmentReminder);

                    MessageBox.Show("Reminder Added", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Add Income", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
