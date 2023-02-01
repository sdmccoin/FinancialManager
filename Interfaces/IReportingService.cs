using FinancialManager.Services;
using FinancialManager.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Interfaces
{
    public interface IReportingService
    {
        double GetMonthlyIncome(long userId);
        double GetYearlyIncome(long userId);    
        double GetMonthlyExpenses(long userId);
        double GetYearlyExpenses(long userId);
    }
}
