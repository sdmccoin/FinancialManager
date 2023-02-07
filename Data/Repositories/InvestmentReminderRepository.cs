using FinancialManager.Data.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Data.Repositories
{
    public class InvestmentReminderRepository : IRepository<InvestmentReminder>
    {
        public InvestmentReminder Create(InvestmentReminder entity)
        {
            EntityEntry<InvestmentReminder> entityAdded = null;
            using (var context = new FinancialManagerContext())
            {
                entityAdded = context.InvestmentReminders.Add(entity);
                context.SaveChanges();

            }
            return entityAdded.Entity;
        }

        public void Delete(InvestmentReminder entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvestmentReminder> GetAllEntities(long userId)
        {
            IEnumerable<InvestmentReminder> entities = new List<InvestmentReminder>();

            using (var context = new FinancialManagerContext())
            {
                entities = context.InvestmentReminders.ToList<InvestmentReminder>();
            }

            return entities;
        }

        public InvestmentReminder GetByEntity(InvestmentReminder entity)
        {
            throw new NotImplementedException();
        }

        public InvestmentReminder GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(InvestmentReminder entity)
        {
            throw new NotImplementedException();
        }
    }
}
