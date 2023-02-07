using FinancialManager.Data.Models;
using FinancialManager.Interfaces;
using FinancialManager.UI.Controllers;
using FinancialManager.Utilities;
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
        IController inceomReminderController;
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
            inceomReminderController = ControllerFactory.GetController("IncomeReminder");
            expenseReminderController = ControllerFactory.GetController("ExpenseReminder");
            investmentReminderController = ControllerFactory.GetController("InvestmentReminder");

        }

        private void LoadForm()
        {
            // to do
        }

        private void btnInsert_Click(object sender, EventArgs e)
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

                    inceomReminderController.Add(incomeReminder);

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
