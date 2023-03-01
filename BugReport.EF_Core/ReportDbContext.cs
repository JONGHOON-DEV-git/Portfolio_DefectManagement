using System;
using System.Collections.Generic;
using BugReport.EF_Core.models;
using Microsoft.EntityFrameworkCore;

namespace BugReport.EF_Core;

public partial class ReportDbContext : DbContext
{
    public ReportDbContext()
    {
    }

    public ReportDbContext(DbContextOptions<ReportDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DefectReport> DefectReports { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=localhost,1433;user ID=sa;Password=si1234;Initial Catalog=ReportDB; Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DefectReport>(entity =>
        {
            entity.HasKey(e => e.Seq).HasName("PK_BugReport");

            entity.ToTable("DefectReport");

            entity.Property(e => e.CategorySystemCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ModfDtm).HasColumnType("datetime");
            entity.Property(e => e.ModfIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ModfIP");
            entity.Property(e => e.RegDtm).HasColumnType("datetime");
            entity.Property(e => e.RegIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RegIP");
            entity.Property(e => e.Summary).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3214EC0743F07B53");

            entity.ToTable("User");

            entity.Property(e => e.ModfDtm)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(64);
            entity.Property(e => e.RegDtm)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("UserID");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
