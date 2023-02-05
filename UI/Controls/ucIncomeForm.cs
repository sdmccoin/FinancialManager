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
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            dgvIncome.AutoSize = true;
            dgvIncome.DataSource = incomes;
        }
    }
}
