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
using System.Xml.Linq;

namespace FinancialManager.UI.Controls
{
    public partial class ucInvestmentForm : UserControl
    {
        public ucInvestmentForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var button = groupBox1.Controls.OfType<RadioButton>()
                          .FirstOrDefault(n => n.Checked);
            InvestmentRepository<Investment> investmentRepository = new InvestmentRepository<Investment>();
            Investment investment = new Investment()
            {
                Source = txtName.Text,
                Amount = txtAmount.Text,
                UserId = ActiveUser.id
            };

            Investment existingInvestment = investmentRepository.GetByEntity(investment);

            // make sure the entry doesn't already exist
            if (existingInvestment == null)
            {
                investmentRepository.Create(investment);
                LoadInvestments();
            }
        }

        private void LoadInvestments()
        {
            InvestmentRepository<Investment> investmentRepository = new InvestmentRepository<Investment>();
            IEnumerable<Investment> investments = investmentRepository.GetAllEntities();
            dgvInvestments.AutoSize = true;
            dgvInvestments.DataSource = investments;
        }

        private void ucInvestmentForm_Load(object sender, EventArgs e)
        {
            LoadInvestments();
        }
    }
}
