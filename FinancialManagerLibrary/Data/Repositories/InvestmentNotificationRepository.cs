using FinancialManagerLibrary.Data.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Data.Repositories
{
    public class InvestmentNotificationRepository<T> : IRepository<InvestmentNotification>
    {
        public InvestmentNotification Create(InvestmentNotification entity)
        {
            EntityEntry<InvestmentNotification> entityAdded = null;
            using (var context = new FinancialManagerContext())
            {
                entityAdded = context.InvestmentNotifications.Add(entity);
                context.SaveChanges();

            }
            return entityAdded.Entity;
        }

        public void Delete(InvestmentNotification entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.InvestmentNotifications.Remove(entity);
                context.SaveChanges();
            }
        }

        public InvestmentNotification GetById(int id)
        {
            InvestmentNotification? investmentNotification = new InvestmentNotification();

            using (var context = new FinancialManagerContext())
            {
                investmentNotification = context.InvestmentNotifications
                                   .Where(u => u.Id == id)
                                   .FirstOrDefault<InvestmentNotification>();
            }
            return investmentNotification;
        }

        public InvestmentNotification GetByEntity(InvestmentNotification entity)
        {
            InvestmentNotification? investmentNotification = new InvestmentNotification();

            using (var context = new FinancialManagerContext())
            {
                investmentNotification = context.InvestmentNotifications
                                   .Where(i => (i.Symbol.Equals(entity.Symbol)) &&
                                   (i.UserId.Equals(entity.UserId)))
                                   .FirstOrDefault<InvestmentNotification>();
            }
            return investmentNotification;
        }

        public IEnumerable<InvestmentNotification> GetAllEntities(long userId)
        {
            IEnumerable<InvestmentNotification> entities = new List<InvestmentNotification>();

            using (var context = new FinancialManagerContext())
            {
                entities = context.InvestmentNotifications.Where(u => u.UserId == userId).ToList<InvestmentNotification>();
            }

            return entities;
        }

        public void Update(InvestmentNotification entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.InvestmentNotifications.Update(entity);
                context.SaveChanges();
            }
        }

        public T1 GetById<T1>(int id)
        {
            throw new NotImplementedException();
        }

        public T1 GetByEntity<T1>(T1 entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T1> GetAllEntities<T1>(long userId)
        {
            throw new NotImplementedException();
        }

        public void Create<T1>(T1 entity)
        {
            throw new NotImplementedException();
        }

        public void Update<T1>(T1 entity)
        {
            throw new NotImplementedException();
        }

        public void Delete<T1>(T1 entity)
        {
            throw new NotImplementedException();
        }
    }
}
