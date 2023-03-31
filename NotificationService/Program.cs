using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NotificationService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckNotifications();
            NotifyIcon trayIcon = new NotifyIcon();
            trayIcon.Icon = SystemIcons.Information;
            trayIcon.Text = "New message";
            trayIcon.Visible = true;
            trayIcon.ShowBalloonTip(5000, "Information", "A new message received!", ToolTipIcon.Info);
        }

        private static void CheckNotifications()
        {
            
        }
    }
}
