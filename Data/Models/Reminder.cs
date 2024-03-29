﻿using System;
using System.Collections.Generic;

namespace FinancialManager.Data.Models;

public partial class Reminder
{
    public long Id { get; set; }

    public string Date { get; set; } = null!;

    public string Time { get; set; } = null!;

    public string? Frequency { get; set; }

    public string Message { get; set; } = null!;

    public long UserId { get; set; }

    public long Enabled { get; set; }

    public virtual ICollection<ExpenseReminder> ExpenseReminders { get; } = new List<ExpenseReminder>();

    public virtual ICollection<IncomeReminder> IncomeReminders { get; } = new List<IncomeReminder>();

    public virtual User User { get; set; } = null!;
}
