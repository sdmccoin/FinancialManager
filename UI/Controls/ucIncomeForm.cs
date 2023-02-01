using FinancialManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialManager.Data.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using FinancialManager.Utilities;
using FinancialManager.UI.Controllers;
using FinancialManager.UI;
using FinancialManager.Interfaces;
using FinancialManager.Data.Interfaces;

namespace FinancialManager.UI.Controls
{
    public partial class ucIncomeForm : UserControl
    {
        IController controller;

        public ucIncomeForm()
        {
            InitializeComponent();

            // user a factory pattern to get an income controller
            controller = ControllerFactory.GetController("Income");
        }
              
        private void ucIncomeForm_Load(object sender, EventArgs e)
        {
            LoadIncome();

            // delegate to clear the form after .1 seconds 
            Action clear = () => ClearForm();
            DelayMilliseconds(100, clear);    
        }
          
      
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Income income = new Income()
                {
                    Source = txtName.Text,
                    Amount = txtAmount.Text,
                    Address = txtAddress1.Text,
                    Frequency = Utilities.GetSelectedRadioButton(groupBox1).Text,
                    UserId = ActiveUser.id
                };

                // make sure the entry doesn't already exist
                if (controller.Exists(income) == null)
                {
                    controller.Add(income);
                    LoadIncome();

                    MessageBox.Show("Income Added", "Success");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to Add Income", "Failed", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void LoadIncome()
        {
            dgvIncome.AutoSize = true;
            dgvIncome.DataSource = controller.GetAll(ActiveUser.id);//.GetIncome;
        }

        private void dgvIncome_SelectionChanged(object sender, EventArgs e)
        {
            LoadRowSelection(Utilities.GetSelectedRow(dgvIncome));           
        }

        private void LoadRowSelection(DataGridViewRow row)
        {
            if (row != null)
            {
                txtName.Text = row.Cells[1].Value.ToString();
                txtAddress1.Text = row.Cells[3].Value.ToString();
                txtAmount.Text = row.Cells[2].Value.ToString();

                Utilities.SelectRadioButton(groupBox1, row.Cells[4].Value.ToString());
            }
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtAmount.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";

            Utilities.UnSelectAllRadioButtons(groupBox1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Income income = new Income()
                {
                    Source = txtName.Text,
                    Amount = txtAmount.Text,
                    Address = txtAddress1.Text,
                    Frequency = Utilities.GetSelectedRadioButton(groupBox1).Text,
                    Id = long.Parse(Utilities.GetSelectedRowCell(dgvIncome,0).Value.ToString()),
                    UserId = ActiveUser.id
                };

                controller.Update(income);
                LoadIncome();

                MessageBox.Show("Income Updated", "Success");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Unable to Update Income", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private async void DelayMilliseconds(int milliseconds, Action method)
        {            
            await Task.Delay(milliseconds);
            method.Invoke();         
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {            
            try
            {
                Income income = new Income()
                {
                    Source = txtName.Text,
                    Amount = txtAmount.Text,
                    Address = txtAddress1.Text,
                    Frequency = Utilities.GetSelectedRadioButton(groupBox1).Text,
                    Id = long.Parse(Utilities.GetSelectedRowCell(dgvIncome, 0).Value.ToString())
                };

                controller.Delete(income);
                LoadIncome();
                MessageBox.Show("Income Deleted", "Success");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to Delete Income", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
