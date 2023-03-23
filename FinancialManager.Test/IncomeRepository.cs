using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Test
{
    using FinancialManagerLibrary.Data.Repositories;
    using FinancialManagerLibrary.Data.Models;
    using FinancialManagerLibrary.Interfaces;
    using FinancialManagerLibrary.UI.Controllers;

    [TestClass]
    public class IncomeRepositoryTest
    {
        IncomeRepository incomeRepository;

        public IncomeRepositoryTest()
        {
            incomeRepository = new IncomeRepository();
        }

        [TestMethod]
        public void UsersExists()
        {
            Assert.IsNotNull(incomeRepository.GetAllEntities(1));
        }
        [TestMethod]
        public void UsersExistsFail()
        {
            Assert.IsNotNull(incomeRepository.GetAllEntities(1000));
        }
       
    }
}
