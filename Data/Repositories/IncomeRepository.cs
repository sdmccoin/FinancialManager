using FinancialManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Data.Repositories
{
    public class IncomeRepository<T> : IRepository<Income> where T : EntityBase
    {
        public void Create(Income entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.Incomes.Add(entity);
                context.SaveChanges();
            }
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
                                   .Where(u => u.Id == 1)
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

        public IEnumerable<Income> GetAllEntities()
        {
            IEnumerable<Income> entities = new List<Income>();

            using (var context = new FinancialManagerContext())
            {
                entities = context.Incomes.ToList<Income>();
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
    }
}
