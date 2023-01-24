using FinancialManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Data.Repositories
{
    public class ExpenseRepository<T> : IRepository<Expense> where T : EntityBase
    {
        public void Create(Expense entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.Expenses.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Expense entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.Expenses.Remove(entity);
                context.SaveChanges();
            }
        }

        public Expense GetById(int id)
        {
            Expense? expense = new Expense();

            using (var context = new FinancialManagerContext())
            {
                expense = context.Expenses
                                   .Where(u => u.Id == 1)
                                   .FirstOrDefault<Expense>();
            }
            return expense;
        }

        public Expense GetByEntity(Expense entity)
        {
            Expense? expense = new Expense();

            using (var context = new FinancialManagerContext())
            {
                expense = context.Expenses
                                   .Where(i => (i.Source.Equals(entity.Source)) &&
                                   (i.Amount.Equals(entity.Amount)))                             
                                   .FirstOrDefault<Expense>();
            }
            return expense;
        }

        public IEnumerable<Expense> GetAllEntities()
        {
            IEnumerable<Expense> entities = new List<Expense>();

            using (var context = new FinancialManagerContext())
            {
                entities = context.Expenses.ToList<Expense>();
            }

            return entities;
        }

        public void Update(Expense entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.Expenses.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
