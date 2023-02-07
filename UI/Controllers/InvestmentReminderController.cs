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
    public class InvestmentReminderController : IController
    {
        IRepository<InvestmentReminder> investmentReminderRepository;

        public InvestmentReminderController()
        {
            investmentReminderRepository = new InvestmentReminderRepository();
        }

        public IEntity Add(IEntity entity)
        {
            return investmentReminderRepository.Create(ConvertEntity(entity));
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
            return investmentReminderRepository.GetAllEntities(userId);
        }

        public IEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }

        private InvestmentReminder ConvertEntity(IEntity entity)
        {
            return (InvestmentReminder)Convert.ChangeType(entity, typeof(InvestmentReminder));
        }
    }
}
