namespace FinancialManagerMLStockAnalyzer
{
    using FinancialManagerMLStockAnalyzer.Models;
    using Microsoft.ML;
    using Microsoft.ML.Data;
    using Microsoft.ML.Transforms.TimeSeries;
    using System.Data.Entity;
    using System.Data.SQLite;

    public class Program
    {
        static void Main(string[] args)
        {
            Program2 program2= new Program2();
            program2.Execute();

            //string rootDir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
            //string modelPath = Path.Combine(rootDir, "MLModel.zip");
            
            //MLContext mlContext = new MLContext();

            //DatabaseLoader loader = mlContext.Data.CreateDatabaseLoader<ModelInput>();

            
            //IDataView dataView = loader.Load(LoadStockData("",0));

            //IDataView firstYearData = mlContext.Data.FilterRowsByColumn(dataView, "Year", upperBound: 1);
            //IDataView secondYearData = mlContext.Data.FilterRowsByColumn(dataView, "Year", lowerBound: 1);

            //var forecastingPipeline = mlContext.Forecasting.ForecastBySsa(
            //    outputColumnName: "ForecastedClosingValue",
            //    inputColumnName: "ClosingValue",
            //    windowSize: 7,
            //    seriesLength: 30,
            //    trainSize: 100,
            //    horizon: 7,
            //    confidenceLevel: 0.95f,
            //    confidenceLowerBoundColumn: "LowerBoundClosingValue",
            //    confidenceUpperBoundColumn: "UpperBoundClosingValue");

            //SsaForecastingTransformer forecaster = forecastingPipeline.Fit(firstYearData);

            //Evaluate(secondYearData, forecaster, mlContext);

            //var forecastEngine = forecaster.CreateTimeSeriesEngine<ModelInput, ModelOutput>(mlContext);
            //forecastEngine.CheckPoint(mlContext, modelPath);

            //Forecast(secondYearData, 7, forecastEngine, mlContext);

        }

        //static DatabaseSource LoadStockData(string symbol, int userId)
        //{
        //    var connectionString = $"Data Source=C:\\git\\src\\FinancialManager\\FinancialManagerLibrary\\DataSources\\sqlite\\FinancialManager.db";// ;Version=3;";

        //    string query = "SELECT date, Cast(CASE WHEN CAST(Date as date) == 2022 THEN 0 ELSE 1 END AS Year) as Year, CAST(ClosingValue as REAL) as ClosingValue FROM StockAnalysis";
        //    return new DatabaseSource(SQLiteFactory.Instance,//SqlClientFactory.Instance,
        //                                    connectionString,
        //                                    query);

        //    //string query = "SELECT RentalDate, CAST(Year as REAL) as Year, CAST(TotalRentals as REAL) as TotalRentals FROM Rentals";
        //    //string query = "SELECT CAST(Date as DATE) as Date, CAST(ClosingValue as REAL) as ClosingValue FROM StockAnalysis";
        //    //string query = "SELECT date, Cast(Date as date) as Year, CAST(ClosingValue as REAL) as ClosingValue FROM StockAnalysis";
        //    //string query = "SELECT date, Cast(CASE WHEN CAST(Date as date) == 2022 THEN 0 ELSE 1 END AS Year) as Year, CAST(ClosingValue as REAL) as ClosingValue FROM StockAnalysis";
        //    // string query = "SELECT date, Cast(CASE WHEN CAST(Date as date) == 2022 THEN 0 ELSE 1 END AS Year) as Year, CAST(ClosingValue as REAL) as ClosingValue FROM StockAnalysis order by date asc LIMIT 100";
        //    //SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=C:\\git\\src\\FinancialManager\\FinancialManagerLibrary\\DataSources\\sqlite\\FinancialManager.db; Version = 3; New = True; Compress = True; ");

        //    //DatabaseSource dbSource = new DatabaseSource(SQLiteFactory.Instance,//SqlClientFactory.Instance,
        //    //                                connectionString,
        //    //                                query);


        //}

        //static void Evaluate(IDataView testData, ITransformer model, MLContext mlContext)
        //{
        //    // forcast the data
        //    IDataView predictions = model.Transform(testData);

        //    // get the actual data
        //    IEnumerable<float> actual =
        //    mlContext.Data.CreateEnumerable<ModelInput>(testData, true)
        //        .Select(observed => observed.ClosingValue);

        //    // get the forcasted data
        //    IEnumerable<float> forecast =
        //    mlContext.Data.CreateEnumerable<ModelOutput>(predictions, true)
        //        .Select(prediction => prediction.ForecastedClosingValue[0]);

        //    // calculate the difference
        //    var metrics = actual.Zip(forecast, (actualValue, forecastValue) => actualValue - forecastValue);

        //    // calculate the mean absolute difference and root mean squared difference
        //    var MAE = metrics.Average(error => Math.Abs(error)); // Mean Absolute Error
        //    var RMSE = Math.Sqrt(metrics.Average(error => Math.Pow(error, 2))); // Root Mean Squared Error
        //}

        //static void Forecast(IDataView testData, int horizon, TimeSeriesPredictionEngine<ModelInput, ModelOutput> forecaster, MLContext mlContext)
        //{
        //    // run forecast
        //    ModelOutput forecast = forecaster.Predict();

        //    // align actuals with forcasted over 7 periods
        //    IEnumerable<string> forecastOutput =
        //    mlContext.Data.CreateEnumerable<ModelInput>(testData, reuseRowObject: false)
        //        .Take(horizon)
        //        .Select((ModelInput rental, int index) =>
        //        {
        //            string rentalDate = rental.Date.ToShortDateString();
        //            float actualRentals = rental.ClosingValue;
        //            float lowerEstimate = Math.Max(0, forecast.LowerBoundClosingValue[index]);
        //            float estimate = forecast.ForecastedClosingValue[index];
        //            float upperEstimate = forecast.UpperBoundClosingValue[index];
        //            return $"Date: {rentalDate}\n" +
        //            $"Actual Closing: {actualRentals}\n" +
        //            $"Lower Estimate: {lowerEstimate}\n" +
        //            $"Forecast: {estimate}\n" +
        //            $"Upper Estimate: {upperEstimate}\n";
        //        });

        //    // display the output of the forecast to the console
        //    Console.WriteLine("Stock Price Forecast");
        //    Console.WriteLine("---------------------");
        //    foreach (var prediction in forecastOutput)
        //    {
        //        Console.WriteLine(prediction);
        //    }
        //}
    }

    public class ModelInput
    {
        public DateTime Date { get; set; }

        public float Year { get; set; }

        public float ClosingValue { get; set; }
    }

    public class ModelOutput
    {
        public float[] ForecastedClosingValue { get; set; }

        public float[] LowerBoundClosingValue { get; set; }

        public float[] UpperBoundClosingValue { get; set; }
    }
}