using FinancialManager.Data.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Data.Repositories
{
    public class ExpenseReminderRepository : IRepository<ExpenseReminder>
    {
        public ExpenseReminder Create(ExpenseReminder entity)
        {
            EntityEntry<ExpenseReminder> entityAdded = null;
            using (var context = new FinancialManagerContext())
            {
                entityAdded = context.ExpenseReminders.Add(entity);
                context.SaveChanges();

            }
            return entityAdded.Entity;
        }

        public void Delete(ExpenseReminder entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExpenseReminder> GetAllEntities(long userId)
        {
            IEnumerable<ExpenseReminder> entities = new List<ExpenseReminder>();

            using (var context = new FinancialManagerContext())
            {
                entities = context.ExpenseReminders.ToList<ExpenseReminder>();
            }

            return entities;
        }

        public ExpenseReminder GetByEntity(ExpenseReminder entity)
        {
            throw new NotImplementedException();
        }

        public ExpenseReminder GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ExpenseReminder entity)
        {
            throw new NotImplementedException();
        }
    }
}
