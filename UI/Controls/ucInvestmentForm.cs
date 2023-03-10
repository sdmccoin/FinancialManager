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
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FinancialManager.Services.Models;
using FinancialManager.Services;

namespace FinancialManager.UI.Controls
{
    public partial class ucInvestmentForm : UserControl
    {
        IController controller;
        IController investmentReminderController;
        IController investmentNotificationController;

        DataTable investmentTable;

        AutoCompleteStringCollection symbols = new AutoCompleteStringCollection();

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
        private void LoadInvestmentsGrid()
        {
            // initialize controllers
            investmentReminderController = ControllerFactory.GetController("InvestmentReminder");

            // get all the users income and associated reminders and notifications
            List<Investment> investments = (List<Investment>)controller.GetAll(ActiveUser.id);
            List<InvestmentReminder> reminders = (List<InvestmentReminder>)investmentReminderController.GetAll(ActiveUser.id);
           
            // clear prior to reloading
            investmentTable.Clear();
            dgvInvestments.DataSource = investmentTable;
            dgvInvestments.Refresh();

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
            Image stockUp = Image.FromFile("C:\\git\\src\\FinancialManager\\FinancialManager\\Resources\\rsz_stockup.png");
            Image stockDown = Image.FromFile("C:\\git\\src\\FinancialManager\\FinancialManager\\Resources\\rsz_stockdown.png");

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
                                Console.WriteLine(ex);
                            }
                        }
                    }
                });
                //response = JsonSerializer.Deserialize<StockSearchResponse>(client.DownloadString(symbolSearchUrl));
                
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



    /* 
     * 
     * 
     * "https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol=IBM&apikey=PW20D2R6TX4Y8B5A"
     * https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol=IBM&apikey=demo
     * "1. symbol": "TSCO.LON",
            "2. name": "Tesco PLC",
            "3. type": "Equity",
            "4. region": "United Kingdom",
            "5. marketOpen": "08:00",
            "6. marketClose": "16:30",
            "7. timezone": "UTC+01",
            "8. currency": "GBX",
            "9. matchScore": "0.7273"*/

    //       "1. symbol": "TSCO.LON",
    //       "2. name": "Tesco PLC",
    //       "3. type": "Equity",
    //       "4. region": "United Kingdom",
    //       "5. marketOpen": "08:00",
    //       "6. marketClose": "16:30",
    //       "7. timezone": "UTC+01",
    //       "8. currency": "GBX",
    //       "9. matchScore": "0.7273"

    /*
     +		entry.Value	ValueKind = Array : "[
        {
            "1. symbol": "IBM",
            "2. name": "International Business Machines Corp",
            "3. type": "Equity",
            "4. region": "United States",
            "5. marketOpen": "09:30",
            "6. marketClose": "16:00",
            "7. timezone": "UTC-04",
            "8. currency": "USD",
            "9. matchScore": "1.0000"
        },
        {
            "1. symbol": "IBML",
            "2. name": "iShares iBonds Dec 2023 Term Muni Bond ETF",
            "3. type": "ETF",
            "4. region": "United States",
            "5. marketOpen": "09:30",
            "6. marketClose": "16:00",
            "7. timezone": "UTC-04",
            "8. currency": "USD",
            "9. matchScore": "0.8571"
        },
        {
            "1. symbol": "IBMM",
            "2. name": "iShares iBonds Dec 2024 Term Muni Bond ETF",
            "3. type": "ETF",
            "4. region": "United States",
            "5. marketOpen": "09:30",
            "6. marketClose": "16:00",
            "7. timezone": "UTC-04",
            "8. currency": "USD",
            "9. matchScore": "0.8571"
        },
        {
            "1. symbol": "IBMN",
            "2. name": "iShares iBonds Dec 2025 Term Muni Bond ETF",
            "3. type": "ETF",
            "4. region": "United States",
            "5. marketOpen": "09:30",
            "6. marketClose": "16:00",
            "7. timezone": "UTC-04",
            "8. currency": "USD",
            "9. matchScore": "0.8571"
        },
        {
            "1. symbol": "IBMO",
            "2. name": "iShares iBonds Dec 2026 Term Muni Bond ETF",
            "3. type": "ETF",
            "4. region": "United States",
            "5. marketOpen": "09:30",
            "6. marketClose": "16:00",
            "7. timezone": "UTC-04",
            "8. currency": "USD",
            "9. matchScore": "0.8571"
        },
        {
            "1. symbol": "IBM.FRK",
            "2. name": "International Business Machines",
            "3. type": "Equity",
            "4. region": "Frankfurt",
            "5. marketOpen": "08:00",
            "6. marketClose": "20:00",
            "7. timezone": "UTC+02",
            "8. currency": "EUR",
            "9. matchScore": "0.7500"
        },
        {
            "1. symbol": "IBM.LON",
            "2. name": "International Business Machines Corporation",
            "3. type": "Equity",
            "4. region": "United Kingdom",
            "5. marketOpen": "08:00",
            "6. marketClose": "16:30",
            "7. timezone": "UTC+01",
            "8. currency": "USD",
            "9. matchScore": "0.7500"
        },
        {
            "1. symbol": "IBM.DEX",
            "2. name": "International Business Machines",
            "3. type": "Equity",
            "4. region": "XETRA",
            "5. marketOpen": "08:00",
            "6. marketClose": "20:00",
            "7. timezone": "UTC+02",
            "8. currency": "EUR",
            "9. matchScore": "0.6667"
        },
        {
            "1. symbol": "IBM0.FRK",
            "2. name": "IBM CDR",
            "3. type": "Equity",
            "4. region": "Frankfurt",
            "5. marketOpen": "08:00",
            "6. marketClose": "20:00",
            "7. timezone": "UTC+02",
            "8. currency": "EUR",
            "9. matchScore": "0.6667"
        },
        {
            "1. symbol": "IBMB34.SAO",
            "2. name": "International Business Machines Corp",
            "3. type": "Equity",
            "4. region": "Brazil/Sao Paolo",
            "5. marketOpen": "10:00",
            "6. marketClose": "17:30",
            "7. timezone": "UTC-03",
            "8. currency": "BRL",
            "9. matchScore": "0.5000"
        }
    ]"	object {System.Text.Json.JsonElement}
*/
}
