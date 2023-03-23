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
            investmentReminderRepository.Delete(ConvertEntity(entity));
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
            return investmentReminderRepository.GetById(id);
        }

        public void Update(IEntity entity)
        {
            investmentReminderRepository.Update(ConvertEntity(entity));
        }

        private InvestmentReminder ConvertEntity(IEntity entity)
        {
            return (InvestmentReminder)Convert.ChangeType(entity, typeof(InvestmentReminder));
        }
    }
}
