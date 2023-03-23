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
using System.Globalization;
using System.Collections;

namespace FinancialManagerLibrary.UI.Controllers
{
    public class ReportController : IReportController
    {
        IncomeRepository incomeRepository;
        IController incomeController;
        IController expenseController;
        IController investmentController;

        public ReportController() 
        {
            incomeRepository = new IncomeRepository();
            expenseController= new ExpenseController();
            investmentController= new InvestmentController();

            incomeController = ControllerFactory.GetController("Income");
            expenseController = ControllerFactory.GetController("Expense");
            investmentController = ControllerFactory.GetController("Investment");
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
                

        public List<Income> GetIncomeByDateRange(string reportType, string start, string end, long userId)
        {
            List<Income> allIncome = (List<Income>)incomeController.GetAll(userId);
            var orderedList = allIncome.OrderByDescending(x => DateTime.Parse(x.Date)).ToList();
            List<Income> filteredList = new List<Income>();

            foreach (var income in orderedList) 
            {
                // make sure the date is within our filter range
                if (DateTime.Compare(DateTime.Parse(income.Date), DateTime.Parse(start)) >= 0 &&
                    DateTime.Compare(DateTime.Parse(income.Date), DateTime.Parse(end)) <= 0)
                {
                    filteredList.Add(income);
                }
            }

            return filteredList;
        }

        public List<Expense> GetExpensesByDateRange(string reportType, string start, string end, long userId)
        {
            List<Expense> allExpenses = (List<Expense>)expenseController.GetAll(userId);

            // return an empty list if there is nothing to report
            if (allExpenses.Count == 0)
                return new List<Expense>();

            var orderedList = allExpenses.OrderByDescending(x => DateTime.Parse(x.Date)).ToList();
            List<Expense> filteredList = new List<Expense>();

            foreach (var expense in orderedList)
            {
                // make sure the date is within our filter range
                if (DateTime.Compare(DateTime.Parse(expense.Date), DateTime.Parse(start)) >= 0 &&
                    DateTime.Compare(DateTime.Parse(expense.Date), DateTime.Parse(end)) <= 0)
                {
                    filteredList.Add(expense);
                }
            }

            return filteredList;
        }

        public List<Investment> GetInvestmentsByDateRange(string reportType, string start, string end, long userId)
        {
            List<Investment> allInvestments = (List<Investment>)investmentController.GetAll(userId);
            var orderedList = allInvestments.OrderByDescending(x => DateTime.Parse(x.Date)).ToList();
            List<Investment> filteredList = new List<Investment>();

            foreach (var investment in orderedList)
            {
                // make sure the date is within our filter range
                if (DateTime.Compare(DateTime.Parse(investment.Date), DateTime.Parse(start)) >= 0 &&
                    DateTime.Compare(DateTime.Parse(investment.Date), DateTime.Parse(end)) <= 0)
                {
                    filteredList.Add(investment);
                }
            }

            return filteredList;
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

        public List<Income> GetIncomeByDateRange(long userId)
        {
            throw new NotImplementedException();
        }

        public List<Expense> GetExpensesByDateRange(long userId)
        {
            throw new NotImplementedException();
        }

        public List<Investment> GetInvestmentsByDateRange(long userId)
        {
            throw new NotImplementedException();
        }
    }
}
