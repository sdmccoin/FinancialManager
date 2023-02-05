using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FinancialManager.Data.Models;

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

    public virtual DbSet<Income> Incomes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=C:\\git\\src\\FinancialManager\\DataSources\\sqlite\\FinancialManager.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Expense>(entity =>
        {
            entity.ToTable("Expense");

            entity.Property(e => e.Amount).HasColumnType("TEXT (50)");
            entity.Property(e => e.Sorce).HasColumnType("TEXT (100)");
        });

        modelBuilder.Entity<Income>(entity =>
        {
            entity.ToTable("Income");

            entity.Property(e => e.Address).HasColumnType("TEXT (150)");
            entity.Property(e => e.Amount).HasColumnType("TEXT (50)");
            entity.Property(e => e.Frequency).HasColumnType("TEXT (20)");
            entity.Property(e => e.Source).HasColumnType("TEXT (100)");
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
