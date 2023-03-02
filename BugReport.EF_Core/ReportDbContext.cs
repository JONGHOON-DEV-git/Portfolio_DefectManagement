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

    public virtual DbSet<CodeMaster> CodeMasters { get; set; }

    public virtual DbSet<DefectComment> DefectComments { get; set; }

    public virtual DbSet<DefectReport> DefectReports { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<vw_DefectReportInfo> VwDefectReportInfos { get; set; }

    public virtual DbSet<vw_UserInfo> VwUserInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=localhost,1433;user ID=sa;Password=si1234;Initial Catalog=ReportDB; Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CodeMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CodeMaster");

            entity.Property(e => e.CommCd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CommCD");
            entity.Property(e => e.CommNm)
                .HasMaxLength(20)
                .HasColumnName("CommNM");
            entity.Property(e => e.CommNmEn)
                .HasMaxLength(20)
                .HasColumnName("CommNM_EN");
            entity.Property(e => e.ParCommCd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ParCommCD");
        });

        modelBuilder.Entity<DefectComment>(entity =>
        {
            entity.ToTable("DefectComment");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AfterStatusCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BeforeStatusCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Comment).HasMaxLength(500);
            entity.Property(e => e.DefectReportId).HasColumnName("DefectReportID");
            entity.Property(e => e.ModfDtm).HasColumnType("datetime");
            entity.Property(e => e.ModfId).HasColumnName("ModfID");
            entity.Property(e => e.RegDtm).HasColumnType("datetime");
            entity.Property(e => e.RegId).HasColumnName("RegID");
        });

        modelBuilder.Entity<DefectReport>(entity =>
        {
            entity.HasKey(e => e.DefectReportId).HasName("PK_BugReport");

            entity.ToTable("DefectReport");

            entity.Property(e => e.DefectReportId).HasColumnName("DefectReportID");
            entity.Property(e => e.CategoryCode)
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
            entity.Property(e => e.StatusCode)
                .HasMaxLength(10)
                .IsUnicode(false);
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

        modelBuilder.Entity<vw_DefectReportInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DefectReportInfo");

            entity.Property(e => e.CategoryCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CategoryName).HasMaxLength(20);
            entity.Property(e => e.DefectReportId).HasColumnName("DefectReportID");
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
            entity.Property(e => e.StatusCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StatusName).HasMaxLength(20);
            entity.Property(e => e.Summary).HasMaxLength(50);
        });

        modelBuilder.Entity<vw_UserInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_UserInfo");

            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("UserID");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
