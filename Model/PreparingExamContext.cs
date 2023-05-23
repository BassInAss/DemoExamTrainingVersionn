using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PreparingExmPrj.Model
{
    public partial class PreparingExamContext : DbContext
    {
        public PreparingExamContext()
        {
        }

        public PreparingExamContext(DbContextOptions<PreparingExamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<Point> Points { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-CBSCN3M;database=PreparingExam;integrated security = true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.Property(e => e.IdOrder).HasColumnName("idOrder");

                entity.Property(e => e.IdPoint).HasColumnName("idPoint");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TotalPrice).HasColumnName("total_price");

                entity.HasOne(d => d.IdPointNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdPoint)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Points");
            });

            modelBuilder.Entity<OrderProduct>(entity =>
            {
                entity.HasKey(e => e.IdOrderProducts);

                entity.Property(e => e.IdOrderProducts).HasColumnName("idOrderProducts");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.IdOrder).HasColumnName("idOrder");

                entity.Property(e => e.IdProduct).HasColumnName("idProduct");

                entity.HasOne(d => d.IdOrderNavigation)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.IdOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderProducts_Orders1");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderProducts_Products1");
            });

            modelBuilder.Entity<Point>(entity =>
            {
                entity.HasKey(e => e.IdPoint);

                entity.Property(e => e.IdPoint).HasColumnName("idPoint");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.DeliviryTime).HasColumnName("deliviry_time");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct);

                entity.Property(e => e.IdProduct).HasColumnName("idProduct");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Discription)
                    .HasMaxLength(200)
                    .HasColumnName("discription");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
