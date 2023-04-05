using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FinancialManagerLibrary.Data.Models;

public partial class FinancialManagerContext : DbContext
{
    public FinancialManagerContext()
    {
    }

    public FinancialManagerContext(DbContextOptions<FinancialManagerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Expense> Expenses { get; set; }

    public virtual DbSet<ExpenseReminder> ExpenseReminders { get; set; }

    public virtual DbSet<Income> Incomes { get; set; }

    public virtual DbSet<IncomeNotification> IncomeNotifications { get; set; }

    public virtual DbSet<IncomeReminder> IncomeReminders { get; set; }

    public virtual DbSet<Investment> Investments { get; set; }

    public virtual DbSet<InvestmentNotification> InvestmentNotifications { get; set; }

    public virtual DbSet<InvestmentReminder> InvestmentReminders { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Reminder> Reminders { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<StockAnalysis> StockAnalyses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=C:\\git\\src\\FinancialManager\\FinancialManagerLibrary\\DataSources\\sqlite\\FinancialManager.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Expense>(entity =>
        {
            entity.ToTable("Expense");

            entity.Property(e => e.Amount).HasColumnType("TEXT (50)");
            entity.Property(e => e.Date).HasColumnType("TEXT (25)");
            entity.Property(e => e.Source).HasColumnType("TEXT (100)");

            entity.HasOne(d => d.User).WithMany(p => p.Expenses)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ExpenseReminder>(entity =>
        {
            entity.ToTable("ExpenseReminder");

            entity.HasIndex(e => e.Id, "IX_ExpenseReminder_Id").IsUnique();

            entity.HasOne(d => d.Expense).WithMany(p => p.ExpenseReminders)
                .HasForeignKey(d => d.ExpenseId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Reminder).WithMany(p => p.ExpenseReminders)
                .HasForeignKey(d => d.ReminderId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Income>(entity =>
        {
            entity.ToTable("Income");

            entity.Property(e => e.Amount).HasColumnType("TEXT (50)");
            entity.Property(e => e.Date).HasColumnType("TEXT (25)");
            entity.Property(e => e.Source).HasColumnType("TEXT (100)");

            entity.HasOne(d => d.User).WithMany(p => p.Incomes)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<IncomeNotification>(entity =>
        {
            entity.ToTable("IncomeNotification");

            entity.HasIndex(e => e.Id, "IX_IncomeNotification_Id").IsUnique();

            entity.HasOne(d => d.Notification).WithMany(p => p.IncomeNotifications)
                .HasForeignKey(d => d.NotificationId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<IncomeReminder>(entity =>
        {
            entity.ToTable("IncomeReminder");

            entity.HasIndex(e => e.Id, "IX_IncomeReminder_Id").IsUnique();

            entity.HasOne(d => d.Income).WithMany(p => p.IncomeReminders)
                .HasForeignKey(d => d.IncomeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Reminder).WithMany(p => p.IncomeReminders)
                .HasForeignKey(d => d.ReminderId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Investment>(entity =>
        {
            entity.HasIndex(e => e.Id, "IX_Investments_Id").IsUnique();

            entity.Property(e => e.Amount).HasColumnType("TEXT (50)");
            entity.Property(e => e.Date).HasColumnType("TEXT (25)");
            entity.Property(e => e.LastMonitorCheck)
                .HasDefaultValueSql("4 / 1 / 2023")
                .HasColumnType("TEXT (25)");
            entity.Property(e => e.Source).HasColumnType("TEXT (150)");

            entity.HasOne(d => d.User).WithMany(p => p.Investments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<InvestmentNotification>(entity =>
        {
            entity.ToTable("InvestmentNotification");

            entity.HasIndex(e => e.Id, "IX_InvestmentNotification_Id").IsUnique();

            entity.Property(e => e.Date).HasColumnType("TEXT (20)");
            entity.Property(e => e.Message).HasColumnType("TEXT (200)");
            entity.Property(e => e.Symbol).HasColumnType("TEXT (10)");
        });

        modelBuilder.Entity<InvestmentReminder>(entity =>
        {
            entity.ToTable("InvestmentReminder");

            entity.HasIndex(e => e.Id, "IX_InvestmentReminder_Id").IsUnique();

            entity.HasIndex(e => e.InvestmentId, "IX_InvestmentReminder_InvestmentId").IsUnique();

            entity.HasIndex(e => e.ReminderId, "IX_InvestmentReminder_ReminderId").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Investment).WithOne(p => p.InvestmentReminder)
                .HasForeignKey<InvestmentReminder>(d => d.InvestmentId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.ToTable("Notification");

            entity.HasIndex(e => e.Id, "IX_Notification_Id").IsUnique();

            entity.Property(e => e.Message).HasColumnType("TEXT (150)");

            entity.HasOne(d => d.User).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Reminder>(entity =>
        {
            entity.ToTable("Reminder");

            entity.HasIndex(e => e.Id, "IX_Reminder_Id").IsUnique();

            entity.Property(e => e.Date).HasColumnType("TEXT (15)");
            entity.Property(e => e.Enabled).HasDefaultValueSql("1");
            entity.Property(e => e.Frequency).HasColumnType("TEXT (10)");
            entity.Property(e => e.Message).HasColumnType("TEXT (150)");
            entity.Property(e => e.Time).HasColumnType("TEXT (10)");

            entity.HasOne(d => d.User).WithMany(p => p.Reminders)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasIndex(e => e.Id, "IX_Settings_Id").IsUnique();

            entity.Property(e => e.ConfidenceLevel)
                .HasDefaultValueSql("0.95")
                .HasColumnType("TEXT (10)");
            entity.Property(e => e.EmailAddress).HasColumnType("TEXT (50)");
            entity.Property(e => e.Phone).HasColumnType("TEXT (15)");
            entity.Property(e => e.PredictionTimeInterval).HasDefaultValueSql("1");
            entity.Property(e => e.RemindersEnabled)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER (2)");
        });

        modelBuilder.Entity<StockAnalysis>(entity =>
        {
            entity.ToTable("StockAnalysis");

            entity.HasIndex(e => e.Id, "IX_StockAnalysis_Id").IsUnique();

            entity.Property(e => e.Date).HasColumnType("TEXT (15)");
            entity.Property(e => e.Symbol).HasColumnType("TEXT (10)");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Password).HasColumnType("TEXT (50)");
            entity.Property(e => e.UserName).HasColumnType("TEXT (50)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
