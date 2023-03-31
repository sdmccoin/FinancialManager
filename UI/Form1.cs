using FinancialManager.UI.Controls;
using FinancialManagerLibrary.Data.Repositories;
using FinancialManagerLibrary.Data.Models;
//using FinancialManagerLibrary.Extensions;
using FinancialManagerLibrary.Utilities;
using System.Diagnostics.Metrics;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.UI.Controllers;
using FinancialManagerLibrary.Data.Interfaces;
using System.Reflection;
using System.Collections.Generic;
using FinancialManagerLibrary.Services;

namespace FinancialManager
{  

    public partial class Form1 : Form
    {
        
        private static ucNotification alertNotify = new ucNotification();
        private static ucNotification notificationNotify = new ucNotification();
        IController settingsController;
        long alertWindow = 0;
        bool activeAlerts = false;
        bool activeNotifications = false;

        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {        
            Login login = new Login();
            DialogResult result = login.ShowDialog();
            //if (result == DialogResult.Cancel)
              //  this.Close();

            InitializeComponents();           

        }

        private void InitializeComponents()
        {
            // ensure only authenticated users can use the system
            if (ActiveUser.id < 0)
                this.Close();
            else if (ActiveUser.id == 0)
            {
                DisableUI();
            }

            settingsController = ControllerFactory.GetController("Settings");
            alertWindow = ((List<Setting>)settingsController.GetAll(ActiveUser.id)).FirstOrDefault().AlertWindowDays;

            // setup alert notifications
            alertNotify = new ucNotification();
            alertNotify.Dock = DockStyle.Left;
            pnlAlerts.Controls.Add(alertNotify);

            // setup notification notifications
            notificationNotify = new ucNotification();
            notificationNotify.NotificationImage.Image = Image.FromFile("C:\\git\\src\\FinancialManager\\FinancialManager\\Resources\\notificationAlert.png");
            notificationNotify.Dock = DockStyle.Left;
            pnlAlerts.Controls.Add(notificationNotify);

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();

            if (!backgroundWorker2.IsBusy)
                backgroundWorker2.RunWorkerAsync();

            if (!backgroundWorker3.IsBusy)
                backgroundWorker3.RunWorkerAsync();
        }

        private void tsBtnIncome_Click(object sender, EventArgs e)
        {
            ClearMain();
            pnlMain.Controls.Add(new ucIncomeForm());
        }

        private void ClearMain()
        {
            pnlMain.Controls.Clear();
        }

        private void DisableUI()
        {
            toolStrip1.Enabled = false;
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                DisableMenuItems(item);
            }
        }

        /// <summary>
        /// Recursive method used to disable all menu items
        /// </summary>
        /// <param name="item"></param>
        private void DisableMenuItems(ToolStripMenuItem item)
        {
            // enable only account creation for admin account
            if (item.Text == "File" || item.Text == "New" || item.Text == "Account")
                item.Enabled = true;
            else
                item.Enabled = false;

        
            foreach (ToolStripItem i in item.DropDownItems)
            {
                if (i is ToolStripMenuItem)
                {
                    DisableMenuItems((ToolStripMenuItem)i);
                }
            }
        }

        private void txBtnExpense_Click(object sender, EventArgs e)
        {
            ClearMain();
            pnlMain.Controls.Add(new ucExpenseForm());

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new User Account
            ClearMain();
            pnlMain.Controls.Add(new ucAccountForm());
        }

        private void tsBtnInvestments_Click(object sender, EventArgs e)
        {
            ClearMain();
            pnlMain.Controls.Add(new ucInvestmentForm());
        }

        private void tsBtnReports_Click(object sender, EventArgs e)
        {
            ClearMain();
            pnlMain.Controls.Add(new ucReportForm());
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearMain();
            pnlMain.Controls.Add(new ucSettingsForm());
        }

        private void notificationNotify_Click(object sender, EventArgs e) 
        {
            // Show all active notifications
            //MessageBox.Show("notifications");
        }
        private void alertNotify_Click(object sender, EventArgs e)
        {
            // Show all active alerts
            //MessageBox.Show("alerts");
        }

        /// <summary>
        /// check for newly added reminders in the system
        /// </summary>
        private void CheckForNotifications()
        {
            //IController reminders = ControllerFactory.GetController("Reminder");
            //List<Reminder> remindersList = (List<Reminder>)reminders.GetAll(ActiveUser.id);
            //var orderedList = remindersList.OrderByDescending(x => DateTime.Parse(x.Date)).ToList();
            //List<Reminder> filteredList = new List<Reminder>();

            //foreach (Reminder reminder in orderedList)
            //{
            //    // make sure the reminder date is earlier than the current date/time and within 1 day of
            //    // predefined limit (i.e., 1 day)
            //    if (DateTime.Compare(DateTime.Parse(reminder.Date), DateTime.Now) <= 0 &&
            //       DateTime.Compare(DateTime.Parse(reminder.Date), DateTime.Now.AddDays(alertWindow)) <= 0)
            //    {
            //        if (reminder.Enabled == 1)
            //            filteredList.Add(reminder);
            //    }
            //}
            ReminderService reminderService = new ReminderService();
            List<Reminder> filteredList = reminderService.GetAllActiveReminders();

            if (filteredList.Count > 0)
            {
                alertNotify.AlertCount = filteredList.Count.ToString();
                activeAlerts = true;
            }
            else
            {
                activeAlerts = false;
            }
            
            //notificationNotify.AlertCount = filteredList.Count.ToString();
        }

        #region Backgroun Tasks
        /// <summary>
        /// Alert Notification Blinker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //alertNotify.Click += (s, e) => { MessageBox.Show("alerts here"); };
            int counter = 0;
            while (true)
            {
                backgroundWorker1.ReportProgress(0, counter.ToString());
                System.Threading.Thread.Sleep(1000);
                counter++;
            }
        }

        /// <summary>
        /// Notification Blinker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int counter = 0;
            while (true)
            {
                backgroundWorker2.ReportProgress(0, counter.ToString());
                System.Threading.Thread.Sleep(1000);
                counter++;
            }
        }

        private void backgroundWorker3_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int counter = 0;
            while (true)
            {
                Thread.Sleep(3000);
                backgroundWorker3.ReportProgress(0, counter.ToString());                
                counter++;
            }

        }

        /// <summary>
        /// Alert Blinker - Update UI Thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (activeAlerts)
            {
                // notify user of alert
                if (alertNotify.CountLabel.Visible == false)
                    alertNotify.CountLabel.Visible = true;
                else
                    alertNotify.CountLabel.Visible = false;
            }
            else
            {
                alertNotify.CountLabel.Visible = false;
            }
            

        }

        /// <summary>
        /// Notification Blinker - Update UI Thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker2_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

            if (activeNotifications)
            {
                // notify user of notification
                if (notificationNotify.CountLabel.Visible == false)
                    notificationNotify.CountLabel.Visible = true;
                else
                    notificationNotify.CountLabel.Visible = false;
            }
            else
            {
                notificationNotify.CountLabel.Visible = false;
            }
          
        }

        

        private void backgroundWorker3_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            CheckForNotifications();
        }


        #endregion

        private void btnIncome_Click(object sender, EventArgs e)
        {
            ClearMain();
            pnlMain.Controls.Add(new ucIncomeForm());
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            ClearMain();
            pnlMain.Controls.Add(new ucExpenseForm());
        }

        private void btnInvestments_Click(object sender, EventArgs e)
        {
            ClearMain();
            pnlMain.Controls.Add(new ucInvestmentForm());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ClearMain();
            pnlMain.Controls.Add(new ucReportForm());
        }

        private void pnlAlerts_Click(object sender, EventArgs e)
        {
            
        }
    }
    // admin - Pa$$word1 - DB
    // root - flannelman
    
}