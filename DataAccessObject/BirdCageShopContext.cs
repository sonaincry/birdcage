using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BussinessObject.Models;
using Microsoft.Extensions.Configuration;

namespace DataAccessObject;

public partial class BirdCageShopContext : DbContext
{
    public BirdCageShopContext()
    {
    }

    public BirdCageShopContext(DbContextOptions<BirdCageShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Accessory> Accessories { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(GetConnectionString());
    protected string GetConnectionString()
    {
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
        IConfiguration configuration = builder.Build();
        return configuration.GetConnectionString("DefaultConnection");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accessory>(entity =>
        {
            entity.HasKey(e => e.AccessoryId).HasName("PK__Accessor__09C3F0FB41DF1E04");

            entity.ToTable("Accessory");

            entity.Property(e => e.AccessoryId)
                .HasMaxLength(20)
                .HasColumnName("AccessoryID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.MaterialId).HasName("PK__Material__C50613174E120B6C");

            entity.ToTable("Material");

            entity.Property(e => e.MaterialId)
                .HasMaxLength(20)
                .HasColumnName("MaterialID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Order__C3905BAF2D0E41AA");

            entity.ToTable("Order");

            entity.Property(e => e.OrderId)
                .HasMaxLength(20)
                .HasColumnName("OrderID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Order__UserID__5812160E");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.OrderDetailId).HasName("PK__OrderDet__D3B9D30CD68479D6");

            entity.ToTable("OrderDetail");

            entity.Property(e => e.OrderDetailId)
                .HasMaxLength(20)
                .HasColumnName("OrderDetailID");
            entity.Property(e => e.OrderId)
                .HasMaxLength(20)
                .HasColumnName("OrderID");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProductId)
                .HasMaxLength(20)
                .HasColumnName("ProductID");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__OrderDeta__Order__5BE2A6F2");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__OrderDeta__Produ__5AEE82B9");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__B40CC6ED45FCE98E");

            entity.ToTable("Product");

            entity.Property(e => e.ProductId)
                .HasMaxLength(20)
                .HasColumnName("ProductID");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Spoke).HasColumnName("spoke");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasMany(d => d.Accessories).WithMany(p => p.Products)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductAccessory",
                    r => r.HasOne<Accessory>().WithMany()
                        .HasForeignKey("AccessoryId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ProductAc__Acces__412EB0B6"),
                    l => l.HasOne<Product>().WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ProductAc__Produ__403A8C7D"),
                    j =>
                    {
                        j.HasKey("ProductId", "AccessoryId").HasName("PK__ProductA__1490F9E2BE2F1BF7");
                        j.ToTable("ProductAccessory");
                        j.IndexerProperty<string>("ProductId")
                            .HasMaxLength(20)
                            .HasColumnName("ProductID");
                        j.IndexerProperty<string>("AccessoryId")
                            .HasMaxLength(20)
                            .HasColumnName("AccessoryID");
                    });

            entity.HasMany(d => d.Materials).WithMany(p => p.Products)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductMaterial",
                    r => r.HasOne<Material>().WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ProductMa__Mater__3B75D760"),
                    l => l.HasOne<Product>().WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ProductMa__Produ__3A81B327"),
                    j =>
                    {
                        j.HasKey("ProductId", "MaterialId").HasName("PK__ProductM__D85CA7DC18DE105C");
                        j.ToTable("ProductMaterial");
                        j.IndexerProperty<string>("ProductId")
                            .HasMaxLength(20)
                            .HasColumnName("ProductID");
                        j.IndexerProperty<string>("MaterialId")
                            .HasMaxLength(20)
                            .HasColumnName("MaterialID");
                    });
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CCACC695CD0D");

            entity.ToTable("User");

            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("UserID");
            entity.Property(e => e.Email).HasMaxLength(30);
            entity.Property(e => e.Fullname).HasMaxLength(30);
            entity.Property(e => e.Password).HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
