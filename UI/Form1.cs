using FinancialManager.UI.Controls;
using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Utilities;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.UI.Controllers;
using FinancialManagerLibrary.Services;
using FinancialManagerLibrary.Services.Models;

namespace FinancialManager
{  

    public partial class Form1 : Form
    {        
        private static ucNotification alertNotify = new ucNotification();
        private static ucNotification notificationNotify = new ucNotification();
        IController settingsController;
        IController investmentController;
        IController stockAnalyzerController;
        IController investmentNotificationController;
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

            investmentController = ControllerFactory.GetController("Investment");
            investmentNotificationController = ControllerFactory.GetController("InvestmentNotification");

            //if (result == DialogResult.Cancel)
             // this.Close();

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
            var settings = (List<Setting>)settingsController.GetAll(ActiveUser.id);

            if (settings.Count > 0)
            {
                alertWindow = settings.FirstOrDefault().AlertWindowDays;

                // setup alert notifications
                alertNotify = new ucNotification();
                alertNotify.Dock = DockStyle.Left;
                pnlAlerts.Controls.Add(alertNotify);

                // setup notification notifications
                notificationNotify = new ucNotification();
                notificationNotify.NotificationImage.Image = Image.FromFile(ConfigurationService.GetInstance.GetAllConfigItems().Get("NotificationImageLocation"));
                notificationNotify.Dock = DockStyle.Left;
                pnlAlerts.Controls.Add(notificationNotify);

                StartBackgroundServices();
            }                       
        }

        private void StartBackgroundServices()
        {
            // start alert notification service
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();

            // start notification alert service
            if (!backgroundWorker2.IsBusy)
                backgroundWorker2.RunWorkerAsync();

            // start notification check service
            if (!backgroundWorker3.IsBusy)
                backgroundWorker3.RunWorkerAsync();

            // start stock monitoring service
            if (!backgroundWorker4.IsBusy)
                backgroundWorker4.RunWorkerAsync();
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
            NotificationService notificationService = new NotificationService();
            List<InvestmentNotification> filteredNotifications = notificationService.GetAllActiveNotifications();

            if (filteredNotifications.Count > 0)
            {
                notificationNotify.AlertCount = filteredNotifications.Count.ToString();
                activeNotifications = true;
            }
            else
            {
                activeNotifications = false;
            }

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

        #region Background Tasks
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
        /// Stock monitoring service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker4_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {                

                // update monitored stocks
                List<Investment> investments = (List<Investment>)investmentController.GetAll(ActiveUser.id);

                foreach(Investment investment in investments)
                {
                    if (investment.Monitor == 1)
                    {
                        try
                        {
                            Dictionary<string, string> closingValue = GetStockDataForML(investment);
                            if (closingValue.Count > 0)
                            {
                                LoadAnalyzerTable(closingValue, investment.Source);
                                UpdateInvestmentNotification(investment);

                                investment.LastMonitorCheck = DateTime.Now.ToShortDateString();
                                investmentController.Update(investment);
                            }
                        }
                        catch (Exception ex)
                        {
                            LoggingService.GetInstance.Log(ex.Message);
                        }
                    }
                }

                // run initially, then once every 10 minutes
                Thread.Sleep(600000);
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

        #region Left Side Navigation
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

        private void btnChart_Click(object sender, EventArgs e)
        {
            ClearMain();
            pnlMain.Controls.Add(new ucStockChart());
        }
        #endregion

        private Dictionary<string, string> GetStockDataForML(Investment investment)
        {
            StockService ss = new StockService();
            StockDailiesResponse dailyResponse = new StockDailiesResponse();
            string stockDailyUrl = API.StockSearchDailies + investment.Source + "&outputsize=full&apikey=" + API.StockKey;

            //string stockDailyUrl = "https://www.alphavantage.co/query?function=TIME_SERIES_DAILY_ADJUSTED&symbol=IBM&outputsize=full&apikey=PW20D2R6TX4Y8B5A";

            ss.URL = stockDailyUrl;
            dailyResponse = ss.GetAsync<StockDailiesResponse>();
            Dictionary<string, string> closingValues = new Dictionary<string, string>();

            if (dailyResponse != null)
            {
                if (dailyResponse.Dailies != null)
                {
                    foreach (KeyValuePair<string, Dailies> daily in dailyResponse.Dailies)
                    {
                        // only load the data since the last monitor check
                        if (DateTime.Parse(daily.Key) > DateTime.Parse(investment.LastMonitorCheck))
                        {
                            closingValues.Add(daily.Key, daily.Value.Close);
                        }
                    }
                }
            }

            return closingValues;
        }
        private void LoadAnalyzerTable(Dictionary<string, string> values, string source)
        {
            stockAnalyzerController = ControllerFactory.GetController("StockAnalysis");
            StockAnalysis stockAnalysis;

            foreach (KeyValuePair<string, string> value in values)
            {
                stockAnalysis = new StockAnalysis()
                {
                    ClosingValue = value.Value,
                    Symbol = source,
                    UserId = ActiveUser.id,
                    Date = value.Key
                };

                // doesn't already exist, add it
                if (stockAnalyzerController.Exists(stockAnalysis) == null)
                {
                    stockAnalyzerController.Add(stockAnalysis);
                }
            }
        }

        private void UpdateInvestmentNotification(Investment investment)
        {
            IController invNotifController = ControllerFactory.GetController("InvestmentNotification");
           // add a notification
           InvestmentNotification invNotif = new InvestmentNotification()
           {
               UserId = ActiveUser.id,
               Symbol = investment.Source,
               //Date = DateTime.Now.ToShortDateString(),
               //Message = "A new projection has been completed for your " + investment.Source + " stock on " + DateTime.Now.ToShortDateString()
           };

            // if it already exists, update it, otherwise add a new one
            InvestmentNotification savedNotif = (InvestmentNotification)invNotifController.Exists(invNotif);
            if (savedNotif != null)
            {
                savedNotif.Date = DateTime.Now.ToShortDateString();
                savedNotif.Message = "A new projection has been completed for your " + investment.Source + " stock on " + DateTime.Now.ToShortDateString();
                invNotifController.Update(savedNotif);

                DisplaySystemNotification(savedNotif.Message);
            }
            else
            {
                invNotifController.Add(invNotif);
            }
        }

        private void DisplaySystemNotification(string message)
        {
            NotifyIcon trayIcon = new NotifyIcon();
            trayIcon.Icon = SystemIcons.Information;
            trayIcon.Text = "New message";
            trayIcon.Visible = true;
            trayIcon.ShowBalloonTip(5000, "Information", message, ToolTipIcon.Info);
            
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearMain();
            pnlMain.Controls.Add(new ucLogsForm());
        }
    }
}
    
    // admin - Pa$$word1 - DB
    // root - flannelman
    
