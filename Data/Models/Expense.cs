using FinancialManager.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace FinancialManager.Data.Models;

public partial class Expense : IEntity
{
    public long Id { get; set; }

    public string Source { get; set; } = null!;

    public string Amount { get; set; } = null!;

    public string? Address { get; set; }

    public string Frequency { get; set; } = null!;

    public long UserId { get; set; }

    public virtual ICollection<ExpenseReminder> ExpenseReminders { get; } = new List<ExpenseReminder>();

    public virtual User User { get; set; } = null!;
}
