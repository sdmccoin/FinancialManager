using FinancialManager.Data.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Data.Repositories
{
    internal class IncomeReminderRepository : IRepository<IncomeReminder>
    {
        public IncomeReminder Create(IncomeReminder entity)
        {
            EntityEntry<IncomeReminder> entityAdded = null;
            using (var context = new FinancialManagerContext())
            {
                entityAdded = context.IncomeReminders.Add(entity);
                context.SaveChanges();

            }
            return entityAdded.Entity;
        }

        public void Delete(IncomeReminder entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IncomeReminder> GetAllEntities(long userId)
        {
            IEnumerable<IncomeReminder> entities = new List<IncomeReminder>();

            using (var context = new FinancialManagerContext())
            {
                entities = context.IncomeReminders.ToList<IncomeReminder>();
            }

            return entities;
        }

        public IncomeReminder GetByEntity(IncomeReminder entity)
        {
            throw new NotImplementedException();
        }

        public IncomeReminder GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IncomeReminder entity)
        {
            throw new NotImplementedException();
        }
    }
}
