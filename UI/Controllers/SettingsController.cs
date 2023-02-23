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
    public class SettingsController : IController
    {
        IRepository<Setting> settingsRepository;

        public SettingsController()
        {
            settingsRepository = new SettingsRepository();
        }


        public IEntity Add(IEntity entity)
        {
            return settingsRepository.Create(ConvertEntity(entity));
        }

        public void Delete(IEntity entity)
        {
            settingsRepository.Delete(ConvertEntity(entity));
        }

        public void Update(IEntity entity)
        {
            settingsRepository.Update(ConvertEntity(entity));
        }

        IEnumerable<IEntity> IController.GetAll(long userId)
        {
            return settingsRepository.GetAllEntities(userId);
        }

        public IEntity Exists(IEntity entity)
        {
            return settingsRepository.GetByEntity(ConvertEntity(entity));
        }

        public IEntity GetById(int id)
        {
            return settingsRepository.GetById(id);
        }

        private Setting ConvertEntity(IEntity entity)
        {
            return (Setting)Convert.ChangeType(entity, typeof(Setting));
        }
    }
}
