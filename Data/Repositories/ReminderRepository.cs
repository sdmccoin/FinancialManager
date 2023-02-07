using FinancialManager.Data.Interfaces;
using FinancialManager.Data.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Data.Repositories
{
    internal class ReminderRepository : IRepository<Reminder>
    {
        public Reminder Create(Reminder entity)
        {
            EntityEntry<Reminder> entityAdded = null;
            using (var context = new FinancialManagerContext())
            {
                entityAdded = context.Reminders.Add(entity);
                context.SaveChanges();

            }
            return entityAdded.Entity;
        }

        public void Delete(Reminder entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.Reminders.Remove(entity);
                context.SaveChanges();
            }
        }

        public IEnumerable<Reminder> GetAllEntities(long userId)
        {
            IEnumerable<Reminder> entities = new List<Reminder>();

            using (var context = new FinancialManagerContext())
            {
                entities = context.Reminders.Where(u => u.UserId == userId).ToList<Reminder>();
            }

            return entities;
        }

        public Reminder GetByEntity(Reminder entity)
        {
            Reminder? reminder = new Reminder();

            using (var context = new FinancialManagerContext())
            {
                reminder = context.Reminders
                                   .Where(i => (i.Date.Equals(entity.Date)) &&
                                   (i.Time.Equals(entity.Time)) &&
                                   (i.Frequency.Equals(entity.Frequency)) &&
                                   i.Message.Equals(entity.Message)).FirstOrDefault<Reminder>();
            }
            return reminder;
        }

        public Reminder GetById(int id)
        {
            Reminder? reminder = new Reminder();

            using (var context = new FinancialManagerContext())
            {
                reminder = context.Reminders
                                   .Where(u => u.Id == 1)
                                   .FirstOrDefault<Reminder>();
            }
            return reminder;
        }

        public void Update(Reminder entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.Reminders.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
