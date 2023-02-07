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
    public class ExpenseReminderController : IController
    {
        IRepository<ExpenseReminder> expenseReminderRepository;

        public ExpenseReminderController()
        {
            expenseReminderRepository = new ExpenseReminderRepository();
        }

        public IEntity Add(IEntity entity)
        {
            return expenseReminderRepository.Create(ConvertEntity(entity));
        }

        public void Delete(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEntity Exists(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEntity> GetAll(long userId)
        {
            return expenseReminderRepository.GetAllEntities(userId);
        }

        public IEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }

        private ExpenseReminder ConvertEntity(IEntity entity)
        {
            return (ExpenseReminder)Convert.ChangeType(entity, typeof(ExpenseReminder));
        }
    }
}
