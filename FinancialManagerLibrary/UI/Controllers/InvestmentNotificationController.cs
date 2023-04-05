using FinancialManagerLibrary.Data.Interfaces;
using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Data.Repositories;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.UI.Controllers
{
    public class InvestmentNotificationController : IController
    {
        InvestmentNotificationRepository<InvestmentNotification> investmentNotificationRepository;

        public InvestmentNotificationController()
        {
            investmentNotificationRepository = new InvestmentNotificationRepository<InvestmentNotification>();
        }

        public IEntity Add(IEntity entity)
        {
            return investmentNotificationRepository.Create(ConvertEntity(entity));
        }

        public void Delete(IEntity entity)
        {
            investmentNotificationRepository.Delete(ConvertEntity(entity));
        }

        public void Update(IEntity entity)
        {
            investmentNotificationRepository.Update(ConvertEntity(entity));
        }

        public IEntity Exists(IEntity entity)
        {
            return investmentNotificationRepository.GetByEntity(ConvertEntity(entity));
        }

        public IEnumerable<IEntity> GetAll(long userId)
        {
            return investmentNotificationRepository.GetAllEntities(ActiveUser.id);
        }

        private InvestmentNotification ConvertEntity(IEntity entity)
        {
            return (InvestmentNotification)Convert.ChangeType(entity, typeof(InvestmentNotification));
        }

        public IEntity GetById(int id)
        {
            return investmentNotificationRepository.GetById(id);
        }
    }
}
