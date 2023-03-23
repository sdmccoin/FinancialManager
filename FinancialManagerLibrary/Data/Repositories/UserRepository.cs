using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace FinancialManagerLibrary.Data.Repositories
{
    /// <summary>
    /// Repository class used to help with User CRUD operations
    /// </summary>
    public class UserRepository<T> : IRepository<User>
    {
        public User Create(User entity)
        {
            EntityEntry<User> entityAdded = null;
            using (var context = new FinancialManagerContext())
            {
                entityAdded = context.Users.Add(entity);
                context.SaveChanges();

            }
            return entityAdded.Entity;
        }

        public void Delete(User entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.Users.Remove(entity);
                context.SaveChanges();
            }
        }

        public User GetById(int id)
        {
            User? user = new User();
           
            using (var context = new FinancialManagerContext())
            {
                user = context.Users
                                   .Where(u => u.Id == 1)
                                   .FirstOrDefault<User>();
            }
            return user;
        }

        public User GetByEntity(User entity)
        {
            User? user = new User();

            using (var context = new FinancialManagerContext())
            {
                user = context.Users
                                   .Where(u => (u.UserName.Equals(entity.UserName)) &&
                                   (u.Password.Equals(entity.Password)))
                                   .FirstOrDefault<User>();
            }
            return user;
        }

        public void Update(User entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.Users.Update(entity);
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

        public IEnumerable<User> GetAllEntities(long userId)
        {
            throw new NotImplementedException();
        }
    }
}
