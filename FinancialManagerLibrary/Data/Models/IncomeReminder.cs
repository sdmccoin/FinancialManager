using FinancialManagerLibrary.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace FinancialManagerLibrary.Data.Models;

public partial class IncomeReminder : IEntity
{
    public long Id { get; set; }

    public long IncomeId { get; set; }

    public long ReminderId { get; set; }

    public virtual Income Income { get; set; } = null!;

    public virtual Reminder Reminder { get; set; } = null!;
}
