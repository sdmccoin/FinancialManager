﻿using FinancialManager.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Data.Repositories
{
    /// <summary>
    /// Generic Repository Interface
    /// </summary>
    public interface IRepository<T>// where T : EntityBase
    {
        T GetById(int id);
        T GetByEntity(T entity);
        IEnumerable<T> GetAllEntities(long userId);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
