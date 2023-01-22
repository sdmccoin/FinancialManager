using System;
using System.Collections.Generic;

namespace FinancialManager.Data.Models;

public partial class Expense
{
    public long Id { get; set; }

    public string Sorce { get; set; } = null!;

    public string Amount { get; set; } = null!;
}
