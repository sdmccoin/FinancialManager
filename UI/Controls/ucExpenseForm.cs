using FinancialManager.Data.Models;
using FinancialManager.Data.Repositories;
using FinancialManager.Utilities;
using FinancialManager.UI.Controllers;
using FinancialManager.UI;
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

namespace FinancialManager.UI.Controls
{
    public partial class ucExpenseForm : UserControl
    {
        IController controller;

        public ucExpenseForm()
        {
            InitializeComponent();

            // use a factory pattern to get an income controller
            controller = ControllerFactory.GetController("Expense");
        }
              
        #region CRUD Operations
        private void LoadExpenses()
        {      
            dgvExpenses.AutoSize = true;
            dgvExpenses.DataSource = controller.GetAll(ActiveUser.id);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Expense expense = new Expense()
                {
                    Source = txtName.Text,
                    Amount = txtAmount.Text,
                    Address = txtAddress1.Text,
                    Frequency = Utilities.GetSelectedRadioButton(groupBox1).Text,
                    UserId = ActiveUser.id
                };

                // make sure the entry doesn't already exist
                if (controller.Exists(expense) == null)
                {
                    controller.Add(expense);
                    LoadExpenses();

                    MessageBox.Show("Income Added", "Success");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Unable to Add Income", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {                                              
                Expense expense = new Expense()
                {
                    Source = txtName.Text,
                    Amount = txtAmount.Text,
                    Address = txtAddress1.Text,
                    Frequency = Utilities.GetSelectedRadioButton(groupBox1).Text,
                    Id = long.Parse(Utilities.GetSelectedRowCell(dgvExpenses, 0).Value.ToString()),
                    UserId = ActiveUser.id
                };

                controller.Update(expense);
                MessageBox.Show("Expense Updated", "Success");
                
                LoadExpenses();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Unable to Update Expense", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {                               
                Expense expense = new Expense()
                {
                    Source = txtName.Text,
                    Amount = txtAmount.Text,
                    Address = txtAddress1.Text,
                    Frequency = Utilities.GetSelectedRadioButton(groupBox1).Text,
                    Id = long.Parse(Utilities.GetSelectedRowCell(dgvExpenses, 0).Value.ToString()),
                    UserId = ActiveUser.id
                };                

                controller.Delete(expense);
                LoadExpenses();

                MessageBox.Show("Expense Deleted", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Delete Expense", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Private Methods
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

        
        #endregion

        private void ucExpenseForm_Load(object sender, EventArgs e)
        {
            LoadExpenses();

            // delegate to clear the form after .1 seconds 
            Action clear = () => ClearForm();
            DelayMilliseconds(100, clear);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtAmount.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";

            Utilities.UnSelectAllRadioButtons(groupBox1);
        }

        private async void DelayMilliseconds(int milliseconds, Action method)
        {
            await Task.Delay(milliseconds);
            method.Invoke();
            //ClearForm();            
        }
       

        private void dgvExpenses_SelectionChanged(object sender, EventArgs e)
        {
            LoadRowSelection(Utilities.GetSelectedRow(dgvExpenses));            
        }
    }
}
