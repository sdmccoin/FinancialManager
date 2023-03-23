using System;
using System.Collections.Generic;

namespace FinancialManager.Data.Models;

public partial class Notification
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string Message { get; set; } = null!;

    public virtual ICollection<IncomeNotification> IncomeNotifications { get; } = new List<IncomeNotification>();

    public virtual User User { get; set; } = null!;
}
