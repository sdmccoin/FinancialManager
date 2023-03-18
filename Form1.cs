using FinancialManager.UI.Controls;
using FinancialManager.Data.Repositories;
using FinancialManager.Data.Models;
using FinancialManager.Extensions;
using FinancialManager.Utilities;
using System.Diagnostics.Metrics;
using FinancialManager.Interfaces;
using FinancialManager.UI.Controllers;
using FinancialManager.Data.Interfaces;
using System.Reflection;

namespace FinancialManager
{  

    public partial class Form1 : Form
    {
        
        private static ucNotification alertNotify = new ucNotification();
        private static ucNotification notificationNotify = new ucNotification();

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

            // setup alert notifications
            alertNotify = new ucNotification();
            alertNotify.Dock = DockStyle.Left;
            pnlBottom.Controls.Add(alertNotify);

            // setup notification notifications
            notificationNotify = new ucNotification();
            notificationNotify.NotificationImage.Image = Image.FromFile("C:\\git\\src\\FinancialManager\\FinancialManager\\Resources\\notificationAlert.png");
            notificationNotify.Dock = DockStyle.Left;
            pnlBottom.Controls.Add(notificationNotify);

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
            IController reminders = ControllerFactory.GetController("Reminder");
            int count = reminders.GetAll(ActiveUser.id).ToList().Count;

            notificationNotify.AlertCount = count.ToString();
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
                Thread.Sleep(10000);
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

            // notify user of alert
            if (alertNotify.CountLabel.Visible == false)
                alertNotify.CountLabel.Visible = true;
            else
                alertNotify.CountLabel.Visible = false;

        }

        /// <summary>
        /// Notification Blinker - Update UI Thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker2_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

            // notify user of notification
            if (notificationNotify.CountLabel.Visible == false)
                notificationNotify.CountLabel.Visible = true;
            else
                notificationNotify.CountLabel.Visible = false;
        }

        

        private void backgroundWorker3_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            CheckForNotifications();
        }

        #endregion

      
    }
    // admin - Pa$$word1 - DB
    // root - flannelman
    
}