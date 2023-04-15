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
using FinancialManagerLibrary.Services;

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
                    LoggingService.GetInstance.Log(ex.Message);
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
                    LoggingService.GetInstance.Log(ex.Message); 
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
