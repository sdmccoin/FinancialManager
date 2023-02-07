using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialManager.UI.Controls;

namespace FinancialManager.UI
{
    public partial class NotificationFormPopup : Form
    {
        int typeId;
        ReminderType reminderType;

        public NotificationFormPopup()
        {
            InitializeComponent();
        }
        public NotificationFormPopup(ReminderType rType, int typeId)
        {
            InitializeComponent();
            reminderType = rType;
            this.typeId= typeId;
        }

        private void NotificationFormPopup_Load(object sender, EventArgs e)
        {
            pnlMain.Controls.Add(new ucReminderForm(reminderType, typeId));
            //this.Height = 465;
        }

        private void cbxReminder_CheckedChanged(object sender, EventArgs e)
        {
            //pnlMain.Controls.Clear();
            //if (cbxReminder.Checked)
            //{
            //    cbxNotification.Checked = false;
            //    pnlMain.Controls.Add(new ucReminderForm(incomeId));
            //    this.Height = 1315;
            //}
            //else
            //{
            //    pnlMain.Controls.Clear();
            //    this.Height = 465;
            //}
        }

        private void cbxNotification_CheckedChanged(object sender, EventArgs e)
        {
            //pnlMain.Controls.Clear();
            //if (cbxNotification.Checked)
            //{
            //    cbxReminder.Checked = false;
            //    pnlMain.Controls.Add(new ucNotificationForm());
            //    this.Height = 1315;
            //}
            //else
            //{
            //    pnlMain.Controls.Clear();
            //    this.Height = 465;
            //}
        }        
    }
}