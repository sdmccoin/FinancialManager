using FinancialManager.Data.Interfaces;
using FinancialManager.Data.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Data.Repositories
{
    public class IncomeRepository : IRepository<Income>// where T : IEntity
    {
        public Income Create(Income entity)
        {
            EntityEntry<Income> entityAdded = null;
            using (var context = new FinancialManagerContext())
            {
                entityAdded = context.Incomes.Add(entity);
                context.SaveChanges();
                
            }
            return entityAdded.Entity;
        }

        public void Delete(Income entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.Incomes.Remove(entity);
                context.SaveChanges();
            }
        }

        public Income GetById(int id)
        {
            Income? income = new Income();

            using (var context = new FinancialManagerContext())
            {
                income = context.Incomes
                                   .Where(u => u.Id == id)
                                   .FirstOrDefault<Income>();
            }
            return income;
        }

        public Income GetByEntity(Income entity)
        {
            Income? income = new Income();

            using (var context = new FinancialManagerContext())
            {
                income = context.Incomes
                                   .Where(i => (i.Source.Equals(entity.Source)) &&
                                   (i.Amount.Equals(entity.Amount)) &&
                                   (i.Address.Equals(entity.Address)) &&
                                   i.Frequency.Equals(entity.Frequency))
                                   .FirstOrDefault<Income>();
            }
            return income;
        }

        public IEnumerable<Income> GetAllEntities(long userId)
        {
            IEnumerable<Income> entities = new List<Income>();

            using (var context = new FinancialManagerContext())
            {
                entities = context.Incomes.Where(u => u.UserId == userId).ToList<Income>();
            }

            return entities;
        }

        public void Update(Income entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.Incomes.Update(entity);
                context.SaveChanges();
            }
        }

        public double TotalExpenses(long userId, string frequency)
        {
            double monthlyExpenses = 0;
            List<Expense> query = null;

            using (var context = new FinancialManagerContext())
            {
                if (frequency == "Yearly")
                {
                    query = (from expense in context.Expenses
                             where expense.UserId == userId

                             select new Expense()
                             {
                                 Amount = expense.Amount
                             }).ToList<Expense>();
                }
                else
                {
                    query = (from expense in context.Expenses
                             where expense.UserId == userId && expense.Frequency == frequency

                             select new Expense()
                             {
                                 Amount = expense.Amount
                             }).ToList<Expense>();
                }


                foreach (Expense expense in query)
                    monthlyExpenses += double.Parse(expense.Amount);

            }

            return monthlyExpenses;
        }
        public double TotalIncome(long userId, string frequency)
        {
            double monthlyIncome = 0;
            List<Income> query = null;

            using (var context = new FinancialManagerContext())
            {
                if (frequency == "Yearly")
                {
                     query = (from income in context.Incomes
                            where income.UserId == userId

                            select new Income()
                            {
                                Amount = income.Amount
                            }).ToList<Income>();
                } else
                {
                    query = (from income in context.Incomes
                            where income.UserId == userId && income.Frequency == frequency

                            select new Income()
                            {
                                Amount = income.Amount
                            }).ToList<Income>();
                }
               

                 foreach(Income income in query)                
                    monthlyIncome += double.Parse(income.Amount);
                
            }

            return monthlyIncome;
        }

        

        //public IEnumerable<T> GetAllEntities<T>(long userId)
        //{
        //    IEnumerable<Income> entities = new List<Income>();

        //    using (var context = new FinancialManagerContext())
        //    {
        //        entities = context.Incomes.Where(u => u.UserId == userId).ToList<Income>();
        //    }

        //    return (IEnumerable<T>)Convert.ChangeType(entities, typeof(T)); //entities;
        //}
        //public T GetByEntity<T>(T entity)
        //{            
        //    Income income = (Income)Convert.ChangeType(entity, typeof(Income));
        //    using (var context = new FinancialManagerContext())
        //    {
        //        income = context.Incomes
        //                           .Where(i => (i.Source.Equals(income.Source)) &&
        //                           (i.Amount.Equals(income.Amount)) &&
        //                           (i.Address.Equals(income.Address)) &&
        //                           i.Frequency.Equals(income.Frequency))
        //                           .FirstOrDefault<Income>();
        //    }
        //    return (T)Convert.ChangeType(income, typeof(T));// income;
        //}
        //public T GetById<T>(int id)
        //{
        //    Income? income = new Income();

        //    using (var context = new FinancialManagerContext())
        //    {
        //        income = context.Incomes
        //                           .Where(u => u.Id == 1)
        //                           .FirstOrDefault<Income>();
        //    }

        //    return (T)Convert.ChangeType(income, typeof(T)); //income;
        //}

        //public void Create<T>(T entity)
        //{
        //    Income data = (Income)Convert.ChangeType(entity, typeof(Income));
        //    using (var context = new FinancialManagerContext())
        //    {
        //        context.Incomes.Add(data);
        //        context.SaveChanges();
        //    }
        //}

        //public void Update<T>(T entity)
        //{
        //    Income data = (Income)Convert.ChangeType(entity, typeof(Income));
        //    using (var context = new FinancialManagerContext())
        //    {
        //        context.Incomes.Update(data);
        //        context.SaveChanges();
        //    }
        //}

        //public void Delete<T>(T entity)
        //{
        //    Income data = (Income)Convert.ChangeType(entity, typeof(Income));
        //    using (var context = new FinancialManagerContext())
        //    {
        //        context.Incomes.Remove(data);
        //        context.SaveChanges();
        //    }
        //}

        //public T Exists<T>(T entity)
        //{

        //}
    }
}
