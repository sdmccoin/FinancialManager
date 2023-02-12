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
    internal class IncomeReminderController : IController
    {
        IRepository<IncomeReminder> incomeReminderRepository;

        public IncomeReminderController()
        {
            incomeReminderRepository = new IncomeReminderRepository();
        }

        public IEntity Add(IEntity entity)
        {
            return incomeReminderRepository.Create(ConvertEntity(entity));
        }

        public void Delete(IEntity entity)
        {
            incomeReminderRepository.Delete(ConvertEntity(entity));
        }

        public IEntity Exists(IEntity entity)
        {
            return incomeReminderRepository.GetByEntity(ConvertEntity(entity));
        }

        public IEnumerable<IEntity> GetAll(long userId)
        {
            return incomeReminderRepository.GetAllEntities(userId);
        }

        public IEntity GetById(int id)
        {
            return incomeReminderRepository.GetById(id);
        }

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }

        private IncomeReminder ConvertEntity(IEntity entity)
        {
            return (IncomeReminder)Convert.ChangeType(entity, typeof(IncomeReminder));
        }
    }
}
