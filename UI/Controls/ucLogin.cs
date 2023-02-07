using FinancialManager.Data.Repositories;
using FinancialManager.Data.Models;
using FinancialManager.Interfaces;
using FinancialManager.UI.Controllers;

namespace FinancialManager.UI.Controls
{
    
    public partial class ucLogin : UserControl
    {
        int attempts;
        IController controller;

        public ucLogin()
        {
            InitializeComponent();
            controller = ControllerFactory.GetController("User");
            attempts = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var user = controller.Exists(
                new User() { UserName = txtUserName.Text, Password = txtPassword.Text });

            if (user != null)
            {
                Console.WriteLine("continue");
            }
            else
            {
                Console.WriteLine("Failed to Login");
                MessageBox.Show("Failed to Login");
                attempts++;

                if (attempts >= 3) Application.Exit();
            }
        }
    }
}