using FinancialManager.Data.Models;
using FinancialManager.Interfaces;
using FinancialManager.Services;
using FinancialManager.Services.Models;
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

namespace FinancialManager.UI
{
    public partial class AddInvestmentPopup : Form
    {
        private string source;
        private IController stockAnalyzerController;
        private IController notificationController;

        public AddInvestmentPopup(string source)
        {
            InitializeComponent();
            this.source = source;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            IController controller;
           
            string errorMessage = "";
            if (FormIsValid(ref errorMessage))
            {
                controller = ControllerFactory.GetController("Investment");

                try
                {
                    Investment investment = new Investment()
                    {
                        Amount = txtAmount.Text,
                        Source = source,
                        Type = "Stock",
                        UserId = ActiveUser.id,
                        Frequency = Utilities.GetSelectedRadioButton(gbxFrequency).Text
                    };

                    if (controller.Exists(investment) == null)
                    {
                        // add the investment
                        controller.Add(investment);

                        // load stock analyzer table
                        var t = Task.Run(() => {
                            GetStockDataForML();
                        });
                        t.Wait();

                        MessageBox.Show("Investment Added", "Success");
                    }
                } 
                catch(Exception ex)
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

        private void GetStockDataForML()
        {
            StockService ss = new StockService();
            StockDailiesResponse dailyResponse = new StockDailiesResponse();
            string stockDailyUrl = API.StockSearchDailies + source + "&apikey=" + API.StockKey;

            ss.URL = stockDailyUrl;
            dailyResponse = ss.GetAsync<StockDailiesResponse>();
            Dictionary<string, string> closingValues = new Dictionary<string, string>();

            if (dailyResponse != null)
            {
                if (dailyResponse.Dailies != null)
                {
                    foreach (KeyValuePair<string,Dailies> daily in dailyResponse.Dailies)
                    {
                        closingValues.Add(daily.Key, daily.Value.Close);
                    }

                    LoadAnalyzerTable(closingValues);
                }
            }
        }
        private void LoadAnalyzerTable(Dictionary<string, string> values)
        {
            stockAnalyzerController = ControllerFactory.GetController("StockAnalysis");
            StockAnalysis stockAnalysis;

            foreach (KeyValuePair<string,string> value in values)
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

        private void cbxMonitor_CheckedChanged(object sender, EventArgs e)
        {
            ToggleFrequency();
        }

        private bool FormIsValid(ref string errorMessage)
        {
            bool isValid = false;

            if (cbxMonitor.Checked)
            {
                if (Utilities.GetSelectedRadioButton(gbxFrequency) == null)
                    errorMessage += " - You must select a frequency\r\n";
            }
            else
            {
                if (Utilities.IsEmpty(txtAmount))
                    errorMessage += " - Amount cannot be blank\r\n";
                if (Utilities.IsValidCurrency(txtAmount) == false)
                    errorMessage += " - Invalid Amount\r\n";
            }
            
            if (errorMessage == "")
                isValid = true;

            return isValid;
        }

        private void ToggleFrequency()
        {
            if (cbxMonitor.Checked)
                gbxFrequency.Enabled = false;
            else
                gbxFrequency.Enabled = true;
        }

        private void AddInvestmentPopup_Load(object sender, EventArgs e)
        {
            ToggleFrequency();
        }
    }
}
