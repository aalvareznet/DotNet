using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Memberships.Models;

public partial class MemberSecurityContext : DbContext
{
    public MemberSecurityContext()
    {
    }

    public MemberSecurityContext(DbContextOptions<MemberSecurityContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Membership> Memberships { get; set; }

    public virtual DbSet<MembershipByUser> MembershipByUsers { get; set; }

    public virtual DbSet<MembershipStatus> MembershipStatuses { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<PermissionByUser> PermissionByUsers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-N71U620; Database=MemberSecurity; Trusted_Connection=True; Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Membership>(entity =>
        {
            entity.HasKey(e => e.MembershipId).HasName("PK__Membersh__92A786795F0463EA");

            entity.ToTable("Membership");

            entity.Property(e => e.MembershipDesc)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MembershipByUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MembershipByUser");

            entity.HasOne(d => d.Membership).WithMany()
                .HasForeignKey(d => d.MembershipId)
                .HasConstraintName("FK__Membershi__Membe__4316F928");

            entity.HasOne(d => d.MembershipStatus).WithMany()
                .HasForeignKey(d => d.MembershipStatusId)
                .HasConstraintName("FK__Membershi__Membe__5AEE82B9");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Membershi__UserI__4222D4EF");
        });

        modelBuilder.Entity<MembershipStatus>(entity =>
        {
            entity.HasKey(e => e.MembershipStatusId).HasName("PK__Membersh__28E683DAA963308A");

            entity.ToTable("MembershipStatus");

            entity.Property(e => e.MembershipStatusDesc)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.PersmissionId).HasName("PK__Permissi__28A4FF65D356582A");

            entity.ToTable("Permission");

            entity.Property(e => e.PermissionDesc)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PermissionByUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PermissionByUser");

            entity.HasOne(d => d.Permission).WithMany()
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("FK__Permissio__Permi__3B75D760");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Permissio__UserI__3A81B327");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4CC7BC11D7");

            entity.Property(e => e.PasswordHash)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
