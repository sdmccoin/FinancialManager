using FinancialManagerLibrary.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace FinancialManagerLibrary.Data.Models;

public partial class StockAnalysis : IEntity
{
    public long Id { get; set; }

    public string Symbol { get; set; } = null!;

    public string ClosingValue { get; set; } = null!;

    public long UserId { get; set; }

    public string Date { get; set; } = null!;
}
