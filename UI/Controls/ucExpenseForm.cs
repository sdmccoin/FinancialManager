using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Data.Repositories;
using FinancialManagerLibrary.Utilities;
using FinancialManagerLibrary.UI.Controllers;
using FinancialManager.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialManagerLibrary.Interfaces;

namespace FinancialManager.UI.Controls
{
    public partial class ucExpenseForm : UserControl
    {
        IController controller;
        IController expenseReminderController;
        IController expenseNotificationController;

        DataTable expenseTable;
        DataTable eventsTable;

        public ucExpenseForm()
        {
            InitializeComponent();
            InitializeExpenseTable();
            InitializeEventsTable();

            // use a factory pattern to get an income controller
            controller = ControllerFactory.GetController("Expense");
        }

        private void InitializeExpenseTable()
        {
            expenseTable = new DataTable();
            expenseTable.Columns.Add("Id", typeof(int));
            expenseTable.Columns.Add("Name", typeof(string));
            expenseTable.Columns.Add("Amount", typeof(string));
            expenseTable.Columns.Add("Reminder", typeof(Image));
            expenseTable.Columns.Add("Notification", typeof(Image));
            expenseTable.Columns.Add("Date", typeof(string));
        }
        private void InitializeEventsTable()
        {
            eventsTable = new DataTable();
            eventsTable.Columns.Add("Id", typeof(int));
            eventsTable.Columns.Add("Reminder", typeof(Image));
            eventsTable.Columns.Add("Notification", typeof(Image));
            eventsTable.Columns.Add("Date", typeof(string));
        }

        #region CRUD Operations
        private void LoadIncomeAndEventsGrid()
        {
            // initialize controllers
            expenseReminderController = ControllerFactory.GetController("ExpenseReminder");
            //expenseNotificationController = ControllerFactory.GetController("ExpenseNotification");

            // get all the users income and associated reminders and notifications
            List<Expense> incomes = (List<Expense>)controller.GetAll(ActiveUser.id);
            List<ExpenseReminder> reminders = (List<ExpenseReminder>)expenseReminderController.GetAll(ActiveUser.id);
            // List<ExpenseNotification notifications = (List<IncomeNotification>)expenseNotificationController.GetAll(ActiveUser.id);

            // clear prior to reloading
            expenseTable.Clear();
            dgvExpenses.DataSource = expenseTable;
            dgvExpenses.Refresh();

            eventsTable.Clear();
            dgvExpenseEvents.DataSource = eventsTable;
            dgvExpenseEvents.Refresh();

            Bitmap reminderImage;
            Bitmap notificationImage;
            foreach (Expense expense in incomes)
            {
                reminderImage = null;
                notificationImage = null;

                // load reminders
                foreach (ExpenseReminder reminder in reminders)
                {
                    // determine whether to show reminder image
                    if (reminder.ExpenseId == expense.Id)
                    {
                        reminderImage = new Bitmap(SystemIcons.Exclamation.ToBitmap(), 25, 25);
                        break;
                    }
                }

                // load notifications
                //foreach (ExpenseNotification notification in notifications)
                //{
                //    if (notification.ExpenseId == income.Id)
                //    {
                //        notificationImage = new Bitmap(SystemIcons.Information.ToBitmap(), 25, 25);
                //        break;
                //    }
                //}

                // set a "blank" image if there is no notification or reminder
                if (reminderImage == null)
                    reminderImage = new Bitmap(SystemIcons.Exclamation.ToBitmap(), 1, 1);
                if (notificationImage == null)
                    notificationImage = new Bitmap(SystemIcons.Information.ToBitmap(), 1, 1);

                expenseTable.Rows.Add(expense.Id, expense.Source, expense.Amount,
                        reminderImage, notificationImage, expense.Date);

                dgvExpenses.AutoSize = true;
                dgvExpenses.DataSource = expenseTable;
                this.dgvExpenses.Columns["Id"].Visible = false;
                dgvExpenses.Columns[1].Width = 540;
                dgvExpenses.Columns[2].Width = 200;
                dgvExpenses.Columns[3].Width = 150;
                dgvExpenses.Columns[4].Width = 200;
                dgvExpenses.Columns[5].Width = 280;
                dgvExpenses.AutoSize = true;

                // load events (only if they exist)
                if (reminderImage.Size.Width != 1 || notificationImage.Size.Width != 1)
                {
                    eventsTable.Rows.Add(expense.Id, reminderImage, notificationImage, expense.Date);

                    dgvExpenseEvents.AutoSize = true;
                    dgvExpenseEvents.DataSource = eventsTable;
                    this.dgvExpenseEvents.Columns["Id"].Visible = false;
                    dgvExpenseEvents.Columns[1].Width = 175;
                    dgvExpenseEvents.Columns[2].Width = 175;
                    dgvExpenseEvents.Columns[3].Width = 280;
                }
            }
           // dgvExpenses.DataSource = controller.GetAll(ActiveUser.id);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (FormIsValid(ref errorMessage))
            {
                try
                {
                    Expense expense = new Expense()
                    {
                        Source = txtName.Text,
                        Amount = txtAmount.Text,
                        UserId = ActiveUser.id,
                        Date = dtpStart.Text
                    };

                    // make sure the entry doesn't already exist
                    if (controller.Exists(expense) == null)
                    {
                        controller.Add(expense);
                        LoadIncomeAndEventsGrid();

                        MessageBox.Show("Expense Added", "Success");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Unable to Add Expense", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (FormIsValid(ref errorMessage))
            {
                try
                {
                    Expense expense = new Expense()
                    {
                        Source = txtName.Text,
                        Amount = txtAmount.Text,
                        Id = long.Parse(Utilities.GetSelectedRowCell(dgvExpenses, 0).Value.ToString()),
                        UserId = ActiveUser.id,
                        Date = dtpStart.Text
                    };

                    controller.Update(expense);
                    MessageBox.Show("Expense Updated", "Success");

                    LoadIncomeAndEventsGrid();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Unable to Update Expense", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (FormIsValid(ref errorMessage))
            {
                try
                {
                    Expense expense = new Expense()
                    {
                        Source = txtName.Text,
                        Amount = txtAmount.Text,
                        Id = long.Parse(Utilities.GetSelectedRowCell(dgvExpenses, 0).Value.ToString()),
                        UserId = ActiveUser.id,
                        Date = dtpStart.Text
                    };

                    controller.Delete(expense);
                    LoadIncomeAndEventsGrid();

                    MessageBox.Show("Expense Deleted", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to Delete Expense", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Private Methods
        private void LoadRowSelection(DataGridViewRow row)
        {
            if (row != null)
            {
                txtName.Text = row.Cells[1].Value.ToString();
                txtAmount.Text = row.Cells[2].Value.ToString();
                dtpStart.Text = row.Cells[5].Value.ToString();
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


        #endregion

        private void ucExpenseForm_Load(object sender, EventArgs e)
        {
            LoadIncomeAndEventsGrid();

            // delegate to clear the form after .1 seconds 
            Action clear = () => ClearForm();
            DelayMilliseconds(100, clear);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtAmount.Text = "";
        }

        private async void DelayMilliseconds(int milliseconds, Action method)
        {
            await Task.Delay(milliseconds);
            method.Invoke();
            //ClearForm();            
        }
       

        private void dgvExpenses_SelectionChanged(object sender, EventArgs e)
        {
            LoadRowSelection(Utilities.GetSelectedRow(dgvExpenses));            
        }

        private void dgvExpenses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NotificationFormPopup popup = new NotificationFormPopup(ReminderType.EXPENSE, int.Parse(Utilities.GetSelectedRowCell(dgvExpenses, 0).Value.ToString()));
            popup.ShowDialog();
        }

    }
}
