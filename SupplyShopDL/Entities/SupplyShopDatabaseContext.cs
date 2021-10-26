using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SupplyShopDL.Entities
{
    public partial class SupplyShopDatabaseContext : DbContext
    {
        public SupplyShopDatabaseContext()
        {
        }

        public SupplyShopDatabaseContext(DbContextOptions<SupplyShopDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<LineItem> LineItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Storefront> Storefronts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_City");

                entity.Property(e => e.CustEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_Email");

                entity.Property(e => e.CustPhone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("cust_Phone");

                entity.Property(e => e.CustState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_State");

                entity.Property(e => e.CustStreetAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_StreetAdd");

                entity.Property(e => e.CustZip).HasColumnName("cust_Zip");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_Name");

                entity.Property(e => e.OrdersId).HasColumnName("OrdersID");

                entity.HasOne(d => d.Orders)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.OrdersId)
                    .HasConstraintName("FK_OrdersID");
            });

            modelBuilder.Entity<LineItem>(entity =>
            {
                entity.ToTable("LineItem");

                entity.Property(e => e.OrdersId).HasColumnName("OrdersID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Orders)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.OrdersId)
                    .HasConstraintName("frk_OrdersID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("frk_ProductID");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrdersId)
                    .HasName("Pk_OrdersID");

                entity.Property(e => e.OrdersId).HasColumnName("OrdersID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("itemName");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.OrdersNavigation)
                    .HasForeignKey(d => d.LineItemId)
                    .HasConstraintName("fk_LineItemId");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("fk_StoreID");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.ItemDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("itemDesc");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("itemName");

                entity.Property(e => e.ItemPrice).HasColumnName("itemPrice");
            });

            modelBuilder.Entity<Storefront>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("primary_key_StoreID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.OrdersId).HasColumnName("OrdersID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.StoreAdd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Store_City");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Store_State");

                entity.Property(e => e.StoreZip).HasColumnName("Store_Zip");

                entity.HasOne(d => d.OrdersNavigation)
                    .WithMany(p => p.Storefronts)
                    .HasForeignKey(d => d.OrdersId)
                    .HasConstraintName("fork_OrdersID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Storefronts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("fk_ProductID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
