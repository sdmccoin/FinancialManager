using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.UI.Controllers;
using FinancialManagerLibrary.Utilities;
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
using Microsoft.Win32.TaskScheduler;

namespace FinancialManager.UI.Controls
{
    public partial class ucSettingsForm : UserControl
    {
        IController settingsController;
        public ucSettingsForm()
        {
            InitializeComponent();
            settingsController = ControllerFactory.GetController("Settings");
            LoadExistingSettings();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (FormIsValid(ref errorMessage))
            {
                try
                {
                    Setting setting = new Setting()
                    {
                        ConfidenceLevel = txtConfidenceLevel.Text,
                        EmailAddress = txtEmailAddress.Text,
                        Phone = txtPhone.Text,
                        PredictionTimeInterval = long.Parse(txtTimeInterval.Text),
                        AlertWindowDays = long.Parse(txtAlertDays.Text),
                        RemindersEnabled = (rbnDisabled.Checked == true) ? 0 : 1,
                        UserId = ActiveUser.id,
                    };

                    // make sure the entry doesn't already exist
                    if (settingsController.Exists(setting) == null)
                    {
                        settingsController.Add(setting);
                        LoadExistingSettings();

                        MessageBox.Show("Settings Added", "Success");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to Add Settings", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadExistingSettings()
        {
            List<Setting> settings = (List<Setting>)settingsController.GetAll(ActiveUser.id);

            if (settings.Count > 0)
            {
                lblConfidenceLevel.Text = settings[0].ConfidenceLevel.ToString();
                lblEmail.Text = settings[0].EmailAddress;
                lblPhone.Text = settings[0].Phone;
                lblPredictionTimeInterval.Text = settings[0].PredictionTimeInterval.ToString();
                lblAlertDays.Text = settings[0].AlertWindowDays.ToString();
                lblEnabled.Text = (settings[0].RemindersEnabled == 0) ? "False" : "True";

                txtConfidenceLevel.Text = settings[0].ConfidenceLevel.ToString();
                txtEmailAddress.Text = settings[0].EmailAddress;
                txtPhone.Text = settings[0].Phone;
                txtTimeInterval.Text = settings[0].PredictionTimeInterval.ToString();
                txtAlertDays.Text = settings[0].AlertWindowDays.ToString();
                if (settings[0].RemindersEnabled == 0)
                    rbnDisabled.Checked = true;
                else
                    rbnEnabled.Checked = true;                
            }
        }
        

            // Get the service on the local machine
            //using (TaskService ts = new TaskService())
            //{
            //    if(ts.FindTask("Financial Manager Alerts and Notifications") == null)
            //    {
            //        // Create a new task definition and assign properties
            //        TaskDefinition td = ts.NewTask();
            //        td.RegistrationInfo.Description = "Financial Manager Alerts and Notifications";
                    
            //        // Create a trigger that will fire the task at this time every other day
            //        td.Triggers.Add(new DailyTrigger { DaysInterval = 2 });

            //        // Create an action that will launch Notepad whenever the trigger fires
            //        td.Actions.Add(new ExecAction("notepad.exe", "c:\\test.log", null));
            //        //td.Actions.Add(new ExecAction(CheckForNotifications());
                    
            //        // Register the task in the root folder
            //        ts.RootFolder.RegisterTaskDefinition(@"Test", td);

            //        // Remove the task we just created
            //        ts.RootFolder.DeleteTask("Test");
            //    }
                
            //}
            //NotifyIcon trayIcon = new NotifyIcon();
            //trayIcon.Icon = SystemIcons.Information;
            //trayIcon.Text = "New message";
            //trayIcon.Visible = true;
            //trayIcon.ShowBalloonTip(5000, "Information", "A new message received!", ToolTipIcon.Info);
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
        //}

        private void CheckForNotifications()
        {

        }

        private bool FormIsValid(ref string errorMessage)
        {
            bool isValid = false;

            if (Utilities.IsEmpty(txtEmailAddress))
                errorMessage += " - Email Address cannot be blank\r\n";
            if (Utilities.IsEmpty(txtPhone))
                errorMessage += " - Phone cannot be blank\r\n";
            if (Utilities.IsEmpty(txtTimeInterval))
                errorMessage += " - You Must Select a Time Interval\r\n";
            if (Utilities.IsEmpty(txtConfidenceLevel))
                errorMessage += " - You Must Select a Confidence Level\r\n";
            if (errorMessage == "")
                isValid = true;

            return isValid;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtTimeInterval.Text = trackBar1.Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAlertDays.Text = "0";
            txtConfidenceLevel.Text = "10";
            txtEmailAddress.Text = "";
            txtPhone.Text = "";
            txtTimeInterval.Text = "1";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (FormIsValid(ref errorMessage))
            {
                try
                {
                    Setting setting = new Setting()
                    {
                        ConfidenceLevel = txtConfidenceLevel.Text,
                        EmailAddress = txtEmailAddress.Text,
                        Phone = txtPhone.Text,
                        PredictionTimeInterval = long.Parse(txtTimeInterval.Text),
                        AlertWindowDays = long.Parse(txtAlertDays.Text),
                        RemindersEnabled = (rbnDisabled.Checked == true) ? 0 : 1,
                        UserId = ActiveUser.id,
                    };

                    // make sure the entry doesn't already exist
                    if (settingsController.Exists(setting) != null)
                    {
                        settingsController.Update(setting);
                        LoadExistingSettings();

                        MessageBox.Show("Settings Updated", "Success");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Unable to Update Settings", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
