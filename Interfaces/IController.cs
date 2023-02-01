using FinancialManager.Data.Interfaces;
using FinancialManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Interfaces
{
    public interface IController
    {
        void Add(IEntity entity);
        void Delete(IEntity entity);
        void Update(IEntity entity);
        IEntity Exists(IEntity entity);
        IEnumerable<IEntity> GetAll(long userId);
        IEntity GetById(int id);
    }
}
