using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.UI.Controllers;
using FinancialManagerLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Services
{
    public class NotificationService
    {
        IController investmentNotificationController;
        IController settingsController;

        public NotificationService()
        {
            investmentNotificationController = ControllerFactory.GetController("InvestmentNotification");
            settingsController = ControllerFactory.GetController("Settings");
        }

        public InvestmentNotification GetActiveInvestmentNotification(int investmentId)
        {
            // call the link table to get the reminder id based on income id
            InvestmentNotification investmentNotification = (InvestmentNotification)investmentNotificationController.GetById(investmentId);

            if (investmentNotification == null)
                return null;


            // get the alert window
            long alertWindow = ((List<Setting>)settingsController.GetAll(ActiveUser.id)).FirstOrDefault().AlertWindowDays;

            // only load if they match our date window
            if (DateTime.Compare(DateTime.Parse(investmentNotification.Date), DateTime.Now) <= 0 &&
                DateTime.Compare(DateTime.Parse(investmentNotification.Date), DateTime.Now.AddDays(alertWindow)) <= 0)
            {
                return investmentNotification;
            }
            else
            {
                return null;
            }
        }

        public List<InvestmentNotification> GetAllActiveNotifications()
        {
            List<InvestmentNotification> notificationList = (List<InvestmentNotification>)investmentNotificationController.GetAll(ActiveUser.id);
            var orderedList = notificationList.OrderByDescending(x => DateTime.Parse(x.Date)).ToList();
            List<InvestmentNotification> filteredList = new List<InvestmentNotification>();

            // get the alert window
            long alertWindow = ((List<Setting>)settingsController.GetAll(ActiveUser.id)).FirstOrDefault().AlertWindowDays;

            foreach (InvestmentNotification notification in orderedList)
            {
                // make sure the reminder date is earlier than the current date/time and within 1 day of
                // predefined limit (i.e., 1 day)
                if (DateTime.Compare(DateTime.Parse(notification.Date), DateTime.Now) <= 0 &&
                   DateTime.Compare(DateTime.Parse(notification.Date), DateTime.Now.AddDays(alertWindow)) <= 0)
                {
                    if (notification.Enabled == 1)
                        filteredList.Add(notification);
                }
            }

            return filteredList;
        }
    }
}
