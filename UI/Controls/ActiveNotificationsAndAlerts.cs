using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.UI.Controllers;
using FinancialManagerLibrary.Utilities;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ActiveNotificationsAndAlerts : Form
    {
        IController reminderController;
        IController investmentReminderController;
        IController investmentNotificationController;
        IController incomeReminderController;
        IController incomeNotificationController;
        IController expenseReminderController;
        IController expenseNotificationController;

        DataTable eventsTable;

        public ActiveNotificationsAndAlerts()
        {
            InitializeComponent();
            reminderController = ControllerFactory.GetController("Reminder");

            InitializedgvAlertsAndNotificationsTable();
            LoaddgvAlertsAndNotificationsGrid();

            
        }

        private void InitializedgvAlertsAndNotificationsTable()
        {
            eventsTable = new DataTable();
            eventsTable.Columns.Add("Id", typeof(int));
            eventsTable.Columns.Add("Reminder", typeof(Image));
            eventsTable.Columns.Add("Message", typeof(string));
            eventsTable.Columns.Add("Date", typeof(string));
            eventsTable.Columns.Add("Time", typeof(string));
            eventsTable.Columns.Add("Frequency", typeof(string));
            eventsTable.Columns.Add("Enabled", typeof(int));
        }

        private void LoaddgvAlertsAndNotificationsGrid()
        {
            // initialize controllers
            //reminderController = ControllerFactory.GetController("Reminder");
            //investmentReminderController = ControllerFactory.GetController("InvestmentReminder");
            //incomeReminderController = ControllerFactory.GetController("IncomeReminder");
            //expenseReminderController = ControllerFactory.GetController("ExpenseReminder");

            //incomeNotificationController = ControllerFactory.GetController("IncomeNotification");

            //expenseNotificationController = ControllerFactory.GetController("ExpenseNotification");

            // get all alerts and notifications for this user
            //List<InvestmentReminder> investmentReminders = (List<InvestmentReminder>)investmentReminderController.GetAll(ActiveUser.id);
            //List<IncomeReminder> incomeReminders = (List<IncomeReminder>)incomeReminderController.GetAll(ActiveUser.id);
            //List<ExpenseReminder> expenseReminders = (List<ExpenseReminder>)expenseReminderController.GetAll(ActiveUser.id);

            //List<IncomeNotification> incomeNotifications = (List<IncomeNotification>)incomeNotificationController.GetAll(ActiveUser.id);
            // List<ExpenseNotification notifications = (List<IncomeNotification>)expenseNotificationController.GetAll(ActiveUser.id);

            // filter based on daterange
            eventsTable.Clear();
            dgvAlertsAndNotifications.DataSource = eventsTable;
            dgvAlertsAndNotifications.Refresh();

            dgvAlertsAndNotifications.AutoSize = true;
            dgvAlertsAndNotifications.DataSource = eventsTable;
            this.dgvAlertsAndNotifications.Columns["Id"].Visible = false;
            dgvAlertsAndNotifications.Columns[1].Width = 200;
            dgvAlertsAndNotifications.Columns[2].Width = 420;
            dgvAlertsAndNotifications.Columns[3].Width = 300;
            dgvAlertsAndNotifications.Columns[4].Visible = false;
            dgvAlertsAndNotifications.Columns[5].Visible = false;
            dgvAlertsAndNotifications.Columns[6].Visible = false;

            //dgvAlertsAndNotifications.Columns[4].Width = 200;
            //dgvAlertsAndNotifications.Columns[5].Width = 280;

            IController settingsController = ControllerFactory.GetController("Settings");
            long alertWindow = ((List<Setting>)settingsController.GetAll(ActiveUser.id)).FirstOrDefault().AlertWindowDays;

            List<Reminder> remindersList = (List<Reminder>)reminderController.GetAll(ActiveUser.id);
            var orderedList = remindersList.OrderByDescending(x => DateTime.Parse(x.Date)).ToList();
            List<Reminder> filteredList = new List<Reminder>();

            foreach (Reminder reminder in orderedList)
            {
                // make sure the reminder date is earlier than the current date/time and within 1 day of
                // predefined limit (i.e., 1 day)
                if (DateTime.Compare(DateTime.Parse(reminder.Date), DateTime.Now) <= 0 &&
                   DateTime.Compare(DateTime.Parse(reminder.Date), DateTime.Now.AddDays(alertWindow)) <= 0)
                {
                    eventsTable.Rows.Add(reminder.Id, 
                        new Bitmap(SystemIcons.Exclamation.ToBitmap(), 25, 25), 
                        reminder.Message, 
                        reminder.Date,
                        reminder.Time,
                        reminder.Frequency,
                        reminder.Enabled);

                    dgvAlertsAndNotifications.AutoSize = true;
                    dgvAlertsAndNotifications.DataSource = eventsTable;
                    this.dgvAlertsAndNotifications.Columns["Id"].Visible = false;
                    dgvAlertsAndNotifications.Columns[1].Width = 200;
                    dgvAlertsAndNotifications.Columns[2].Width = 420;
                    dgvAlertsAndNotifications.Columns[3].Width = 300;
                    dgvAlertsAndNotifications.Columns[4].Visible = false;
                    dgvAlertsAndNotifications.Columns[5].Visible = false;
                    dgvAlertsAndNotifications.Columns[6].Visible = false;


                    //filteredList.Add(reminder);
                }
            }

            // set the grid row to indicate disabled
            foreach (DataGridViewRow row in dgvAlertsAndNotifications.Rows)
            {
                
            }

           

            /*List<Income> allIncome = (List<Income>)incomeController.GetAll(userId);
            var orderedList = allIncome.OrderByDescending(x => DateTime.Parse(x.Date)).ToList();
            List<Income> filteredList = new List<Income>();

            foreach (var income in orderedList)
            {
                // make sure the date is within our filter range
                if (DateTime.Compare(DateTime.Parse(income.Date), DateTime.Parse(start)) >= 0 &&
                    DateTime.Compare(DateTime.Parse(income.Date), DateTime.Parse(end)) <= 0)
                {
                    filteredList.Add(income);
                }
            }

            return filteredList;
            // load alerts and notifications (only if they exist)
            if (reminderImage.Size.Width != 1 || notificationImage.Size.Width != 1)
            {
                eventsTable.Rows.Add(investment.Id, reminderImage, notificationImage, investment.Date);

                dgvInvestmentsEvents.AutoSize = true;
                dgvInvestmentsEvents.DataSource = eventsTable;
                this.dgvInvestmentsEvents.Columns["Id"].Visible = false;
                dgvInvestmentsEvents.Columns[1].Width = 175;
                dgvInvestmentsEvents.Columns[2].Width = 175;
                dgvInvestmentsEvents.Columns[3].Width = 280;
            }*/
        }

        private void ActiveNotificationsAndAlerts_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Reminder reminder = new Reminder()
                {
                     Id = int.Parse(Utilities.GetSelectedRow(dgvAlertsAndNotifications).Cells[0].Value.ToString()),
                     Date = Utilities.GetSelectedRow(dgvAlertsAndNotifications).Cells[3].Value.ToString(),
                     Enabled = (rbnEnable.Checked == true) ? 1 : 0,
                     UserId = ActiveUser.id,
                     Message = Utilities.GetSelectedRow(dgvAlertsAndNotifications).Cells[2].Value.ToString(),
                     Time = Utilities.GetSelectedRow(dgvAlertsAndNotifications).Cells[4].Value.ToString(),
                     Frequency = Utilities.GetSelectedRow(dgvAlertsAndNotifications).Cells[5].Value.ToString()
                };

                // make sure the entry already exist
                if (reminderController.Exists(reminder) != null)
                {
                    reminderController.Update(reminder);
                    LoaddgvAlertsAndNotificationsGrid();

                    MessageBox.Show("Reminder Updated", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Update Reminder", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAlertsAndNotifications_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

            var enabled = Convert.ToInt16(dgvAlertsAndNotifications.Rows[e.RowIndex].Cells[6].Value);
           
            if (enabled == 0)
            {
                dgvAlertsAndNotifications.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
            }
            else
            {
                dgvAlertsAndNotifications.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSteelBlue;
            }

        }

        private void dgvAlertsAndNotifications_SelectionChanged(object sender, EventArgs e)
        {
            LoadRowSelection(Utilities.GetSelectedRow(dgvAlertsAndNotifications));
        }

        private void LoadRowSelection(DataGridViewRow row)
        {
            if (row != null && row.Index != 0)
            {
                rbnDisable.Checked = (row.Cells[6].Value.ToString() == "0") ? true : false;
                rbnEnable.Checked = (row.Cells[6].Value.ToString() == "1") ? true : false;                
            }
        }
    }
}
