﻿using FinancialManagerLibrary.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Utilities;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.UI.Controllers;

namespace FinancialManager
{
    public partial class Login : Form
    {
        int attempts;
        IController controller;

        public Login()
        {
            InitializeComponent();

            controller = ControllerFactory.GetController("User");
            attempts = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblLoginMessage.Text = "";
            attempts++;
            UserRepository<User> userRepository = new UserRepository<User>();

            try
            {
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
                    lblLoginMessage.Text = "Login Failed (Attempt " + attempts + " of 3)";

                    if (attempts >= 3) Application.Exit();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
           
        }
    }
}
