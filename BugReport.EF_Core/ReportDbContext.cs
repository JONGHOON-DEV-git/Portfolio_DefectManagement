using System;
using System.Collections.Generic;
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

    public virtual DbSet<BugReport> BugReports { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Data Source=localhost,1433;user ID=sa;Password=si1234;Initial Catalog=ReportDB; Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BugReport>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("BugReport");

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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
