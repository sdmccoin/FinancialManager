using FinancialManager.Data.Repositories;
using System;
using System.Collections.Generic;

namespace FinancialManager.Data.Models;

public partial class Income : EntityBase
{
    public long Id { get; set; }

    public string Source { get; set; } = null!;

    public string Amount { get; set; } = null!;

    public string? Address { get; set; }

    public string Frequency { get; set; } = null!;
}
