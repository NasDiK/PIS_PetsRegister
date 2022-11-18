using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

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

    public virtual DbSet<PetCategory> PetCategories { get; set; }

    public virtual DbSet<Photography> Photographies { get; set; }

    public virtual DbSet<Response> Responses { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Settlement> Settlements { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data source=./services/database/database.db");

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

        modelBuilder.Entity<Response>(entity =>
        {
            entity.Property(e => e.AdvertismentId).HasColumnName("Advertisment_Id");
            entity.Property(e => e.IsGeneral)
                .HasColumnType("BOOLEAN")
                .HasColumnName("isGeneral");
            entity.Property(e => e.UserId).HasColumnName("User_Id");

            entity.HasOne(d => d.Advertisment).WithMany(p => p.Responses)
                .HasForeignKey(d => d.AdvertismentId)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.User).WithMany(p => p.Responses)
                .HasForeignKey(d => d.UserId)
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
