using FinancialManagerLibrary.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace FinancialManagerLibrary.Data.Models;

public partial class User : IEntity
{
    public long Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Expense> Expenses { get; } = new List<Expense>();

    public virtual ICollection<Income> Incomes { get; } = new List<Income>();

    public virtual ICollection<Investment> Investments { get; } = new List<Investment>();

    public virtual ICollection<Notification> Notifications { get; } = new List<Notification>();

    public virtual ICollection<Reminder> Reminders { get; } = new List<Reminder>();
}
