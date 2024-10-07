using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RobertoPinedaWin.Models;

public partial class RobertoPinedaContext : DbContext
{
    public RobertoPinedaContext()
    {
    }

    public RobertoPinedaContext(DbContextOptions<RobertoPinedaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=XTABLET\\SQLEXPRESS;Database=RobertoPineda;Trusted_Connection=True; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6CD78366367");

            entity.Property(e => e.ProductName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SupplierName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 0)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
