using FinancialManager.UI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.UI.Models
{
    public abstract class BaseReport 
    {
        private ReportController controller;

        public BaseReport(ReportController controller) { this.controller = controller; }

        public ReportController Controller { get { return controller;} }
    }
}
