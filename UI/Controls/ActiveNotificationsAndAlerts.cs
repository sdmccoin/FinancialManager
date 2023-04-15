using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.Services;
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
            investmentNotificationController = ControllerFactory.GetController("InvestmentNotification");

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

            NotificationService notificationService = new NotificationService();
            List<InvestmentNotification> filteredNotifications = (List<InvestmentNotification>)investmentNotificationController.GetAll(ActiveUser.id);

            // load the notifications
            foreach (InvestmentNotification notification in filteredNotifications)
            {
                // make sure the reminder date is earlier than the current date/time and within 1 day of
                // predefined limit (i.e., 1 day)
                if (DateTime.Compare(DateTime.Parse(notification.Date), DateTime.Now) <= 0 &&
                   DateTime.Compare(DateTime.Parse(notification.Date), DateTime.Now.AddDays(alertWindow)) <= 0)
                {
                    eventsTable.Rows.Add(notification.InvestmentId,
                        new Bitmap(SystemIcons.Information.ToBitmap(), 26, 26),
                        notification.Message,
                        notification.Date,
                        "",
                        "",
                        notification.Enabled);

                    dgvAlertsAndNotifications.AutoSize = true;
                    dgvAlertsAndNotifications.DataSource = eventsTable;
                    this.dgvAlertsAndNotifications.Columns["Id"].Visible = false;
                    dgvAlertsAndNotifications.Columns[1].Width = 200;
                    dgvAlertsAndNotifications.Columns[2].Width = 420;
                    dgvAlertsAndNotifications.Columns[3].Width = 300;
                    dgvAlertsAndNotifications.Columns[4].Visible = false;
                    dgvAlertsAndNotifications.Columns[5].Visible = false;
                    dgvAlertsAndNotifications.Columns[6].Visible = false;
                }
            }

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


                }
            }

        }

        private void ActiveNotificationsAndAlerts_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(((Bitmap)Utilities.GetSelectedRow(dgvAlertsAndNotifications).Cells[1].Value).Height == 26)
                {
                    InvestmentNotification inv = (InvestmentNotification)investmentNotificationController.GetById(
                        int.Parse(Utilities.GetSelectedRow(dgvAlertsAndNotifications).Cells[0].Value.ToString()));

                    // make sure the entry already exists
                    if (investmentNotificationController.Exists(inv) != null)
                    {
                        inv.Enabled = (rbnEnable.Checked == true) ? 1 : 0;
                        investmentNotificationController.Update(inv);
                        LoaddgvAlertsAndNotificationsGrid();
                        MessageBox.Show("Notification status Updated", "Success");
                    }
                }
                else
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

                        MessageBox.Show("Reminder status Updated", "Success");
                    }
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
            if (row != null)// && row.Index != 0)
            {
                rbnDisable.Checked = (row.Cells[6].Value.ToString() == "0") ? true : false;
                rbnEnable.Checked = (row.Cells[6].Value.ToString() == "1") ? true : false;                
            }
        }
    }
}
