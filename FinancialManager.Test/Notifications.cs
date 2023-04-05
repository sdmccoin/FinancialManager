using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.UI.Controllers;
using FinancialManagerLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Test
{
    [TestClass]
    public class Notifications
    {
        IController investmentNotificationController;
        InvestmentNotification invNotif;
        public Notifications()
        {
            InitializeComponents();           
        }

        private void InitializeComponents()
        {
            investmentNotificationController = ControllerFactory.GetController("InvestmentNotification");

            InvestmentNotification invNotif = new InvestmentNotification()
            {
                UserId = 0,
                Symbol = "IBM",
                Date = "04/05/2023",
                Message = "A new projection has been completed for your IBM stock on 04/05/2023",
                Id= 1,
                
            };
        }

        [TestMethod]
        public void Test1AddInvestmentNotification()
        {
            // if it already exists, update it, otherwise add a new one
            if (investmentNotificationController.Exists(invNotif) == null)            
                investmentNotificationController.Add(invNotif);

            Assert.IsNotNull(investmentNotificationController.Exists(invNotif));
        }

        [TestMethod]
        public void Test2UpdateInvestmentNotification()
        {
            if (investmentNotificationController.Exists(invNotif) != null)
                investmentNotificationController.Update(invNotif);

            Assert.IsNotNull(investmentNotificationController.Exists(invNotif));
        }

        [TestMethod]
        public void TestDeleteInvestmentNotification()
        {            
            if (investmentNotificationController.Exists(invNotif) != null)            
                investmentNotificationController.Delete(invNotif);

            Assert.IsNull(investmentNotificationController.Exists(invNotif));                       
        }       
    }
}
