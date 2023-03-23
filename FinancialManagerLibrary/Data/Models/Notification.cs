using FinancialManagerLibrary.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace FinancialManagerLibrary.Data.Models;

public partial class Notification : IEntity
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string Message { get; set; } = null!;

    public virtual ICollection<IncomeNotification> IncomeNotifications { get; } = new List<IncomeNotification>();

    public virtual User User { get; set; } = null!;
}
