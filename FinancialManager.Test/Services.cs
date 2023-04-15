using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialManagerLibrary.Services;

namespace FinancialManager.Test
{
    [TestClass]
    public class Services
    {
        [TestMethod]
        public void GetAllConfigurations()
        {
            Assert.IsNotNull(ConfigurationService.GetInstance.GetAllConfigItems());
        }

        [TestMethod]
        public void GetLogLocation()
        {
            Assert.IsNotNull(ConfigurationService.GetInstance.GetAllConfigItems().Get("LogLocation"));
        }
        [TestMethod]
        public void GetLogLocationFail()
        {
            Assert.IsNull(ConfigurationService.GetInstance.GetAllConfigItems().Get("LogLocationFail"));
        }

        [TestMethod]
        public void GetDatabaseLocation()
        {
            Assert.IsNotNull(ConfigurationService.GetInstance.GetAllConfigItems().Get("Database"));
        }

        [TestMethod]
        public void GetDatabaseLocationFail()
        {
            Assert.IsNull(ConfigurationService.GetInstance.GetAllConfigItems().Get("Databasefail"));
        }

        [TestMethod]
        public void LogMessageSuccess()
        {
            LoggingService.GetInstance.Log("Testing 123");
        }

        [TestMethod]
        public void ReadLogs()
        {
            Assert.IsNotNull(LoggingService.GetInstance.ReadFromFile());
        }

        [TestMethod]
        public void GetActiveInvestmentNotificationSuccess()
        {
            NotificationService ns = new NotificationService();
            Assert.IsNotNull(ns.GetActiveInvestmentNotification(39));
        }

        [TestMethod]
        public void GetActiveInvestmentNotificationInvalidId()
        {
            NotificationService ns = new NotificationService();
            Assert.IsNull(ns.GetActiveInvestmentNotification(0));
        }

        [TestMethod]
        public void GetAllActiveNotifications()
        {
            NotificationService ns = new NotificationService();
            Assert.IsNotNull(ns.GetAllActiveNotifications());
        }
    }
}
