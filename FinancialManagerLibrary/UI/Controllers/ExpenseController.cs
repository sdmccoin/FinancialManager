using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialManagerLibrary.Data.Interfaces;
using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Data.Repositories;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.Utilities;

namespace FinancialManagerLibrary.UI.Controllers
{
    public class ExpenseController : IController
    {
        ExpenseRepository<Expense> expenseRepository;

        public ExpenseController()
        {
            expenseRepository = new ExpenseRepository<Expense>();
        }
                
        public IEntity Add(IEntity entity)
        {
            return expenseRepository.Create(ConvertEntity(entity));
        }

        public void Delete(IEntity entity)
        {
            expenseRepository.Delete(ConvertEntity(entity));
        }

        public IEntity Exists(IEntity entity)
        {
            return expenseRepository.GetByEntity(ConvertEntity(entity));
        }

        public IEnumerable<IEntity> GetAll(long userId)
        {
            return expenseRepository.GetAllEntities(ActiveUser.id); 
        }

        public IEntity GetById(int id)
        {
            return expenseRepository.GetById(id);
        }

        public void Update(IEntity entity)
        {
            expenseRepository.Update(ConvertEntity(entity));
        }

        private Expense ConvertEntity(IEntity entity)
        {
            return (Expense)Convert.ChangeType(entity, typeof(Expense));
        }
    }
}
