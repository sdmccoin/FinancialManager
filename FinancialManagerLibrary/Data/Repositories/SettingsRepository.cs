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
    /// Repository class used to help with Settings CRUD operations
    /// </summary>
    public class SettingsRepository : IRepository<Setting>
    {
        public Setting Create(Setting entity)
        {
            EntityEntry<Setting> entityAdded = null;
            using (var context = new FinancialManagerContext())
            {
                entityAdded = context.Settings.Add(entity);
                context.SaveChanges();

            }
            return entityAdded.Entity;
        }

        public void Delete(Setting entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.Settings.Remove(entity);
                context.SaveChanges();
            }
        }

        public Setting GetById(int id)
        {
            Setting? income = new Setting();

            using (var context = new FinancialManagerContext())
            {
                income = context.Settings
                                   .Where(u => u.Id == id)
                                   .FirstOrDefault<Setting>();
            }
            return income;
        }

        public Setting GetByEntity(Setting entity)
        {
            Setting? setting = new Setting();

            using (var context = new FinancialManagerContext())
            {
                setting = context.Settings
                                   .Where(i => (i.EmailAddress.Equals(entity.EmailAddress)) &&
                                   (i.Phone.Equals(entity.Phone)))
                                   .FirstOrDefault<Setting>();
            }
            return setting;
        }

        public IEnumerable<Setting> GetAllEntities(long userId)
        {
            IEnumerable<Setting> entities = new List<Setting>();

            using (var context = new FinancialManagerContext())
            {
                entities = context.Settings.Where(u => u.UserId == userId).ToList<Setting>();
            }

            return entities;
        }

        public void Update(Setting entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.Settings.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
