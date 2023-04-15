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
    /// Repository class used to help with IncomeNotification CRUD operations
    /// </summary>
    public class IncomeNotificationRepository : IRepository<IncomeNotification>
    {
        public IncomeNotification Create(IncomeNotification entity)
        {
            EntityEntry<IncomeNotification> entityAdded = null;
            using (var context = new FinancialManagerContext())
            {
                entityAdded = context.IncomeNotifications.Add(entity);
                context.SaveChanges();

            }
            return entityAdded.Entity;
        }

        public void Delete(IncomeNotification entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IncomeNotification> GetAllEntities(long userId)
        {
            IEnumerable<IncomeNotification> entities = new List<IncomeNotification>();

            using (var context = new FinancialManagerContext())
            {
                entities = context.IncomeNotifications.ToList<IncomeNotification>();
            }

            return entities;
        }

        public IncomeNotification GetByEntity(IncomeNotification entity)
        {
            throw new NotImplementedException();
        }

        public IncomeNotification GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IncomeNotification entity)
        {
            throw new NotImplementedException();
        }
    }
}
