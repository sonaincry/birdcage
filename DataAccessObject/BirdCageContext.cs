using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BussinessObject.Models;
using Microsoft.Extensions.Configuration;

namespace DataAccessObject;

public partial class BirdCageContext : DbContext
{
    public BirdCageContext()
    {
    }

    public BirdCageContext(DbContextOptions<BirdCageContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<NewProduct> NewProducts { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

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
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccId).HasName("PK__Accounts__A471AFFA4639A675");

            entity.HasIndex(e => e.Email, "UQ__Accounts__AB6E6164712FBB96").IsUnique();

            entity.Property(e => e.AccId).HasColumnName("accID");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Fullname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("fullname");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CateId).HasName("PK__Categori__27638D7424B7B70D");

            entity.Property(e => e.CateId).HasColumnName("CateID");
            entity.Property(e => e.CateName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.MaterialId).HasName("PK__Material__C50613176A5F797A");

            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.MaterialName).HasMaxLength(50);
        });

        modelBuilder.Entity<NewProduct>(entity =>
        {
            entity.HasKey(e => e.Idpro).HasName("PK__NewProdu__98F928599302FBC1");

            entity.ToTable("NewProduct");

            entity.Property(e => e.Idpro).HasColumnName("IDPro");
            entity.Property(e => e.CateId).HasColumnName("CateID");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.Materiel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("materiel");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PName");
            entity.Property(e => e.Size)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("size");

            entity.HasOne(d => d.Cate).WithMany(p => p.NewProducts)
                .HasForeignKey(d => d.CateId)
                .HasConstraintName("FK__NewProduc__CateI__52593CB8");

            entity.HasOne(d => d.Material).WithMany(p => p.NewProducts)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK__NewProduc__Mater__534D60F1");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Orders__C3905BAF2BE5DE7F");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.AccId).HasColumnName("AccID");
            entity.Property(e => e.OrdDate).HasColumnType("date");
            entity.Property(e => e.Shipdate)
                .HasColumnType("date")
                .HasColumnName("shipdate");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Acc).WithMany(p => p.Orders)
                .HasForeignKey(d => d.AccId)
                .HasConstraintName("FK__Orders__AccID__5BE2A6F2");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.DetailId).HasName("PK__OrderDet__135C316D1834C11B");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__OrderDeta__Order__5EBF139D");

            entity.HasOne(d => d.PidNavigation).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.Pid)
                .HasConstraintName("FK__OrderDetail__PID__5FB337D6");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__Product__C5775520DAB69F20");

            entity.ToTable("Product");

            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.CateId).HasColumnName("CateID");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Pname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PName");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Cate).WithMany(p => p.Products)
                .HasForeignKey(d => d.CateId)
                .HasConstraintName("FK__Product__CateID__5812160E");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
