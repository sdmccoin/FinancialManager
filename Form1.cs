using FinancialManager.UI.Controls;
using FinancialManager.Data.Repositories;
using FinancialManager.Data.Models;
using FinancialManager.Extensions;

namespace FinancialManager
{  

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //UserRepository<User> userRepository = new UserRepository<User>();
            //User user = userRepository.GetById(1);
            Login login = new Login();
            login.ShowDialog();
                
        }

        private void tsBtnIncome_Click(object sender, EventArgs e)
        {
            ClearMain();
            pnlMain.Controls.Add(new ucIncomeForm());
        }

        private void ClearMain()
        {
            pnlMain.Controls.Clear();
        }

        private void txBtnExpense_Click(object sender, EventArgs e)
        {
            ClearMain();
            pnlMain.Controls.Add(new ucExpenseForm());

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new User Account
            ClearMain();
            pnlMain.Controls.Add(new ucAccountForm());
        }

        private void tsBtnInvestments_Click(object sender, EventArgs e)
        {
            ClearMain();
            pnlMain.Controls.Add(new ucInvestmentForm());
        }
    }
    // admin - Pa$$word1 - DB
    // root - flannelman
    
}