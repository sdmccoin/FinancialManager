using FinancialManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Interfaces
{
    public interface IReportController : IController
    {
        List<Income> GetIncomeByDateRange(long userId);
        List<Expense> GetExpensesByDateRange(long userId);
        List<Investment> GetInvestmentsByDateRange(long userId);
    }
}
