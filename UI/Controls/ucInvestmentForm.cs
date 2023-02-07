using FinancialManager.Data.Models;
using FinancialManager.Data.Repositories;
using FinancialManager.Interfaces;
using FinancialManager.UI.Controllers;
using FinancialManager.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinancialManager.UI.Controls
{
    public partial class ucInvestmentForm : UserControl
    {
        IController controller;
        IController investmentReminderController;
        IController investmentNotificationController;

        DataTable investmentTable;

        public ucInvestmentForm()
        {
            InitializeComponent();
            InitializeInvestmentTable();

            // use a factory pattern to get an income controller
            controller = ControllerFactory.GetController("Investment");
        }

        private void InitializeInvestmentTable()
        {
            investmentTable = new DataTable();
            investmentTable.Columns.Add("Id", typeof(int));
            investmentTable.Columns.Add("Name", typeof(string));
            investmentTable.Columns.Add("Amount", typeof(string));
            investmentTable.Columns.Add("Frequency", typeof(string));
            investmentTable.Columns.Add("Type", typeof(string));
            investmentTable.Columns.Add("Reminder", typeof(Image));
            investmentTable.Columns.Add("Notification", typeof(Image));
        }

        #region UI Event(s)
        private void ucInvestmentForm_Load(object sender, EventArgs e)
        {
            LoadInvestmentsGrid();            

            // delegate to clear the form after .1 seconds 
            Action clear = () => ClearForm();
            DelayMilliseconds(100, clear);
        }
        private void dgvInvestments_SelectionChanged(object sender, EventArgs e)
        {            
            LoadRowSelection(Utilities.GetSelectedRow(dgvInvestments));            
        }
        #endregion

        #region CRUD Operations
        private void LoadInvestmentsGrid()
        {
            // initialize controllers
            investmentReminderController = ControllerFactory.GetController("InvestmentReminder");
            //investmentNotificationController = ControllerFactory.GetController("InvestmentNotification");

            // get all the users income and associated reminders and notifications
            List<Investment> investments = (List<Investment>)controller.GetAll(ActiveUser.id);
            List<InvestmentReminder> reminders = (List<InvestmentReminder>)investmentReminderController.GetAll(ActiveUser.id);
           // List<InvestmentNotification> notifications = (List<InvestmentNotification>)investmentNotificationController.GetAll(ActiveUser.id);

            Bitmap reminderImage;
            Bitmap notificationImage;
            foreach (Investment investment in investments)
            {
                reminderImage = null;
                notificationImage = null;

                // load reminders
                foreach (InvestmentReminder reminder in reminders)
                {
                    // determine whether to show reminder image
                    if (reminder.InvestmentId == investment.Id)
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

                investmentTable.Rows.Add(investment.Id, investment.Source, investment.Amount,
                        investment.Frequency, investment.Type, reminderImage, notificationImage);

                dgvInvestments.AutoSize = true;
                dgvInvestments.DataSource = investmentTable;
                this.dgvInvestments.Columns["Id"].Visible = false;
                dgvInvestments.Columns[1].Width = 200;
                dgvInvestments.Columns[2].Width = 450;
                dgvInvestments.Columns[3].Width = 150;
                dgvInvestments.Columns[4].Width = 200;
                dgvInvestments.Columns[5].Width = 150;
                dgvInvestments.Columns[6].Width = 150;
                dgvInvestments.AutoSize = true;
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (FormIsValid(ref errorMessage))
            {
                try
                {
                    Investment investment = new Investment()
                    {
                        Source = txtName.Text,
                        Amount = txtAmount.Text,
                        UserId = ActiveUser.id,
                        Frequency = Utilities.GetSelectedRadioButton(gbxFrequency).Text,
                        Type = Utilities.GetSelectedRadioButton(gbxType).Text
                    };

                    // make sure the entry doesn't already exist
                    if (controller.Exists(investment) == null)
                    {
                        controller.Add(investment);
                        LoadInvestmentsGrid();

                        MessageBox.Show("Investment Added", "Success");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to Add Investment", "Failed",
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
                    Investment investment = new Investment()
                    {
                        Source = txtName.Text,
                        Amount = txtAmount.Text,
                        Frequency = Utilities.GetSelectedRadioButton(gbxFrequency).Text,
                        Type = Utilities.GetSelectedRadioButton(gbxType).Text,
                        Id = long.Parse(Utilities.GetSelectedRowCell(dgvInvestments, 0).Value.ToString()),
                        UserId = ActiveUser.id

                    };

                    controller.Update(investment);
                    LoadInvestmentsGrid();

                    MessageBox.Show("Investment Updated", "Success");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Unable to Update Investment", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Investment investment = new Investment()
                    {
                        Source = txtName.Text,
                        Amount = txtAmount.Text,
                        Frequency = Utilities.GetSelectedRadioButton(gbxFrequency).Text,
                        Type = Utilities.GetSelectedRadioButton(gbxType).Text,
                        Id = long.Parse(Utilities.GetSelectedRowCell(dgvInvestments, 0).Value.ToString()),
                        UserId = ActiveUser.id
                    };

                    controller.Delete(investment);
                    LoadInvestmentsGrid();

                    MessageBox.Show("Investment Deleted", "Success");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Unable to Delete Investment", "Failed", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        #endregion


        #region Private Methods
        private void ClearForm()
        {
            txtName.Text = "";
            txtAmount.Text = "";

            Utilities.UnSelectAllRadioButtons(gbxFrequency);
            Utilities.UnSelectAllRadioButtons(gbxType);
        }

        private void LoadRowSelection(DataGridViewRow row)
        {
            if (row != null)
            {
                txtName.Text = row.Cells[1].Value.ToString();
                txtAmount.Text = row.Cells[2].Value.ToString();

                Utilities.SelectRadioButton(gbxFrequency, row.Cells[4].Value.ToString());
                Utilities.SelectRadioButton(gbxType, row.Cells[5].Value.ToString());
            }            
        }
        private async void DelayMilliseconds(int milliseconds, Action method)
        {
            await Task.Delay(milliseconds);
            method.Invoke();         
        }

        private bool FormIsValid(ref string errorMessage)
        {
            bool isValid = false;

            if (Utilities.IsEmpty(txtName))
                errorMessage += " - Name cannot be blank\r\n";
            if (Utilities.GetSelectedRadioButton(gbxFrequency) == null)
                errorMessage += " - You must select a frequency\r\n";
            if (Utilities.GetSelectedRadioButton(gbxType) == null)
                errorMessage += " - You must select a type\r\n";
            if (Utilities.IsValidCurrency(txtAmount) == false)
                errorMessage += " - Invalid Amount\r\n";

            if (errorMessage == "")
                isValid = true;

            return isValid;
        }
        #endregion

        private void dgvInvestments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NotificationFormPopup popup = new NotificationFormPopup(ReminderType.INVESTMENT, int.Parse(Utilities.GetSelectedRowCell(dgvInvestments, 0).Value.ToString()));
            popup.ShowDialog();
        }
    }
}
