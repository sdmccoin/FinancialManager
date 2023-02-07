using FinancialManager.Data.Models;
using FinancialManager.Data.Repositories;
using FinancialManager.Utilities;
using FinancialManager.UI.Controllers;
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
using FinancialManager.Interfaces;

namespace FinancialManager.UI.Controls
{
    public partial class ucExpenseForm : UserControl
    {
        IController controller;
        IController expenseReminderController;
        IController expenseNotificationController;

        DataTable expenseTable;

        public ucExpenseForm()
        {
            InitializeComponent();
            InitializeExpenseTable();

            // use a factory pattern to get an income controller
            controller = ControllerFactory.GetController("Expense");
        }

        private void InitializeExpenseTable()
        {
            expenseTable = new DataTable();
            expenseTable.Columns.Add("Id", typeof(int));
            expenseTable.Columns.Add("Name", typeof(string));
            expenseTable.Columns.Add("Address", typeof(string));
            expenseTable.Columns.Add("Amount", typeof(string));
            expenseTable.Columns.Add("Frequency", typeof(string));
            expenseTable.Columns.Add("Reminder", typeof(Image));
            expenseTable.Columns.Add("Notification", typeof(Image));
        }

        #region CRUD Operations
        private void LoadExpensesGrid()
        {
            // initialize controllers
            expenseReminderController = ControllerFactory.GetController("ExpenseReminder");
            //expenseNotificationController = ControllerFactory.GetController("ExpenseNotification");

            // get all the users income and associated reminders and notifications
            List<Expense> incomes = (List<Expense>)controller.GetAll(ActiveUser.id);
            List<ExpenseReminder> reminders = (List<ExpenseReminder>)expenseReminderController.GetAll(ActiveUser.id);
           // List<ExpenseNotification notifications = (List<IncomeNotification>)expenseNotificationController.GetAll(ActiveUser.id);

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

                expenseTable.Rows.Add(expense.Id, expense.Source, expense.Address, expense.Amount,
                        expense.Frequency, reminderImage, notificationImage);

                dgvExpenses.AutoSize = true;
                dgvExpenses.DataSource = expenseTable;
                this.dgvExpenses.Columns["Id"].Visible = false;
                dgvExpenses.Columns[1].Width = 200;
                dgvExpenses.Columns[2].Width = 450;
                dgvExpenses.Columns[3].Width = 150;
                dgvExpenses.Columns[4].Width = 200;
                dgvExpenses.Columns[5].Width = 150;
                dgvExpenses.Columns[6].Width = 150;
                dgvExpenses.AutoSize = true;
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
                        Address = txtAddress1.Text,
                        Frequency = Utilities.GetSelectedRadioButton(groupBox1).Text,
                        UserId = ActiveUser.id
                    };

                    // make sure the entry doesn't already exist
                    if (controller.Exists(expense) == null)
                    {
                        controller.Add(expense);
                        LoadExpensesGrid();

                        MessageBox.Show("Income Added", "Success");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
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
                        Address = txtAddress1.Text,
                        Frequency = Utilities.GetSelectedRadioButton(groupBox1).Text,
                        Id = long.Parse(Utilities.GetSelectedRowCell(dgvExpenses, 0).Value.ToString()),
                        UserId = ActiveUser.id
                    };

                    controller.Update(expense);
                    MessageBox.Show("Expense Updated", "Success");

                    LoadExpensesGrid();
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
                        Address = txtAddress1.Text,
                        Frequency = Utilities.GetSelectedRadioButton(groupBox1).Text,
                        Id = long.Parse(Utilities.GetSelectedRowCell(dgvExpenses, 0).Value.ToString()),
                        UserId = ActiveUser.id
                    };

                    controller.Delete(expense);
                    LoadExpensesGrid();

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
                txtAddress1.Text = row.Cells[3].Value.ToString();
                txtAmount.Text = row.Cells[2].Value.ToString();

                Utilities.SelectRadioButton(groupBox1, row.Cells[4].Value.ToString());
            }
        }

        private bool FormIsValid(ref string errorMessage)
        {
            bool isValid = false;

            if (Utilities.IsEmpty(txtAddress1))
                errorMessage += " - Address cannot be blank\r\n";
            if (Utilities.IsEmpty(txtName))
                errorMessage += " - Name cannot be blank\r\n";
            if (Utilities.GetSelectedRadioButton(groupBox1) == null)
                errorMessage += " - You must select a frequency\r\n";
            if (Utilities.IsValidCurrency(txtAmount) == false)
                errorMessage += " - Invalid Amount\r\n";

            if (errorMessage == "")
                isValid = true;

            return isValid;
        }


        #endregion

        private void ucExpenseForm_Load(object sender, EventArgs e)
        {
            LoadExpensesGrid();

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
            txtAddress1.Text = "";
            txtAddress2.Text = "";

            Utilities.UnSelectAllRadioButtons(groupBox1);
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
