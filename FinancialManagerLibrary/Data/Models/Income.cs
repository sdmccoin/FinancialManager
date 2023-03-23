using FinancialManagerLibrary.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace FinancialManagerLibrary.Data.Models;

public partial class Income : IEntity
{
    public long Id { get; set; }

    public string Source { get; set; } = null!;

    public string Amount { get; set; } = null!;

    public long UserId { get; set; }

    public string? Date { get; set; }

    public virtual ICollection<IncomeReminder> IncomeReminders { get; } = new List<IncomeReminder>();

    public virtual User User { get; set; } = null!;
}
