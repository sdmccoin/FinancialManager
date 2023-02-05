using FinancialManager.Data.Repositories;
using System;
using System.Collections.Generic;

namespace FinancialManager.Data.Models;

public partial class User : EntityBase
{
    public long Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;
}
