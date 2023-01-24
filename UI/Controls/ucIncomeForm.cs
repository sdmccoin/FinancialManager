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

namespace FinancialManager.UI.Controls
{
    public partial class ucIncomeForm : UserControl
    {
        public ucIncomeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucIncomeForm_Load(object sender, EventArgs e)
        {
            LoadIncome();

            // delegate to clear the form after .1 seconds 
            Action clear = () => ClearForm();
            DelayMilliseconds(100, clear);    
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

     

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var button = groupBox1.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
            IncomeRepository<Income> incomeRepository = new IncomeRepository<Income>();
            Income income = new Income() { 
                Source = txtName.Text, 
                Amount = txtAmount.Text,
                Address = txtAddress1.Text,
                Frequency = button.Text};

            Income existingIncome = incomeRepository.GetByEntity(income);

            // make sure the entry doesn't already exist
            if (existingIncome == null)
            {
                incomeRepository.Create(income);
                LoadIncome();
            }
        }

        private void LoadIncome()
        {
            IncomeRepository<Income> incomeRepository = new IncomeRepository<Income>();
            IEnumerable<Income> incomes = incomeRepository.GetAllEntities();
           // dgvIncome.Rows.Clear();
            dgvIncome.AutoSize = true;
            dgvIncome.DataSource = incomes;
        }

        private void dgvIncome_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvIncome.SelectedRows)
            {
                LoadRowSelection(row);
            }
        }

        private void LoadRowSelection(DataGridViewRow row)
        {
            txtName.Text = row.Cells[1].Value.ToString();
            txtAddress1.Text = row.Cells[3].Value.ToString();
            txtAmount.Text = row.Cells[2].Value.ToString();

            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is RadioButton)
                {
                    if (row.Cells[4].Value.ToString() == ((RadioButton)ctrl).Text)
                    {
                        ((RadioButton)ctrl).Checked = true;
                    }
                }
            }

        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtAmount.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            
            foreach(Control ctrl in groupBox1.Controls)
            {
                if (ctrl is RadioButton)
                    ((RadioButton)ctrl).Checked = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var button = groupBox1.Controls.OfType<RadioButton>()
                          .FirstOrDefault(n => n.Checked);
            IncomeRepository<Income> incomeRepository = new IncomeRepository<Income>();
            Income income = new Income()
            {
                Source = txtName.Text,
                Amount = txtAmount.Text,
                Address = txtAddress1.Text,
                Frequency = button.Text
            };

            try
            {
                incomeRepository.Update(income);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            LoadIncome();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private async void DelayMilliseconds(int milliseconds, Action method)
        {            
            await Task.Delay(milliseconds);
            method.Invoke();
            //ClearForm();            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var button = groupBox1.Controls.OfType<RadioButton>()
                          .FirstOrDefault(n => n.Checked);
            IncomeRepository<Income> incomeRepository = new IncomeRepository<Income>();
            Income income = new Income()
            {
                Source = txtName.Text,
                Amount = txtAmount.Text,
                Address = txtAddress1.Text,
                Frequency = button.Text,
                Id = long.Parse(dgvIncome.SelectedRows[0].Cells[0].Value.ToString())
                
            };

            incomeRepository.Delete(income);
            LoadIncome();
        }
    }
}
