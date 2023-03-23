using FinancialManagerLibrary.Data.Interfaces;
using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Data.Repositories;
using FinancialManagerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.UI.Controllers
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
            expenseReminderRepository.Delete(ConvertEntity(entity));
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
            return expenseReminderRepository.GetById(id);
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
