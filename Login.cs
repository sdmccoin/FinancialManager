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
using FinancialManager.Utilities;

namespace FinancialManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblLoginMessage.Text = "";
            UserRepository<User> userRepository = new UserRepository<User>();
            User user = userRepository.GetByEntity(
                new User() { UserName = txtUserName.Text, Password = txtPassword.Text });

            if (user != null)
            {
                Console.WriteLine("continue");
                ActiveUser.id = user.Id;
                this.Close();
            }
            else
            {
                Console.WriteLine("Failed to Login");
                lblLoginMessage.Text = "Login Failed";
            }
        }
    }
}
