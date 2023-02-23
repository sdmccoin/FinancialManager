using FinancialManager.UI.Controls;
using FinancialManager.Data.Repositories;
using FinancialManager.Data.Models;
using FinancialManager.Extensions;
using FinancialManager.Utilities;

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
            Login login = new Login();
            login.ShowDialog();

            // ensure only authenticated users can use the system
            if (ActiveUser.id < 0)
                this.Close();
            else if (ActiveUser.id == 0)
            {
                DisableUI();
            }
                
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

        private void DisableUI()
        {
            toolStrip1.Enabled = false;
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                DisableMenuItems(item);
            }
        }

        /// <summary>
        /// Recursive method used to disable all menu items
        /// </summary>
        /// <param name="item"></param>
        private void DisableMenuItems(ToolStripMenuItem item)
        {
            // enable only account creation for admin account
            if (item.Text == "File" || item.Text == "New" || item.Text == "Account")
                item.Enabled = true;
            else
                item.Enabled = false;

        
            foreach (ToolStripItem i in item.DropDownItems)
            {
                if (i is ToolStripMenuItem)
                {
                    DisableMenuItems((ToolStripMenuItem)i);
                }
            }
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

        private void tsBtnReports_Click(object sender, EventArgs e)
        {
            ClearMain();
            pnlMain.Controls.Add(new ucReportForm());
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearMain();
            pnlMain.Controls.Add(new ucSettingsForm());
        }
    }
    // admin - Pa$$word1 - DB
    // root - flannelman
    
}