using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace schoolManagementApp.mvc.Data;

public partial class GearsSquadDbContext : DbContext
{
    public GearsSquadDbContext(DbContextOptions<GearsSquadDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Commander> Commanders { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<Squad> Squads { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Commander>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Commande__3213E83F2560F02B");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Players__3213E83F5EC2756D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("DOB");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");
        });

        modelBuilder.Entity<Squad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Squad__3213E83FEEFB045C");

            entity.ToTable("Squad");

            entity.HasIndex(e => e.Code, "UQ__Squad__A25C5AA708F692D1").IsUnique();

            entity.HasIndex(e => e.Rank, "UQ__Squad__DF85EC57F1AD9E60").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasMaxLength(5);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
