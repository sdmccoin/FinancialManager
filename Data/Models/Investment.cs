using FinancialManager.Data.Repositories;
using System;
using System.Collections.Generic;

namespace FinancialManager.Data.Models;

public partial class Investment : EntityBase
{
    public long Id { get; set; }

    public string Source { get; set; } = null!;

    public string Amount { get; set; } = null!;

    public long UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
