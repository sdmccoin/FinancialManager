using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Data.Repositories;
using FinancialManagerLibrary.Data.Interfaces;
using FinancialManagerLibrary.Utilities;
using FinancialManagerLibrary.Interfaces;

namespace FinancialManager.UI.Controllers
{
    public class InvestmentController : IController
    {
        InvestmentRepository<Investment> investmentRepository;

        public InvestmentController()
        {
            investmentRepository = new InvestmentRepository<Investment>();
        }

        public IEntity Add(IEntity entity)
        {
            return investmentRepository.Create(ConvertEntity(entity));
        }

        public void Delete(IEntity entity)
        {
            investmentRepository.Delete(ConvertEntity(entity));
        }

        public void Update(IEntity entity)
        {
            investmentRepository.Update(ConvertEntity(entity));
        }

        public IEntity Exists(IEntity entity)
        {
            return investmentRepository.GetByEntity(ConvertEntity(entity));
        }

        public IEnumerable<IEntity> GetAll(long userId)
        {
            return investmentRepository.GetAllEntities(ActiveUser.id);
        }

        private Investment ConvertEntity(IEntity entity)
        {
            return (Investment)Convert.ChangeType(entity, typeof(Investment));
        }

        public IEntity GetById(int id)
        {
            return investmentRepository.GetById(id);
        }
    }
}
