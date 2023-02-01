using FinancialManager.Data.Interfaces;
using FinancialManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.UI.Controllers
{
    public static class ControllerFactory 
    {
        public static IController GetController(string controller)
        {
            switch (controller)
            {
                case "Income":
                    return new IncomeController();
                    break;
                case "Expense":
                    return new ExpenseController();
                    break;
                case "Investment":
                    return new InvestmentController();
                    break;
                case "Reports":
                    return new ReportController();
                    break;
                default:
                    return null;
                    break;

            }
        }
    }
}
