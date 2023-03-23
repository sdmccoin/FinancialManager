using FinancialManagerLibrary.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace FinancialManagerLibrary.Data.Models;

public partial class IncomeNotification : IEntity
{
    public long Id { get; set; }

    public long IncomeId { get; set; }

    public long NotificationId { get; set; }

    public virtual Notification Notification { get; set; } = null!;
}
