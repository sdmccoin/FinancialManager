using FinancialManager.Data.Models;
using FinancialManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace FinancialManager.Data.Repositories
{
    public class UserRepository<T> : IRepository<User> where T : EntityBase
    {
        public void Create(User entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.Users.Add(entity);
                context.SaveChanges();
            }
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
    }
}
