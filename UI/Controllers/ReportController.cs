using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Data.Repositories;
using FinancialManagerLibrary.Data.Interfaces;
using FinancialManagerLibrary.Utilities;
using FinancialManagerLibrary.Services;
using FinancialManagerLibrary.Interfaces;

namespace FinancialManager.UI.Controllers
{
    public class ReportController : IReportController
    {
        IncomeRepository incomeRepository;

        public ReportController() 
        {
            incomeRepository = new IncomeRepository();
        }

        public IEntity Add(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEntity Exists(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEntity> GetAll(long userId)
        {
            throw new NotImplementedException();
        }

        public IEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<Income> GetIncomeByDateRange(long userId)
        {
            List<Income> entities = new List<Income>();

            using (var context = new FinancialManagerContext())
            {
                entities = context.Incomes.Where(u => (u.UserId == userId)).ToList<Income>();
            }

            return entities;
        }

        public List<Expense> GetExpensesByDateRange(long userId)
        {
            List<Expense> entities = new List<Expense>();

            using (var context = new FinancialManagerContext())
            {
                entities = context.Expenses.Where(u => (u.UserId == userId)).ToList<Expense>();
            }

            return entities;
        }

        public List<Investment> GetInvestmentsByDateRange(long userId)
        {
            List<Investment> entities = new List<Investment>();

            using (var context = new FinancialManagerContext())
            {
                entities = context.Investments.Where(u => (u.UserId == userId)).ToList<Investment>();
            }

            return entities;
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

        private Income ConvertEntity(IEntity entity)
        {
            return (Income)Convert.ChangeType(entity, typeof(Income));
        }

       
    }
}
