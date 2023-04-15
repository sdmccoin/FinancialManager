using FinancialManagerLibrary.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace FinancialManagerLibrary.Data.Models;

public partial class InvestmentNotification : IEntity
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string Message { get; set; } = null!;

    public string Symbol { get; set; } = null!;

    public string Date { get; set; } = null!;

    public long? InvestmentId { get; set; }

    public long Enabled { get; set; }
}
