using FinancialManager.Data.Models;
using FinancialManager.Interfaces;
using FinancialManager.UI.Controllers;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml.Linq;
using System.Net.Mail;
using System.Net;

namespace FinancialManager.UI.Controls
{
    public partial class ucSettingsForm : UserControl
    {
        IController settingsController;
        public ucSettingsForm()
        {
            InitializeComponent();
            settingsController = ControllerFactory.GetController("Settings");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NotifyIcon trayIcon = new NotifyIcon();
            trayIcon.Icon = SystemIcons.Information;
            trayIcon.Text = "New message";
            trayIcon.Visible = true;
            trayIcon.ShowBalloonTip(5000, "Information", "A new message received!", ToolTipIcon.Info);
            //var smtpClient = new SmtpClient("smtp.psu.com")
            //{
            //    Port = 587,
            //    Credentials = new NetworkCredential("sdm283@psu.edu", "Flannelman11"),
            //    EnableSsl = true,
            //};
            //var mailMessage = new MailMessage
            //{
            //    From = new MailAddress("mccoin6@gmail.com"),
            //    Subject = "Just a test",
            //    Body = "<h1>Hello</h1>",
            //    IsBodyHtml = true,
            //};
            //mailMessage.To.Add("mccoin4321@gmail.com");

            //smtpClient.Send(mailMessage);
            //string errorMessage = "";
            //if (FormIsValid(ref errorMessage))
            //{
            //    try
            //    {
            //        Setting setting = new Setting()
            //        {
            //            EmailAddress = txtEmailAddress.Text,
            //            Phone = txtPhone.Text,
            //            UserId = ActiveUser.id
            //        };

            //        // make sure the entry doesn't already exist
            //        if (settingsController.Exists(setting) == null)
            //        {
            //            settingsController.Add(setting);
            //            MessageBox.Show("Settings Added", "Success");                        
            //        }
            //        else
            //        {
            //            MessageBox.Show("Already Exists", "Failed");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Unable to Add Settings", "Failed",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show(errorMessage, "Error",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private bool FormIsValid(ref string errorMessage)
        {
            bool isValid = false;

            if (Utilities.IsEmpty(txtEmailAddress))
                errorMessage += " - Email Address cannot be blank\r\n";
            if (Utilities.IsEmpty(txtPhone))
                errorMessage += " - Phone cannot be blank\r\n";            

            if (errorMessage == "")
                isValid = true;

            return isValid;
        }
    }
}
