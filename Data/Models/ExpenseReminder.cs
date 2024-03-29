﻿using System;
using System.Collections.Generic;

namespace FinancialManager.Data.Models;

public partial class ExpenseReminder
{
    public long Id { get; set; }

    public long ExpenseId { get; set; }

    public long ReminderId { get; set; }

    public virtual Expense Expense { get; set; } = null!;

    public virtual Reminder Reminder { get; set; } = null!;
}
