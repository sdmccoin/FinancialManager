using FinancialManager.Data.Interfaces;
using FinancialManager.Data.Models;
using FinancialManager.Data.Repositories;
using FinancialManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.UI.Controllers
{
    public class UserController : IController
    {
        IRepository<User> userRepository;

        public UserController()
        {
            userRepository = new UserRepository<User>();
        }

        public IEntity Add(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEntity Exists(IEntity entity)
        {
            return userRepository.GetByEntity(ConvertEntity(entity));                
        }

        public IEnumerable<IEntity> GetAll(long userId)
        {
            throw new NotImplementedException();
        }

        public IEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }

        private User ConvertEntity(IEntity entity)
        {
            return (User)Convert.ChangeType(entity, typeof(User));
        }
    }
}
