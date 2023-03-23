﻿using System;
using System.Collections.Generic;

namespace FinancialManager.Data.Models;

public partial class Investment
{
    public long Id { get; set; }

    public string Source { get; set; } = null!;

    public string Amount { get; set; } = null!;

    public long UserId { get; set; }

    public string Frequency { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? Date { get; set; }

    public virtual InvestmentReminder? InvestmentReminder { get; set; }

    public virtual User User { get; set; } = null!;
}
