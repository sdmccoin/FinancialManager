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
    public class ReminderController : IController
    {
        IRepository<Reminder> reminderRepository;

        public ReminderController()
        {
            reminderRepository = new ReminderRepository();
        }

        public IEntity Add(IEntity entity)
        {
            return reminderRepository.Create(ConvertEntity(entity));
        }

        public void Delete(IEntity entity)
        {
            reminderRepository.Delete(ConvertEntity(entity));
        }

        public IEntity Exists(IEntity entity)
        {
            return reminderRepository.GetByEntity(ConvertEntity(entity));
        }

        public IEnumerable<IEntity> GetAll(long userId)
        {
            return reminderRepository.GetAllEntities(userId);
        }

        public IEntity GetById(int id)
        {
            return reminderRepository.GetById(id);
        }

        public void Update(IEntity entity)
        {
            reminderRepository.Update(ConvertEntity(entity));
        }

        private Reminder ConvertEntity(IEntity entity)
        {
            return (Reminder)Convert.ChangeType(entity, typeof(Reminder));
        }
    }
}
