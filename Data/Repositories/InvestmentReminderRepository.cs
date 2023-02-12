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
    public class InvestmentReminderRepository : IRepository<InvestmentReminder>
    {
        public InvestmentReminder Create(InvestmentReminder entity)
        {
            using (var context = new FinancialManagerContext())
            {
                // raw query needed due to table constraint issues in entity framework
                var returned = context.Database
                    .ExecuteSqlRaw("INSERT INTO InvestmentReminder (InvestmentId,ReminderId) VALUES (" + entity.InvestmentId + ", " + entity.ReminderId + ")");
            }
            return new InvestmentReminder();
        }

        public void Delete(InvestmentReminder entity)
        {
            using (var context = new FinancialManagerContext())
            {
                // raw query needed due to table constraint issues in entity framework
                var returned = context.Database
                    .ExecuteSqlRaw("DELETE FROM InvestmentReminder WHERE InvestmentId = " + entity.InvestmentId + " AND ReminderId = " + entity.ReminderId + "; DELETE FROM Reminder WHERE Id = " + entity.ReminderId + ";");
            }
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
            InvestmentReminder? investment = new InvestmentReminder();

            using (var context = new FinancialManagerContext())
            {
                investment = context.InvestmentReminders
                                   .Where(u => u.InvestmentId == id)
                                   .FirstOrDefault<InvestmentReminder>();
            }
            return investment;
        }

        public void Update(InvestmentReminder entity)
        {
            throw new NotImplementedException();
        }
    }
}
