using FinancialManager.Data.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Data.Repositories
{
    public class StockAnalysisRepository : IRepository<StockAnalysis>
    {
        public StockAnalysis Create(StockAnalysis entity)
        {
            EntityEntry<StockAnalysis> entityAdded = null;
            using (var context = new FinancialManagerContext())
            {
                entityAdded = context.StockAnalyses.Add(entity);
                context.SaveChanges();

            }
            return entityAdded.Entity;
        }

        public void Delete(StockAnalysis entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.StockAnalyses.Remove(entity);
                context.SaveChanges();
            }
        }

        public StockAnalysis GetById(int id)
        {
            StockAnalysis? stockAnalysis = new StockAnalysis();

            using (var context = new FinancialManagerContext())
            {
                stockAnalysis = context.StockAnalyses
                                   .Where(u => u.Id == id)
                                   .FirstOrDefault<StockAnalysis>();
            }
            return stockAnalysis;
        }

        public StockAnalysis GetByEntity(StockAnalysis entity)
        {
            StockAnalysis? stockAnalysis = new StockAnalysis();

            using (var context = new FinancialManagerContext())
            {
                stockAnalysis = context.StockAnalyses
                                   .Where(i => (i.Symbol.Equals(entity.Symbol)) &&
                                   (i.ClosingValue.Equals(entity.ClosingValue)) &&
                                   (i.UserId.Equals(entity.UserId)) &&
                                   (i.Date.Equals(entity.Date)))
                                   .FirstOrDefault<StockAnalysis>();
            }
            return stockAnalysis;
        }

        public IEnumerable<StockAnalysis> GetAllEntities(long userId)
        {
            IEnumerable<StockAnalysis> entities = new List<StockAnalysis>();

            using (var context = new FinancialManagerContext())
            {
                entities = context.StockAnalyses.Where(u => u.UserId == userId).ToList<StockAnalysis>();
            }

            return entities;
        }

        public void Update(StockAnalysis entity)
        {
            using (var context = new FinancialManagerContext())
            {
                context.StockAnalyses.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
