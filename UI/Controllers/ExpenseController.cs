using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialManager.Data.Interfaces;
using FinancialManager.Data.Models;
using FinancialManager.Data.Repositories;
using FinancialManager.Interfaces;
using FinancialManager.Utilities;

namespace FinancialManager.UI.Controllers
{
    public class ExpenseController : IController
    {
        ExpenseRepository<Expense> expenseRepository;

        public ExpenseController()
        {
            expenseRepository = new ExpenseRepository<Expense>();
        }
                
        public void Add(IEntity entity)
        {
            expenseRepository.Create(ConvertEntity(entity));
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
            throw new NotImplementedException();
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
