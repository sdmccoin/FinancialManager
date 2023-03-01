using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialManager.Data.Interfaces;
using FinancialManager.Data.Models;
using FinancialManager.Interfaces;
using FinancialManager.Services;
using FinancialManager.UI.Controllers;
using FinancialManager.UI.Models;
using FinancialManager.Utilities;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinancialManager.UI.Controls
{
    public partial class ucReportForm : UserControl
    {
        ReportController controller;
        IReport report;

        public ucReportForm()
        {
            controller = new ReportController();
            InitializeComponent();            
        }

        private void LoadReportData()
        {
            report.StartDate = dtpStart.Text;
            report.EndDate = dtpEnd.Text;
            report.ReportType = Utilities.GetSelectedRadioButton(gbxReportType).Text;
            report.Generate();
        }

        private void ucReportForm_Load(object sender, EventArgs e)
        {
            wvReportView.Visible = false;
            lblMonthlyIncome.Text = string.Format("{0:C}", controller.GetMonthlyIncome(ActiveUser.id));
            lblYearlyIncome.Text = string.Format("{0:C}", controller.GetYearlyIncome(ActiveUser.id));
            lblMonthlyExpenses.Text = string.Format("{0:C}", controller.GetMonthlyExpenses(ActiveUser.id));
            lblYearlyExpenses.Text = string.Format("{0:C}", controller.GetYearlyExpenses(ActiveUser.id));
        }

        private void tsddIncomeMonthly_Click(object sender, EventArgs e)
        {          

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (FormIsValid(ref errorMessage))
            {
                switch (Utilities.GetSelectedRadioButton(gbxReportType).Text)
                {
                    case "Income":
                        report = ReportFactory.GetReport("Income");
                        break;
                    case "Expense":
                        report = ReportFactory.GetReport("Expense");
                        break;
                    case "Investment":
                        report = ReportFactory.GetReport("Investment");
                        break;
                }
                
                LoadReportData();
                DisplayReport();
                wvReportView.Visible = true;
            }
            else
            {
                MessageBox.Show(errorMessage, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool FormIsValid(ref string errorMessage)
        {
            bool isValid = true;

            if (Utilities.GetSelectedRadioButton(gbxReportType) == null)
            {
                errorMessage += " - You must select a report type\r\n";
                return false;
            }

            return isValid;
        }

        private void DisplayReport()
        {
            wvReportView.CoreWebView2.NavigateToString(report.ToString());          
        }
    }
}
