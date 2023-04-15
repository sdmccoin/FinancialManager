using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Transforms.TimeSeries;
using Microsoft.ML;
using System.Data.SQLite;
using Microsoft.ML.Data;
using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Interfaces;
using FinancialManagerLibrary.UI.Controllers;
using FinancialManagerLibrary.Utilities;

namespace FinancialManagerLibrary.Services
{
    public class MachineLearning
    {
        IController settingsController;

        public IEnumerable<ChartData> RunStockAnalytics(string stockSymbol, int userId)
        {
            IEnumerable<ChartData> chartData = new List<ChartData>();

            try {
                settingsController = ControllerFactory.GetController("Settings");
                Setting settings = (Setting)settingsController.GetAll(ActiveUser.id).FirstOrDefault();
                string confidenceLevel = settings.ConfidenceLevel;
                int seriesLength = int.Parse(settings.PredictionTimeInterval.ToString());

                string rootDir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
                string modelPath = Path.Combine(rootDir, "MLModel.zip");

                MLContext mlContext = new MLContext();

                // load the data
                DatabaseLoader loader = mlContext.Data.CreateDatabaseLoader<ModelInput>();
                IDataView dataView1 = loader.Load(LoadFirstYearStockData(stockSymbol, userId));
                IDataView firstYearData = mlContext.Data.FilterRowsByColumn(dataView1, "Year", upperBound: 1);

                IDataView dataView2 = loader.Load(SecondFirstYearStockData(stockSymbol, userId));
                IDataView secondYearData = mlContext.Data.FilterRowsByColumn(dataView2, "Year", lowerBound: 1);

                var forecastingPipeline = mlContext.Forecasting.ForecastBySsa(
                    outputColumnName: "ForecastedClosingValue",
                    inputColumnName: "ClosingValue",
                    windowSize: 7,
                    seriesLength: seriesLength,//30,
                    trainSize: 360,
                    horizon: 7,
                    confidenceLevel: float.Parse(confidenceLevel),//0.95f,

                    confidenceLowerBoundColumn: "LowerBoundClosingValue",
                    confidenceUpperBoundColumn: "UpperBoundClosingValue");

                SsaForecastingTransformer forecaster = forecastingPipeline.Fit(firstYearData);

                Evaluate(secondYearData, forecaster, mlContext);

                var forecastEngine = forecaster.CreateTimeSeriesEngine<ModelInput, ModelOutput>(mlContext);
                forecastEngine.CheckPoint(mlContext, modelPath);

                chartData = Forecast(secondYearData, 7, forecastEngine, mlContext);
            }
            catch(Exception ex) {
                LoggingService.GetInstance.Log(ex.Message);
            }

            return chartData;
            
        }

        private DatabaseSource LoadFirstYearStockData(string symbol, int userId)
        {
            var connectionString = ConfigurationService.GetInstance.GetAllConfigItems().Get("Database"); // $"Data Source=C:\\git\\src\\FinancialManager\\FinancialManagerLibrary\\DataSources\\sqlite\\FinancialManager.db";// ;Version=3;";

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("SELECT date,0 as Year, CAST(ClosingValue as int) as ClosingValue");
            sb1.Append(" FROM StockAnalysis");
            sb1.Append(" where");
            sb1.Append(" Date <= datetime('" + DateTime.Now.AddYears(-1).ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss") + "')");
            sb1.Append(" AND Date >= datetime('" + DateTime.Now.AddYears(-2).ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss") + "')");
            //sb1.Append(" Date <= datetime('" + DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss") + "')");
            //sb1.Append(" AND Date >= datetime('" + DateTime.Now.AddYears(-1).ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss") + "')");           
            sb1.Append(" AND Symbol = '" + symbol + "'");
            sb1.Append(" AND UserId = " + userId);

            //string query = "SELECT date, Cast(CASE WHEN CAST(Date as date) == 2022 THEN 0 ELSE 1 END AS Year) as Year, CAST(ClosingValue as REAL) as ClosingValue FROM StockAnalysis";
            return new DatabaseSource(SQLiteFactory.Instance,//SqlClientFactory.Instance,
                                            connectionString,
                                            sb1.ToString());
        }
        private DatabaseSource SecondFirstYearStockData(string symbol, int userId)
        {
            var connectionString = ConfigurationService.GetInstance.GetAllConfigItems().Get("Database"); //$"Data Source=C:\\git\\src\\FinancialManager\\FinancialManagerLibrary\\DataSources\\sqlite\\FinancialManager.db";// ;Version=3;";

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("SELECT date,1 as Year, CAST(ClosingValue as int) as ClosingValue");
            sb1.Append(" FROM StockAnalysis");
            sb1.Append(" where");
            //sb1.Append(" Date <= datetime('" + DateTime.Now.AddYears(-1).ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss") + "')");
            //sb1.Append(" AND Date >= datetime('" + DateTime.Now.AddYears(-2).ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss") + "')");
            sb1.Append(" Date <= datetime('" + DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss") + "')");
            sb1.Append(" AND Date >= datetime('" + DateTime.Now.AddYears(-1).ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss") + "')");
            sb1.Append(" AND Date >= datetime('2021-04-04 00:00:00')");
            sb1.Append(" AND Symbol = '" + symbol + "'");
            sb1.Append(" AND UserId = " + userId);


            //string query = "SELECT date, Cast(CASE WHEN CAST(Date as date) == 2022 THEN 0 ELSE 1 END AS Year) as Year, CAST(ClosingValue as REAL) as ClosingValue FROM StockAnalysis";
            return new DatabaseSource(SQLiteFactory.Instance,//SqlClientFactory.Instance,
                                            connectionString,
                                            sb1.ToString());
        }

        private void Evaluate(IDataView testData, ITransformer model, MLContext mlContext)
        {
            // forcast the data
            IDataView predictions = model.Transform(testData);

            // get the actual data
            IEnumerable<float> actual =
            mlContext.Data.CreateEnumerable<ModelInput>(testData, true)
                .Select(observed => observed.ClosingValue);

            // get the forcasted data
            IEnumerable<float> forecast =
            mlContext.Data.CreateEnumerable<ModelOutput>(predictions, true)
                .Select(prediction => prediction.ForecastedClosingValue[0]);

            // calculate the difference
            var metrics = actual.Zip(forecast, (actualValue, forecastValue) => actualValue - forecastValue);

            // calculate the mean absolute difference and root mean squared difference
            var MAE = metrics.Average(error => Math.Abs(error)); // Mean Absolute Error
            var RMSE = Math.Sqrt(metrics.Average(error => Math.Pow(error, 2))); // Root Mean Squared Error
        }

        private IEnumerable<ChartData> Forecast(IDataView testData, int horizon, TimeSeriesPredictionEngine<ModelInput, ModelOutput> forecaster, MLContext mlContext)
        {
            // run forecast
            ModelOutput forecast = forecaster.Predict();
                      
            IEnumerable<ChartData> forecastOutput =
            mlContext.Data.CreateEnumerable<ModelInput>(testData, reuseRowObject: false)
                .Take(horizon)
                .Select((ModelInput stock, int index) =>
                {
                    string closingDate = stock.Date.ToShortDateString();
                    float actualValue = stock.ClosingValue;
                    float lowerEstimate = Math.Max(0, forecast.LowerBoundClosingValue[index]);
                    float estimate = forecast.ForecastedClosingValue[index];
                    float upperEstimate = forecast.UpperBoundClosingValue[index];
                    return new ChartData()
                    {
                        Date = DateTime.Parse(closingDate.ToString()),
                        Actual = actualValue,
                        Lower = lowerEstimate,
                        Forecast = estimate,
                        Upper = upperEstimate
                    };
                });

            return forecastOutput;

        }
    }
}
