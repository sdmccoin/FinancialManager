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
    public class IncomeNotificationController : IController
    {
        IRepository<IncomeNotification> incomeNotificationRepository;

        public IncomeNotificationController()
        {
            incomeNotificationRepository = new IncomeNotificationRepository();
        }

        public IEntity Add(IEntity entity)
        {
            return incomeNotificationRepository.Create(ConvertEntity(entity));
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
            return incomeNotificationRepository.GetAllEntities(userId);
        }

        public IEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }

        private IncomeNotification ConvertEntity(IEntity entity)
        {
            return (IncomeNotification)Convert.ChangeType(entity, typeof(IncomeNotification));
        }
    }
}
