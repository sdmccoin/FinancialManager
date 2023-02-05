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
using FinancialManager.Data.Models;
using FinancialManager.Data.Repositories;

namespace FinancialManager.UI.Controls
{
    public partial class ucAccountForm : UserControl
    {
        public ucAccountForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UserRepository<User> userRepository = new UserRepository<User>();
            User user = new User() { Password = txtPassword.Text, UserName = txtUsername.Text };

            User u =userRepository.GetByEntity(user);
          
            if (u == null)
            {
                userRepository.Create(user);
                lblMessage.Text = "User Created Successfully";
            }
            else
            {
                lblMessage.Text = "Unable to Create Account";
            }
           
        }
    }
}
