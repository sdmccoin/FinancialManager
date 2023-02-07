using FinancialManager.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace FinancialManager.Data.Models;

public partial class IncomeNotification : IEntity
{
    public long Id { get; set; }

    public long IncomeId { get; set; }

    public long NotificationId { get; set; }

    public virtual Income Income { get; set; } = null!;

    public virtual Notification Notification { get; set; } = null!;
}
