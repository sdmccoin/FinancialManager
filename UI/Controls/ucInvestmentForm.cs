using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Data.Repositories;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.UI.Controllers;
using FinancialManagerLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FinancialManagerLibrary.Services.Models;
using FinancialManagerLibrary.Services;

namespace FinancialManager.UI.Controls
{
    public partial class ucInvestmentForm : UserControl
    {
        IController controller;
        IController investmentReminderController;
        IController investmentNotificationController;

        DataTable investmentTable;
        DataTable eventsTable;

        AutoCompleteStringCollection symbols = new AutoCompleteStringCollection();

        public ucInvestmentForm()
        {
            InitializeComponent();
            InitializeInvestmentTable();
            InitializeEventsTable();

            // use a factory pattern to get an income controller
            controller = ControllerFactory.GetController("Investment");
        }

        private void InitializeInvestmentTable()
        {
            investmentTable = new DataTable();
            investmentTable.Columns.Add("Id", typeof(int));
            investmentTable.Columns.Add("Name", typeof(string));
            investmentTable.Columns.Add("Amount", typeof(string));
            investmentTable.Columns.Add("Reminder", typeof(Image));
            investmentTable.Columns.Add("Notification", typeof(Image));
            investmentTable.Columns.Add("Notes", typeof(string));
        }

        private void InitializeEventsTable()
        {
            eventsTable = new DataTable();
            eventsTable.Columns.Add("Id", typeof(int));
            eventsTable.Columns.Add("Reminder", typeof(Image));
            eventsTable.Columns.Add("Notification", typeof(Image));
            eventsTable.Columns.Add("Date", typeof(string));
        }

        #region UI Event(s)
        private void ucInvestmentForm_Load(object sender, EventArgs e)
        {
            LoadInvestmentsAndEventsGrid();
            txtSymbol.AutoCompleteCustomSource = symbols;

            // delegate to clear the form after .1 seconds 
            Action clear = () => ClearForm();
            DelayMilliseconds(100, clear);
            btnMoreInfo.Image = new Bitmap(SystemIcons.Information.ToBitmap(), 50, 50);
            //pbxMoreInfo.Image = Image.FromFile("C:\\git\\src\\FinancialManager\\FinancialManager\\Resources\\Information_icon.png");
        }
        private void dgvInvestments_SelectionChanged(object sender, EventArgs e)
        {            
            LoadRowSelection(Utilities.GetSelectedRow(dgvInvestments));            
        }
        #endregion

        #region CRUD Operations
        private void LoadInvestmentsAndEventsGrid()
        {
            ReminderService reminderService = new ReminderService();
            NotificationService notificationService = new NotificationService();

            // initialize controllers
            investmentReminderController = ControllerFactory.GetController("InvestmentReminder");
            investmentNotificationController = ControllerFactory.GetController("InvestmentNotification");

            // get all the users income and associated reminders and notifications
            List<Investment> investments = (List<Investment>)controller.GetAll(ActiveUser.id);
            List<InvestmentReminder> reminders = (List<InvestmentReminder>)investmentReminderController.GetAll(ActiveUser.id);
            List<InvestmentNotification> notifications = (List<InvestmentNotification>)investmentNotificationController.GetAll(ActiveUser.id);

            // clear prior to reloading
            investmentTable.Clear();
            dgvInvestments.DataSource = investmentTable;
            dgvInvestments.Refresh();

            eventsTable.Clear();
            dgvInvestmentsEvents.DataSource = eventsTable;
            dgvInvestmentsEvents.Refresh();

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

                // load Notifications
                foreach (InvestmentNotification notification in notifications)
                {
                    // determine whether to show reminder image
                    if (notification.InvestmentId == investment.Id)
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

                investmentTable.Rows.Add(investment.Id, investment.Source, investment.Amount,
                        reminderImage, notificationImage, investment.Notes);

                dgvInvestments.AutoSize = true;
                dgvInvestments.DataSource = investmentTable;
                this.dgvInvestments.Columns["Id"].Visible = false;
                dgvInvestments.Columns[1].Width = 350;
                dgvInvestments.Columns[2].Width = 150;
                dgvInvestments.Columns[3].Width = 150;
                dgvInvestments.Columns[4].Width = 200;
                dgvInvestments.Columns[5].Width = 510;
                dgvInvestments.AutoSize = true;

                // load events (only if they exist)
                if (reminderImage.Size.Width != 1 || notificationImage.Size.Width != 1)
                {                    
                    // call the reminder service to only get the active alerts
                    if (reminderService.GetActiveInvestmentReminder(int.Parse(investment.Id.ToString())) != null)
                    {
                        eventsTable.Rows.Add(investment.Id, reminderImage, notificationImage, investment.Date);

                        dgvInvestmentsEvents.AutoSize = true;
                        dgvInvestmentsEvents.DataSource = eventsTable;
                        this.dgvInvestmentsEvents.Columns["Id"].Visible = false;
                        dgvInvestmentsEvents.Columns[1].Width = 175;
                        dgvInvestmentsEvents.Columns[2].Width = 175;
                        dgvInvestmentsEvents.Columns[3].Width = 280;
                    }                    
                }
                if (notificationImage.Size.Width != 1 || notificationImage.Size.Width != 1)
                {
                    // call the reminder service to only get the active alerts
                    if (notificationService.GetActiveInvestmentNotification(int.Parse(investment.Id.ToString())) != null)
                    {
                        eventsTable.Rows.Add(investment.Id, reminderImage, notificationImage, investment.Date);

                        dgvInvestmentsEvents.AutoSize = true;
                        dgvInvestmentsEvents.DataSource = eventsTable;
                        this.dgvInvestmentsEvents.Columns["Id"].Visible = false;
                        dgvInvestmentsEvents.Columns[1].Width = 175;
                        dgvInvestmentsEvents.Columns[2].Width = 175;
                        dgvInvestmentsEvents.Columns[3].Width = 280;
                    }
                }
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
                        Date = dtpStart.Text,
                        Notes= txtNotes.Text,
                    };

                    // make sure the entry doesn't already exist
                    if (controller.Exists(investment) == null)
                    {
                        controller.Add(investment);
                        LoadInvestmentsAndEventsGrid();

                        MessageBox.Show("Investment Added", "Success");
                    }
                }
                catch (Exception ex)
                {
                    LoggingService.GetInstance.Log(ex.Message);
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
                        Id = long.Parse(Utilities.GetSelectedRowCell(dgvInvestments, 0).Value.ToString()),
                        UserId = ActiveUser.id,
                        Date = dtpStart.Text,
                        Notes = txtNotes.Text,
                        LastMonitorCheck = "4/01/2023"  // database default value isn't working

                    };

                    controller.Update(investment);
                    LoadInvestmentsAndEventsGrid();

                    MessageBox.Show("Investment Updated", "Success");
                }
                catch (Exception ex)
                {
                    LoggingService.GetInstance.Log(ex.Message);
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
                        Id = long.Parse(Utilities.GetSelectedRowCell(dgvInvestments, 0).Value.ToString()),
                        UserId = ActiveUser.id,
                        Date = dtpStart.Text,
                        Notes= txtNotes.Text,
                    };

                    controller.Delete(investment);
                    LoadInvestmentsAndEventsGrid();

                    MessageBox.Show("Investment Deleted", "Success");
                }
                catch (Exception ex)
                {
                    LoggingService.GetInstance.Log(ex.Message);
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
            txtNotes.Text = "";
        }

        private void LoadRowSelection(DataGridViewRow row)
        {
            if (row != null)
            {
                txtName.Text = row.Cells[1].Value.ToString();
                txtAmount.Text = row.Cells[2].Value.ToString();
                txtNotes.Text = row.Cells[5].Value.ToString();
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

        private void btnStockSearch_Click(object sender, EventArgs e)
        {
            StockService ss = new StockService();
            string QUERY_URL = API.StockSearchURL + txtSymbol.Text + "&apikey=" +API.StockKey;
            string stockDailyUrl = API.StockSearchDailies + txtSymbol.Text + "&apikey=" + API.StockKey;

            Uri queryUri = new Uri(QUERY_URL);
            StockSearchResponse json_data = new StockSearchResponse(); ;
            StockDailiesResponse dailyResponse = new StockDailiesResponse();
            decimal currentStockPrice = 0;
            decimal yesterdayStockPrice = 0;
            decimal twoDayAgoStockPrice = 0;
            decimal fourMonthAveragePrice = 0;
            Image stockUp = Image.FromFile(ConfigurationService.GetInstance.GetAllConfigItems().Get("StockUpImageLocation"));
            Image stockDown = Image.FromFile(ConfigurationService.GetInstance.GetAllConfigItems().Get("StockDownImageLocation"));

            ss.URL = QUERY_URL;
            json_data = ss.GetAsync<StockSearchResponse>();
            
            if (json_data != null)
            {
                if (json_data.bestMatches != null)
                {
                    lblSymbol.Text = json_data.bestMatches[0].symbol;
                    lblName.Text = json_data.bestMatches[0].name;
                    lblStockType.Text = json_data.bestMatches[0].type;
                }                    
            }

            ss.URL = stockDailyUrl;
            dailyResponse = ss.GetAsync<StockDailiesResponse>();
            
            if (dailyResponse != null)
                {
                    if (dailyResponse.Dailies!= null)
                    {
                        currentStockPrice = decimal.Parse(dailyResponse.Dailies.Values.Select(d => d.Open).First());
                        yesterdayStockPrice = decimal.Parse(dailyResponse.Dailies.Values.Select(d => d.Open).ToList()[1].ToString());
                        twoDayAgoStockPrice = decimal.Parse(dailyResponse.Dailies.Values.Select(d => d.Open).ToList()[2].ToString());
                        fourMonthAveragePrice = decimal.Parse(dailyResponse.Dailies.Values.Average(d => decimal.Parse(d.Close)).ToString());

                        lblCurrentStockPrice.Text = currentStockPrice.ToString();
                        lblYesterdayStockPrice.Text = yesterdayStockPrice.ToString();
                        lblFourMonthAveragePrice.Text = fourMonthAveragePrice.ToString();


                        pbxCurrentStockPriceIndicator.Image = (currentStockPrice > yesterdayStockPrice) ? stockUp : stockDown;
                        pbxYesterdayStockPriceIndicator.Image = (yesterdayStockPrice > twoDayAgoStockPrice) ? stockUp : stockDown;
                        pbxFourMonthAverageIndicator.Image = (currentStockPrice > fourMonthAveragePrice) ? stockUp : stockDown;
                    }                    
                }               
           // }
        }

        private void txtSymbol_TextChanged(object sender, EventArgs e)
        {           
            //GetSymbols();
        }

        private void GetSymbols()
        {
            string symbolSearchUrl = API.SymbolSearch + txtSymbol.Text + "&apikey=" + API.StockKey;
            StockSearchResponse response = new StockSearchResponse();

            object loc = new object();
            using (WebClient client = new WebClient())
            {
                Task taskA = Task.Run(() => response = JsonSerializer.Deserialize<StockSearchResponse>(client.DownloadString(symbolSearchUrl)));
                taskA.Wait();
                taskA.ContinueWith(t => {
                    if (response != null)
                    {
                        if (response.bestMatches != null)
                        {
                            try
                            {
                                symbols.AddRange(response.bestMatches.Select(m => m.symbol).ToArray());

                            }
                            catch (Exception ex)
                            {
                                LoggingService.GetInstance.Log(ex.Message);
                            }
                        }
                    }
                });                
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            AddInvestmentPopup popup = new AddInvestmentPopup(txtSymbol.Text);
            popup.ShowDialog();
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            AdditionalStockDetailsPopup popup = new AdditionalStockDetailsPopup(txtName.Text, txtSymbol.Text);
            popup.ShowDialog();
        }
    }
}
