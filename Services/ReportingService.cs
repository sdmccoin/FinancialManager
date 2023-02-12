using FinancialManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialManager.Data.Models;
using Microsoft.VisualBasic.ApplicationServices;
using FinancialManager.Interfaces;
using FinancialManager.Data.Interfaces;

namespace FinancialManager.Services
{
    public class ReportingService// : IReportingService
    {
        IncomeRepository incomeRepository;

        public ReportingService()
        {
            incomeRepository = new IncomeRepository();
        }
        public double GetYearlyExpenses(long userId)
        {
            return CalculateTotalExpenses(userId, "Yearly");
        }

        public double GetMonthlyExpenses(long userId)
        {
            return CalculateTotalExpenses(userId, "Monthly");
        }

        public double GetYearlyIncome(long userId)
        {
            return CalculateTotalIncome(userId, "Yearly");
        }

        public double GetMonthlyIncome(long userId)
        {
            return CalculateTotalIncome(userId, "Monthly");
        }

        private double CalculateTotalIncome(long userId, string frequency)
        {
            return incomeRepository.TotalIncome(userId, frequency);
        }

        private double CalculateTotalExpenses(long userId, string frequency)
        {
            return incomeRepository.TotalExpenses(userId, frequency);
        }
    }
}
