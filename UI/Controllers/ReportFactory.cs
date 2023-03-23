using FinancialManagerLibrary.Interfaces;
using FinancialManager.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.UI.Controllers
{
    public static class ReportFactory
    {
        public static IReport GetReport(string report)
        {
            return report switch
            {
                "Income" => new IncomeReport(),
                "Expense" => new ExpenseReport(),
                "Investment" => new InvestmentReport()                
            };
        }
    }
}
