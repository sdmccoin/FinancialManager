using Microsoft.ML.Transforms.TimeSeries;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerMLStockAnalyzer
{
    public class Program3
    {
        public void Execute()
        {
            // load new data


        }

        //public Task<bool?> ShouldBuyStock(IList<StockInput> HistoricalData)
        //{
        //    var modelBuilder = new ModelBuilder();
        //    var model = modelBuilder.BuildModel(HistoricalData.Select(x => new ModelInput
        //    {
        //        PriceDiffrence = (float)((x.ClosingPrice - HistoricalData.Last().ClosingPrice) / HistoricalData.Last().ClosingPrice),
        //        Time = x.Time
        //    }).ToList());
        //    var result = model.Predict();

        //    return Task.FromResult((bool?)(result.ForecastedPriceDiffrence[0] > 0));
        //}
    }

    public record StockInput
    {
        public decimal ClosingPrice { get; init; }
        public string StockSymbol { get; init; }
        public DateTime Time { get; init; }
    }

    public class ModelBuilder
    {
        public TimeSeriesPredictionEngine<ModelInput, ModelOutput> BuildModel(IList<ModelInput> inputs)
        {
            //Create model
            var mlContext = new MLContext();
            var trainDataVeiw = mlContext.Data.LoadFromEnumerable(inputs);

            var forecastingPipeline = mlContext.Forecasting.ForecastBySsa(
                 outputColumnName: "ForecastedPriceDiffrence",
                 inputColumnName: "PriceDiffrence",
                 windowSize: 7,
                 seriesLength: 30,
                 trainSize: inputs.Count,
                 horizon: 7,
                 confidenceLevel: 0.95f,
                 confidenceLowerBoundColumn: "LowerBoundPriceDiffrence",
                 confidenceUpperBoundColumn: "UpperBoundPriceDiffrence");

            var forecaster = forecastingPipeline.Fit(trainDataVeiw);
            return forecaster.CreateTimeSeriesEngine<ModelInput, ModelOutput>(mlContext);
        }
    }

  /*  public record ModelInput
    {
        public float PriceDiffrence { get; init; }
        public DateTime Time { get; init; }
    }

    public record ModelOutput
    {
        public float[] ForecastedPriceDiffrence { get; init; }
        public float[] LowerBoundPriceDiffrence { get; init; }
        public float[] UpperBoundPriceDiffrence { get; init; }
    }*/
}
