using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WinFormsApplication.Models.Entities;

namespace WinFormsApplication;

public partial class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Advertisment> Advertisments { get; set; }

    public virtual DbSet<Pet> Pets { get; set; }

    public virtual DbSet<PetCategory> PetCategories { get; set; }

    public virtual DbSet<Photography> Photographies { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Settlement> Settlements { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data source=../../../services/database/database.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Advertisment>(entity =>
        {
            entity.Property(e => e.PetCategoryId).HasColumnName("PetCategory_Id");
            entity.Property(e => e.PetOwnerId).HasColumnName("PetOwner_Id");
            entity.Property(e => e.SettlementId).HasColumnName("Settlement_Id");

            entity.HasOne(d => d.PetCategory).WithMany(p => p.Advertisments)
                .HasForeignKey(d => d.PetCategoryId)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.PetOwner).WithMany(p => p.Advertisments)
                .HasForeignKey(d => d.PetOwnerId)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.Settlement).WithMany(p => p.Advertisments)
                .HasForeignKey(d => d.SettlementId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<Pet>(entity =>
        {
            entity.HasOne(d => d.Owner).WithMany(p => p.Pets)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Photography>(entity =>
        {
            entity.Property(e => e.AdvertismentId).HasColumnName("Advertisment_Id");
            entity.Property(e => e.IsGeneral)
                .HasColumnType("BOOLEAN")
                .HasColumnName("isGeneral");

            entity.HasOne(d => d.Advertisment).WithMany(p => p.Photographies)
                .HasForeignKey(d => d.AdvertismentId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
