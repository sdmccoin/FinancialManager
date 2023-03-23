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
    public class StockAnalysisController : IController
    {
        IRepository<StockAnalysis> stockAnalysisRepository;

        public StockAnalysisController()
        {
            stockAnalysisRepository = new StockAnalysisRepository();
        }


        public IEntity Add(IEntity entity)
        {
            return stockAnalysisRepository.Create(ConvertEntity(entity));
        }

        public void Delete(IEntity entity)
        {
            stockAnalysisRepository.Delete(ConvertEntity(entity));
        }

        public void Update(IEntity entity)
        {
            stockAnalysisRepository.Update(ConvertEntity(entity));
        }

        IEnumerable<IEntity> IController.GetAll(long userId)
        {
            return stockAnalysisRepository.GetAllEntities(userId);
        }

        public IEntity Exists(IEntity entity)
        {
            return stockAnalysisRepository.GetByEntity(ConvertEntity(entity));
        }

        public IEntity GetById(int id)
        {
            return stockAnalysisRepository.GetById(id);
        }

        private StockAnalysis ConvertEntity(IEntity entity)
        {
            return (StockAnalysis)Convert.ChangeType(entity, typeof(StockAnalysis));
        }
    }
}
