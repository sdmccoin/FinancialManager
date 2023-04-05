using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Test
{
    [TestClass]
    public class MachineLearning
    {
        FinancialManagerLibrary.Services.MachineLearning ml;
        public MachineLearning() 
        { 
            ml = new FinancialManagerLibrary.Services.MachineLearning();
        }

        [TestMethod]
        public void RunStockAnalytics()
        {
            IEnumerable<ChartData> data = ml.RunStockAnalytics("ibm",1);
            Assert.IsNotNull(data);
        }
    }
}
