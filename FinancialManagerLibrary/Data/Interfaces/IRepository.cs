using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Data.Interfaces
{
    /// <summary>
    /// Generic Repository Interface
    /// </summary>
    public interface IRepository<T>
    {
        T GetById(int id);
        T GetByEntity(T entity);
        IEnumerable<T> GetAllEntities(long userId);
        T Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
