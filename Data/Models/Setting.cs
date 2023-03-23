using System;
using System.Collections.Generic;

namespace FinancialManager.Data.Models;

public partial class Setting
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string? EmailAddress { get; set; }

    public string? Phone { get; set; }
}
