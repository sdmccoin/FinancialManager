using FinancialManager.Data.Models;
using FinancialManager.Data.Repositories;
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

namespace FinancialManager.UI.Controls
{
    public partial class ucExpenseForm : UserControl
    {
        public ucExpenseForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var button = groupBox1.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
            ExpenseRepository<Expense> expenseRepository = new ExpenseRepository<Expense>();
            Expense expense = new Expense()
            {
                Source = txtName.Text,
                Amount = txtAmount.Text,
                Address = txtAddress1.Text,
                Frequency = button.Text,
                UserId = ActiveUser.id
            };

            Expense existingExpense = expenseRepository.GetByEntity(expense);

            // make sure the entry doesn't already exist
            if (existingExpense == null)
            {
                expenseRepository.Create(expense);
                LoadExpenses();
            }
        }

        private void LoadExpenses()
        {
            ExpenseRepository<Expense> expenseRepository = new ExpenseRepository<Expense>();
            IEnumerable<Expense> expenses = expenseRepository.GetAllEntities();
            dgvExpenses.AutoSize = true;
            dgvExpenses.DataSource = expenses;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucExpenseForm_Load(object sender, EventArgs e)
        {
            LoadExpenses();
        }
    }
}
