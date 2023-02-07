using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialManager.Data.Models;
using FinancialManager.Data.Repositories;
using FinancialManager.Data.Interfaces;
using FinancialManager.Utilities;
using FinancialManager.Services;
using FinancialManager.Interfaces;

namespace FinancialManager.UI.Controllers
{
    public class ReportController : IController
    {
        ReportingService reportingService;

        public ReportController() 
        {
            reportingService = new ReportingService();
        }

        public IEntity Add(IEntity entity)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public IEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
