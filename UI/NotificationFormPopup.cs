using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialManager.Data.Models;
using FinancialManager.Interfaces;
using FinancialManager.UI.Controllers;
using FinancialManager.UI.Controls;
using FinancialManager.Utilities;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace FinancialManager.UI
{
    public partial class NotificationFormPopup : Form
    {
        IController reminderController;
        IController incomeReminderController;
        IController expenseReminderController;
        IController investmentReminderController;
        IController incomeController;
        IController expenseController;
        IController investmentController;

        ReminderType reminderType;

        int typeId;
        int reminderId;

        IncomeReminder incomeReminder;
        ExpenseReminder expenseReminder;
        InvestmentReminder investmentReminder;

        public NotificationFormPopup()
        {
            InitializeComponent();
        }
        public NotificationFormPopup(ReminderType rType, int typeId)
        {
            InitializeComponent();

            reminderType = rType;
            this.typeId = typeId;

            // user a factory pattern to get an income controller
            reminderController = ControllerFactory.GetController("Reminder");
            incomeReminderController = ControllerFactory.GetController("IncomeReminder");
            expenseReminderController = ControllerFactory.GetController("ExpenseReminder");
            investmentReminderController = ControllerFactory.GetController("InvestmentReminder");
            incomeController = ControllerFactory.GetController("Income");
            expenseController = ControllerFactory.GetController("Expense");
            investmentController = ControllerFactory.GetController("Investment");
        }

        private void NotificationFormPopup_Load(object sender, EventArgs e)
        {            
            switch (reminderType)
            {
                case ReminderType.INCOME:
                    LoadIncome();
                    break;
                case ReminderType.EXPENSE:
                    LoadExpenses();
                    break;
                case ReminderType.INVESTMENT:
                    LoadInvestments();
                    break;
            }
        }

        private void LoadIncome()
        {
            Income income = (Income)incomeController.GetById(typeId);
            lblName.Text = income.Source;
            lblAddress.Text = income.Address;
            lblFrequency.Text = income.Frequency;
            lblAmount.Text = income.Amount;

            // get income reminder to get reminder id
            incomeReminder = (IncomeReminder)incomeReminderController
                .GetById(typeId);

            if (incomeReminder != null )
            {
                reminderId = int.Parse(incomeReminder.ReminderId.ToString());

                Reminder reminder = (Reminder)reminderController.GetById(reminderId);
                Utilities.SelectRadioButton(groupBox1, reminder.Frequency);
                txtMessage.Text = reminder.Message;

                if (reminderId > 0)
                {
                    reminderId = int.Parse(((IncomeReminder)incomeReminderController
                        .GetById(typeId)).ReminderId.ToString());
                }
            }            
        }
        private void LoadExpenses()
        {
            Expense expense = (Expense)expenseController.GetById(typeId);
            lblName.Text = expense.Source;
            lblAddress.Text = expense.Address;
            lblFrequency.Text = expense.Frequency;
            lblAmount.Text = expense.Amount;

            expenseReminder = (ExpenseReminder)expenseReminderController
                .GetById(typeId);

            if (expenseReminder != null )
            {
                reminderId = int.Parse(expenseReminder.ReminderId.ToString());

                Reminder reminder = (Reminder)reminderController.GetById(reminderId);
                Utilities.SelectRadioButton(groupBox1, reminder.Frequency);
                txtMessage.Text = reminder.Message;

                if (reminderId > 0)
                {
                    reminderId = int.Parse(((ExpenseReminder)expenseReminderController
                        .GetById(typeId)).ReminderId.ToString());
                }
            }            
        }
        private void LoadInvestments()
        {
            Investment investment = (Investment)investmentController.GetById(typeId);
            lblName.Text = investment.Source;
            lblFrequency.Text = investment.Frequency;
            lblAmount.Text = investment.Amount;

            investmentReminder = (InvestmentReminder)investmentReminderController
                .GetById(typeId);

            if (investmentReminder != null)
            {
                reminderId = int.Parse(investmentReminder.ReminderId.ToString());

                Reminder reminder = (Reminder)reminderController.GetById(reminderId);
                Utilities.SelectRadioButton(groupBox1, reminder.Frequency);
                txtMessage.Text = reminder.Message;

                if (reminderId > 0)
                {
                    reminderId = int.Parse(((InvestmentReminder)investmentReminderController
                        .GetById(typeId)).ReminderId.ToString());
                }
            }
        }

        private void cbxReminder_CheckedChanged(object sender, EventArgs e)
        {
            //pnlMain.Controls.Clear();
            //if (cbxReminder.Checked)
            //{
            //    cbxNotification.Checked = false;
            //    pnlMain.Controls.Add(new ucReminderForm(incomeId));
            //    this.Height = 1315;
            //}
            //else
            //{
            //    pnlMain.Controls.Clear();
            //    this.Height = 465;
            //}
        }

        private void cbxNotification_CheckedChanged(object sender, EventArgs e)
        {
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
            else
            {
                MessageBox.Show(errorMessage, "Unable to Add Reminder",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (FormIsValid(ref errorMessage))            
                UpdateReminder();   
            else
            {
                MessageBox.Show(errorMessage, "Unable to Update Reminder",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (FormIsValid(ref errorMessage))            
                DeleteReminder();  
            else
            {
                MessageBox.Show(errorMessage, "Unable to Update Reminder",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private bool FormIsValid(ref string errorMessage)
        {
            bool isValid = false;

            if (Utilities.GetSelectedRadioButton(groupBox1) == null)
                errorMessage += " - You must select a report type\r\n";

            if (errorMessage == "")
                isValid = true;

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
                    UserId = ActiveUser.id                    
                };

                // make sure the entry doesn't already exist
                //if (reminderController.Exists(reminder) == null)
                if (incomeReminder == null)
                {
                    var returned = (Reminder)reminderController.Add(reminder);

                    //// add the entry to the link table
                    IncomeReminder ir = new IncomeReminder()
                    {
                        IncomeId = typeId, 
                        ReminderId = returned.Id
                    };

                    incomeReminderController.Add(ir);

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
        private void UpdateReminder()
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
                    Id = reminderId
                };

                // make sure the entry doesn't already exist
                if (reminderController.GetById(reminderId) != null)
                {                    
                    reminderController.Update(reminder);
                    MessageBox.Show("Reminder Updated", "Success");
                }
                else
                    MessageBox.Show("Unable to Find Reminder", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Update Income Reminder", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void DeleteReminder()
        {
            try
            {
                // make sure the entry doesn't already exist
                if (reminderController.GetById(reminderId) != null)
                {
                    switch (reminderType)
                    {
                        case ReminderType.INCOME:
                            incomeReminderController.Delete(new IncomeReminder()
                            {
                                ReminderId = reminderId,
                                IncomeId = typeId
                            });
                            break;
                        case ReminderType.EXPENSE:
                            expenseReminderController.Delete(new ExpenseReminder()
                            {
                                ReminderId = reminderId,
                                ExpenseId = typeId
                            });
                            break;
                        case ReminderType.INVESTMENT:
                            investmentReminderController.Delete(new InvestmentReminder()
                            {
                                ReminderId = reminderId,
                                InvestmentId = typeId
                            });
                            break;
                    }

                    MessageBox.Show("Reminder Deleted", "Success");
                }
                else
                    MessageBox.Show("Unable to Find Reminder", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Delete Income Reminder", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}