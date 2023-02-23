using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagerNotificationService
{
    public enum TYPE { INFO, WARNING, ALERT };
    public class NotificationService : IService
    {
        public void CheckData()
        {

        }
        
        public void Send(IMessage message)
        {
            NotifyIcon trayIcon = new NotifyIcon();
            ToolTipIcon toolTipIcon = new ToolTipIcon();
            switch (message.Type)
            {
                case TYPE.INFO:
                    trayIcon.Icon = SystemIcons.Information;
                    toolTipIcon = ToolTipIcon.Info;
                    break;
                case TYPE.WARNING:
                    trayIcon.Icon = SystemIcons.Warning;
                    toolTipIcon = ToolTipIcon.Warning;
                    break;
                case TYPE.ALERT:
                    trayIcon.Icon = SystemIcons.Error;
                    toolTipIcon = ToolTipIcon.Error;
                    break;
            }

            trayIcon.Text = message.Message;
            trayIcon.Visible = true;
            trayIcon.ShowBalloonTip(5000, message.Title, message.Message, toolTipIcon);

        }
    }
}
