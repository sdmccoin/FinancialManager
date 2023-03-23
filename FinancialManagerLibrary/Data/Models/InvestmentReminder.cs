using FinancialManagerLibrary.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace FinancialManagerLibrary.Data.Models;

public partial class InvestmentReminder : IEntity
{
    public long Id { get; set; }

    public long InvestmentId { get; set; }

    public long ReminderId { get; set; }

    public virtual Investment Investment { get; set; } = null!;
}
