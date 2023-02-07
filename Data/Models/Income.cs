using FinancialManager.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace FinancialManager.Data.Models;

public partial class Income : IEntity
{
    public long Id { get; set; }

    public string Source { get; set; } = null!;

    public string Amount { get; set; } = null!;

    public string? Address { get; set; }

    public string Frequency { get; set; } = null!;

    public long UserId { get; set; }

    public virtual ICollection<IncomeNotification> IncomeNotifications { get; } = new List<IncomeNotification>();

    public virtual ICollection<IncomeReminder> IncomeReminders { get; } = new List<IncomeReminder>();

    public virtual User User { get; set; } = null!;
}
