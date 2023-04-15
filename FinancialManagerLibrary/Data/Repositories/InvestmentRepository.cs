using FinancialManagerLibrary.Data.Interfaces;
using FinancialManagerLibrary.Data.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Data.Repositories
{
    /// <summary>
    /// Repository class used to help with Investment CRUD operations
    /// </summary>
    public class InvestmentRepository<T> : IRepository<Investment>
    {
        public Investment Create(Investment entity)
        {
            EntityEntry<Investment> entityAdded = null;
            using (var context = new FinancialManagerContext())
            {
                entityAdded = context.Investments.Add(entity);
                context.SaveChanges();

            }
            return entityAdded.Entity;
        }

        public void Delete(Investment entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.Investments.Remove(entity);
                context.SaveChanges();
            }
        }

        public Investment GetById(int id)
        {
            Investment? investment = new Investment();

            using (var context = new FinancialManagerContext())
            {
                investment = context.Investments
                                   .Where(u => u.Id == id)
                                   .FirstOrDefault<Investment>();
            }
            return investment;
        }

        public Investment GetByEntity(Investment entity)
        {
            Investment? investment = new Investment();

            using (var context = new FinancialManagerContext())
            {
                investment = context.Investments
                                   .Where(i => (i.Source.Equals(entity.Source)) &&
                                   (i.Amount.Equals(entity.Amount)))
                                   .FirstOrDefault<Investment>();
            }
            return investment;
        }

        public IEnumerable<Investment> GetAllEntities(long userId)
        {
            IEnumerable<Investment> entities = new List<Investment>();

            using (var context = new FinancialManagerContext())
            {
                entities = context.Investments.Where(u => u.UserId == userId).ToList<Investment>();
            }

            return entities;
        }

        public void Update(Investment entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.Investments.Update(entity);
                context.SaveChanges();
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
