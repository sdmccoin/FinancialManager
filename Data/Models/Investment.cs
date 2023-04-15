using System;
using System.Collections.Generic;

namespace FinancialManager.Data.Models;

public partial class Investment
{
    public long Id { get; set; }

    public string Source { get; set; } = null!;

    public string Amount { get; set; } = null!;

    public long UserId { get; set; }

    public string? Date { get; set; }

    public long Monitor { get; set; }

    public string LastMonitorCheck { get; set; } = null!;

    public string? Notes { get; set; }

    public virtual InvestmentReminder? InvestmentReminder { get; set; }

    public virtual User User { get; set; } = null!;
}
