using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Pharmacy1.Models
{
    public partial class PharmacyDBContext : DbContext
    {
        public PharmacyDBContext()
        {
        }

        public PharmacyDBContext(DbContextOptions<PharmacyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Firm> Firms { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<MedicineToTag> MedicineToTags { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<OrderItemToMedicine> OrderItemToMedicines { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=MM\\SQLEXPRESS;Initial Catalog=PharmacyDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasIndex(e => e.Phone, "UQ__Admins__5C7E359E44DEFC09")
                    .IsUnique();

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.Fullname).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(350);

                entity.Property(e => e.Phone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RePassword).HasMaxLength(350);
            });

            modelBuilder.Entity<Firm>(entity =>
            {
                entity.Property(e => e.FirmId).HasColumnName("FirmID");

                entity.Property(e => e.FirmName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.Property(e => e.MedicineId).HasColumnName("MedicineID");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.FirmId).HasColumnName("Firm_ID");

                entity.Property(e => e.MedicineName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.Medicines)
                    .HasForeignKey(d => d.FirmId)
                    .HasConstraintName("FK__Medicines__Firm___5DCAEF64");
            });

            modelBuilder.Entity<MedicineToTag>(entity =>
            {
                entity.ToTable("Medicine_To_Tags");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MedicineId).HasColumnName("Medicine_ID");

                entity.Property(e => e.TagId).HasColumnName("Tag_ID");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.MedicineToTags)
                    .HasForeignKey(d => d.MedicineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medicine___Medic__628FA481");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.MedicineToTags)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medicine___Tag_I__6383C8BA");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.AdminId).HasColumnName("Admin_ID");

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.AdminId)
                    .HasConstraintName("FK__Orders__Admin_ID__66603565");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");

                entity.Property(e => e.ItemPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderItem__Order__693CA210");
            });

            modelBuilder.Entity<OrderItemToMedicine>(entity =>
            {
                entity.ToTable("OrderItem_To_Medicines");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MedId).HasColumnName("Med_ID");

                entity.Property(e => e.OrderItemId).HasColumnName("OrderItem_ID");

                entity.HasOne(d => d.Med)
                    .WithMany(p => p.OrderItemToMedicines)
                    .HasForeignKey(d => d.MedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderItem__Med_I__6C190EBB");

                entity.HasOne(d => d.OrderItem)
                    .WithMany(p => p.OrderItemToMedicines)
                    .HasForeignKey(d => d.OrderItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderItem__Order__6D0D32F4");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
