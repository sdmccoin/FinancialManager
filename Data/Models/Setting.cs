using System;
using System.Collections.Generic;

namespace FinancialManager.Data.Models;

public partial class Setting
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string? EmailAddress { get; set; }

    public string? Phone { get; set; }

    public long PredictionTimeInterval { get; set; }

    public string ConfidenceLevel { get; set; } = null!;

    public long RemindersEnabled { get; set; }

    public long AlertWindowDays { get; set; }
}
