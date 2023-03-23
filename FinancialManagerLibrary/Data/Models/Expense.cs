using FinancialManagerLibrary.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace FinancialManagerLibrary.Data.Models;

public partial class Expense : IEntity
{
    public long Id { get; set; }

    public string Source { get; set; } = null!;

    public string Amount { get; set; } = null!;

    public long UserId { get; set; }

    public string? Date { get; set; }

    public virtual ICollection<ExpenseReminder> ExpenseReminders { get; } = new List<ExpenseReminder>();

    public virtual User User { get; set; } = null!;
}
