using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.UI.Controllers;
using FinancialManagerLibrary.Utilities;

namespace FinancialManager.Test
{
    [TestClass]
    public class Preferences
    {
        IController settingsController;

        public Preferences()
        {
            settingsController = ControllerFactory.GetController("Settings");
        }
        [TestMethod]
        public void GetMLConfidenceLevel()
        {
            Assert.IsNotNull(((Setting)settingsController.GetAll(ActiveUser.id).FirstOrDefault()).ConfidenceLevel);
        }
        [TestMethod]
        public void GetMLSeriesLength()
        {
            Assert.IsNotNull(((Setting)settingsController.GetAll(ActiveUser.id).FirstOrDefault()).PredictionTimeInterval);            
        }

        [TestMethod]
        public void GetAllUserSettings()
        {
            Assert.IsNotNull(((List<Setting>)settingsController.GetAll(ActiveUser.id)).FirstOrDefault());
        }
    }
}
