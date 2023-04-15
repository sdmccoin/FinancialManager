using System;
using System.Collections.Generic;

namespace FinancialManager.Data.Models;

public partial class Expense
{
    public long Id { get; set; }

    public string Source { get; set; } = null!;

    public string Amount { get; set; } = null!;

    public long UserId { get; set; }

    public string? Date { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<ExpenseReminder> ExpenseReminders { get; } = new List<ExpenseReminder>();

    public virtual User User { get; set; } = null!;
}
