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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinancialManager.UI.Controls
{
    public partial class ucInvestmentForm : UserControl
    {
        IController controller;

        public ucInvestmentForm()
        {
            InitializeComponent();

            // use a factory pattern to get an income controller
            controller = ControllerFactory.GetController("Investment");
        }

        #region UI Event(s)
        private void ucInvestmentForm_Load(object sender, EventArgs e)
        {
            LoadInvestments();

            // delegate to clear the form after .1 seconds 
            Action clear = () => ClearForm();
            DelayMilliseconds(100, clear);
        }
        private void dgvInvestments_SelectionChanged(object sender, EventArgs e)
        {            
            LoadRowSelection(Utilities.GetSelectedRow(dgvInvestments));            
        }
        #endregion

        #region CRUD Operations
        private void LoadInvestments()
        {
            dgvInvestments.AutoSize = true;
            dgvInvestments.DataSource = controller.GetAll(ActiveUser.id);
        }
        private void btnInsert_Click(object sender, EventArgs e)
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
                    LoadInvestments();

                    MessageBox.Show("Investment Added", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Add Investment", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                    UserId= ActiveUser.id

                };

                controller.Update(investment);
                LoadInvestments();

                MessageBox.Show("Investment Updated", "Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Unable to Update Investment", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                    UserId= ActiveUser.id
                };

                controller.Delete(investment);
                LoadInvestments();

                MessageBox.Show("Investment Deleted", "Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Unable to Delete Investment", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        #endregion
                 
    }
}
