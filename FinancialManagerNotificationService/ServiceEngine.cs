using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagerNotificationService
{
    /// <summary>
    /// Service used to send email notifications
    /// </summary>
    public partial class ServiceEngine : ServiceBase
    {
        private static System.Timers.Timer timer;

        public ServiceEngine()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            ServiceLogger.Log("Start Windows Service");

            NotifyIcon trayIcon = new NotifyIcon();
            trayIcon.Icon = SystemIcons.Information;
            trayIcon.Text = "New message";
            trayIcon.Visible = true;
            trayIcon.ShowBalloonTip(5000, "Information", "A new message received!", ToolTipIcon.Info);
        }

        protected override void OnStop()
        {
            ServiceLogger.Log("Stop Windows Service");
        }
    }
}
