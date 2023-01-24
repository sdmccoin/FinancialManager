using FinancialManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Data.Repositories
{
    internal class InvestmentRepository<T> : IRepository<Investment> where T : EntityBase
    {
        public void Create(Investment entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.Investments.Add(entity);
                context.SaveChanges();
            }
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
                                   .Where(u => u.Id == 1)
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

        public IEnumerable<Investment> GetAllEntities()
        {
            IEnumerable<Investment> entities = new List<Investment>();

            using (var context = new FinancialManagerContext())
            {
                entities = context.Investments.ToList<Investment>();
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
    }
}
