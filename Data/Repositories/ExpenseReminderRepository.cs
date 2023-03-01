using FinancialManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Data.Repositories
{
    /// <summary>
    /// Repository class used to help with ExpenseReminder CRUD operations
    /// </summary>
    public class ExpenseReminderRepository : IRepository<ExpenseReminder>
    {
        public ExpenseReminder Create(ExpenseReminder entity)
        {
            using (var context = new FinancialManagerContext())
            {
                // raw query needed due to table constraint issues in entity framework
                var returned = context.Database
                    .ExecuteSqlRaw("INSERT INTO ExpenseReminder (ExpenseId,ReminderId) VALUES (" + entity.ExpenseId + ", " + entity.ReminderId + ")");
            }
            return new ExpenseReminder();
        }

        public void Delete(ExpenseReminder entity)
        {
            using (var context = new FinancialManagerContext())
            {
                // raw query needed due to table constraint issues in entity framework
                var returned = context.Database
                    .ExecuteSqlRaw("DELETE FROM ExpenseReminder WHERE ExpenseId = " + entity.ExpenseId + " AND ReminderId = " + entity.ReminderId + "; DELETE FROM Reminder WHERE Id = " + entity.ReminderId + ";");
            }
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
            ExpenseReminder? expense = new ExpenseReminder();

            using (var context = new FinancialManagerContext())
            {
                expense = context.ExpenseReminders
                                   .Where(u => u.ExpenseId == id)
                                   .FirstOrDefault<ExpenseReminder>();
            }
            return expense;
        }

        public void Update(ExpenseReminder entity)
        {
            throw new NotImplementedException();
        }
    }
}
