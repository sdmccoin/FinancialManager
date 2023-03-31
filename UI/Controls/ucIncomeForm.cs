using FinancialManagerLibrary.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialManagerLibrary.Data.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using FinancialManagerLibrary.Utilities;
using FinancialManagerLibrary.UI.Controllers;
using FinancialManager.UI;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing.Imaging;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using FinancialManagerLibrary.Services;

namespace FinancialManager.UI.Controls
{
    public partial class ucIncomeForm : UserControl
    {
        IController incomeController;
        IController incomeReminderController;
        IController incomeNotificationController;
        IController reminderController;
        IController settingsController;
        
        DataTable incomeTable;
        DataTable eventsTable;

        public ucIncomeForm()
        {
            InitializeComponent();
            InitializeIncomeTable();
            InitializeEventsTable();

            // user a factory pattern to get an income controller
            incomeController = ControllerFactory.GetController("Income");
            reminderController = ControllerFactory.GetController("Reminder");
            settingsController = ControllerFactory.GetController("Settings");

        }

        private void InitializeIncomeTable()
        {
            incomeTable = new DataTable();
            incomeTable.Columns.Add("Id", typeof(int));
            incomeTable.Columns.Add("Name", typeof(string));
            incomeTable.Columns.Add("Amount", typeof(string));
            incomeTable.Columns.Add("Reminder", typeof(Image));
            incomeTable.Columns.Add("Notification", typeof(Image));
            incomeTable.Columns.Add("Date", typeof(string));
        }
        private void InitializeEventsTable()
        {
            eventsTable = new DataTable();
            eventsTable.Columns.Add("Id", typeof(int));
            eventsTable.Columns.Add("Reminder", typeof(Image));
            eventsTable.Columns.Add("Notification", typeof(Image));
            eventsTable.Columns.Add("Date", typeof(string));
        }


        private void ucIncomeForm_Load(object sender, EventArgs e)
        {
            LoadIncomeAndEventsGrid();

            // delegate to clear the form after .1 seconds 
            Action clear = () => ClearForm();
            DelayMilliseconds(100, clear);    
        }
          
      
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (FormIsValid(ref errorMessage))
            {
                try
                {
                    Income income = new Income()
                    {
                        Source = txtName.Text,
                        Amount = txtAmount.Text,
                        UserId = ActiveUser.id,
                        Date = dtpStart.Text
                    };

                    // make sure the entry doesn't already exist
                    if (incomeController.Exists(income) == null)
                    {
                        incomeController.Add(income);
                        LoadIncomeAndEventsGrid();

                        MessageBox.Show("Income Added", "Success");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to Add Income", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void LoadIncomeAndEventsGrid()
        {
            // initialize controllers
            incomeReminderController = ControllerFactory.GetController("IncomeReminder");
            incomeNotificationController = ControllerFactory.GetController("IncomeNotification");

            // get all the users income and associated reminders and notifications
            List<Income> incomes = (List<Income>)incomeController.GetAll(ActiveUser.id);
            List<IncomeReminder> reminders = (List<IncomeReminder>)incomeReminderController.GetAll(ActiveUser.id);
            List<IncomeNotification> notifications = (List<IncomeNotification>)incomeNotificationController.GetAll(ActiveUser.id);

            ReminderService reminderService = new ReminderService();

            // clear prior to reloading
            incomeTable.Clear();
            dgvIncome.DataSource = incomeTable;
            dgvIncome.Refresh();

            eventsTable.Clear();
            dgvIncomeEvents.DataSource = eventsTable;
            dgvIncomeEvents.Refresh();

            Bitmap reminderImage;
            Bitmap notificationImage;
            foreach (Income income in incomes)
            {
                reminderImage = null;
                notificationImage = null;

                // load reminders
                foreach (IncomeReminder reminder in reminders)
                {
                    // determine whether to show reminder image
                    if (reminder.IncomeId == income.Id)
                    {
                        reminderImage = new Bitmap(SystemIcons.Exclamation.ToBitmap(), 25, 25);
                        break;
                    }
                }

                // load notifications
                foreach (IncomeNotification notification in notifications)
                {
                    if (notification.IncomeId == income.Id)
                    {
                        notificationImage = new Bitmap(SystemIcons.Information.ToBitmap(), 25, 25);
                        break;
                    }
                }

                // set a "blank" image if there is no notification or reminder
                if (reminderImage == null)
                    reminderImage = new Bitmap(SystemIcons.Exclamation.ToBitmap(), 1, 1);
                if (notificationImage == null)
                    notificationImage = new Bitmap(SystemIcons.Information.ToBitmap(), 1, 1);

                // load income
                incomeTable.Rows.Add(income.Id, income.Source, income.Amount,
                        reminderImage, notificationImage, income.Date);

                dgvIncome.AutoSize = true;
                dgvIncome.DataSource = incomeTable;
                this.dgvIncome.Columns["Id"].Visible = false;
                dgvIncome.Columns[1].Width = 540;
                dgvIncome.Columns[2].Width = 200;
                dgvIncome.Columns[3].Width = 150;
                dgvIncome.Columns[4].Width = 200;
                dgvIncome.Columns[5].Width = 280;

                // load events (only if they exist)
                if (reminderImage.Size.Width != 1 || notificationImage.Size.Width != 1)
                {
                   // call the reminder service to only get the active alerts
                    if (reminderService.GetActiveIncomeReminder(int.Parse(income.Id.ToString())) != null)
                    {
                        eventsTable.Rows.Add(income.Id, reminderImage, notificationImage, income.Date);

                        dgvIncomeEvents.AutoSize = true;
                        dgvIncomeEvents.DataSource = eventsTable;
                        this.dgvIncomeEvents.Columns["Id"].Visible = false;
                        dgvIncomeEvents.Columns[1].Width = 175;
                        dgvIncomeEvents.Columns[2].Width = 175;
                        dgvIncomeEvents.Columns[3].Width = 280;
                    }
                }
            }
        }

        private void dgvIncome_SelectionChanged(object sender, EventArgs e)
        {
            LoadRowSelection(Utilities.GetSelectedRow(dgvIncome));           
        }

        private void LoadRowSelection(DataGridViewRow row)
        {
            if (row != null && row.Index != 0)
            {
                txtName.Text = row.Cells[1].Value.ToString();
                txtAmount.Text = row.Cells[3].Value.ToString();
            }
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtAmount.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (FormIsValid(ref errorMessage))
            {
                try
                {
                    Income income = new Income()
                    {
                        Source = txtName.Text,
                        Amount = txtAmount.Text,
                        Id = long.Parse(Utilities.GetSelectedRowCell(dgvIncome, 0).Value.ToString()),
                        UserId = ActiveUser.id,
                        Date = dtpStart.Text
                    };

                    incomeController.Update(income);
                    LoadIncomeAndEventsGrid();

                    MessageBox.Show("Income Updated", "Success");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Unable to Update Income", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private async void DelayMilliseconds(int milliseconds, Action method)
        {            
            await Task.Delay(milliseconds);
            method.Invoke();         
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (FormIsValid(ref errorMessage))
            {
                try
                {
                    Income income = new Income()
                    {
                        Source = txtName.Text,
                        Amount = txtAmount.Text,
                        Id = long.Parse(Utilities.GetSelectedRowCell(dgvIncome, 0).Value.ToString()),
                        Date = dtpStart.Text
                    };

                    incomeController.Delete(income);
                    LoadIncomeAndEventsGrid();
                    MessageBox.Show("Income Deleted", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to Delete Income", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool FormIsValid(ref string errorMessage)
        {
            bool isValid = false;

            if (Utilities.IsEmpty(txtName))
                errorMessage += " - Name cannot be blank\r\n";
            if (Utilities.IsValidCurrency(txtAmount) == false)
                errorMessage += " - Invalid Amount\r\n";           
            
            if (errorMessage == "")
                isValid = true;            

            return isValid; 
        }
              
        private void DisplayControllerError(TextBox ctrl)
        {
            ctrl.BackColor = Color.RosyBrown;
        }
        private void DisplayControllerNoErrors(TextBox ctrl)
        {
            ctrl.BackColor = Color.White;
        }

        private void txtAmount_MouseLeave(object sender, EventArgs e)
        {
            // remove the $
            txtAmount.Text = txtAmount.Text.Replace("$", "");
        }

        private void dgvIncome_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NotificationFormPopup popup = new NotificationFormPopup(ReminderType.INCOME, int.Parse(Utilities.GetSelectedRowCell(dgvIncome,0).Value.ToString()));
            popup.ShowDialog();
        }
    }
}
