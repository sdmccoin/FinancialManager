using FinancialManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Data.Repositories
{
    public class ExpenseRepository<T> : IRepository<Expense>//<Expense> where T : EntityBase
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
                var existing = context.Expenses.SingleOrDefault(x => x.Id == entity.Id);
                if (existing != null)
                {
                    context.Expenses.Remove(existing);
                    context.SaveChanges();
                }

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

        public IEnumerable<Expense> GetAllEntities(long userId)
        {
            IEnumerable<Expense> entities = new List<Expense>();

            using (var context = new FinancialManagerContext())
            {
                entities = context.Expenses
                    .Where(i => i.UserId == userId).ToList<Expense>();
            }

            return entities;
        }

        public void Update(Expense entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.Expenses.Update(entity);
                context.SaveChanges();
                //var existing = context.Expenses.SingleOrDefault(i => i.Id == entity.Id);
                //if (existing != null)
                //{
                //    existing.Frequency = entity.Frequency;
                //    existing.Address = entity.Address;
                //    existing.Source = entity.Source;
                //    existing.Amount = entity.Amount;

                //    context.Update(entity);
                //    context.SaveChanges();
                //}
                //context.Expenses.Update(entity);

            }
        }

        public T1 GetById<T1>(int id)
        {
            throw new NotImplementedException();
        }

        public T1 GetByEntity<T1>(T1 entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T1> GetAllEntities<T1>(long userId)
        {
            throw new NotImplementedException();
        }

        public void Create<T1>(T1 entity)
        {
            throw new NotImplementedException();
        }

        public void Update<T1>(T1 entity)
        {
            throw new NotImplementedException();
        }

        public void Delete<T1>(T1 entity)
        {
            throw new NotImplementedException();
        }
    }
}
