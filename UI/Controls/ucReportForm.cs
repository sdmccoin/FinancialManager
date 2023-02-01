using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialManager.Interfaces;
using FinancialManager.Services;
using FinancialManager.UI.Controllers;
using FinancialManager.Utilities;

namespace FinancialManager.UI.Controls
{
    public partial class ucReportForm : UserControl
    {
        IController controller;
        IReportingService reportingService;

        public ucReportForm()
        {
            InitializeComponent();
            controller = ControllerFactory.GetController("Reports");
            reportingService = new ReportingService();
        }

        private void ucReportForm_Load(object sender, EventArgs e)
        {
            lblMonthlyIncome.Text = string.Format("{0:C}", reportingService.GetMonthlyIncome(ActiveUser.id));
            lblYearlyIncome.Text = string.Format("{0:C}", reportingService.GetYearlyIncome(ActiveUser.id));
            lblMonthlyExpenses.Text = string.Format("{0:C}", reportingService.GetMonthlyExpenses(ActiveUser.id));
            lblYearlyExpenses.Text = string.Format("{0:C}", reportingService.GetYearlyExpenses(ActiveUser.id));
        }


    }
}
