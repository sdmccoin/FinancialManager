using FinancialManagerLibrary.Data.Interfaces;
using FinancialManagerLibrary.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Data.Repositories
{
    /// <summary>
    /// Repository class used to help with IncomeReminder CRUD operations
    /// </summary>
    internal class IncomeReminderRepository : IRepository<IncomeReminder>
    {
        public IncomeReminder Create(IncomeReminder entity)
        {            
            using (var context = new FinancialManagerContext())
            {
                // raw query needed due to table constraint issues in entity framework
                var returned = context.Database
                    .ExecuteSqlRaw("INSERT INTO IncomeReminder (IncomeId,ReminderId) VALUES ("+entity.IncomeId+", "+entity.ReminderId+")");               
            }
            return new IncomeReminder();    // return empty reminder since it's not needed yet
        }      

        public void Delete(IncomeReminder entity)
        {
            using (var context = new FinancialManagerContext())
            {
                // raw query needed due to table constraint issues in entity framework
                var returned = context.Database
                    .ExecuteSqlRaw("DELETE FROM IncomeReminder WHERE IncomeId = " + entity.IncomeId + " AND ReminderId = " + entity.ReminderId +"; DELETE FROM Reminder WHERE Id = "+ entity.ReminderId +";");                    
            }
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
            IncomeReminder? income = new IncomeReminder();

            using (var context = new FinancialManagerContext())
            {
                income = context.IncomeReminders
                                   .Where(u => u.IncomeId == entity.Id)
                                   .FirstOrDefault<IncomeReminder>();
            }
            return income;
        }

        public IncomeReminder GetById(int id)
        {
            IncomeReminder? income = new IncomeReminder();

            using (var context = new FinancialManagerContext())
            {
                income = context.IncomeReminders
                                   .Where(u => u.IncomeId == id)
                                   .FirstOrDefault<IncomeReminder>();
            }
            return income;
        }

        public void Update(IncomeReminder entity)
        {
            throw new NotImplementedException();
        }
    }
}
