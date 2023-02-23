using FinancialManager.Data.Models;
using FinancialManager.Interfaces;
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
                        controller.Add(investment);

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
