using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace workbook4.Models
{
    public partial class COMP2001_JYarnoldContext : DbContext
    {
        public COMP2001_JYarnoldContext()
        {
        }

        public COMP2001_JYarnoldContext(DbContextOptions<COMP2001_JYarnoldContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AvailableTable> AvailableTables { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomersTablesAndTime> CustomersTablesAndTimes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Pub> Pubs { get; set; }
        public virtual DbSet<TableAndSeat> TableAndSeats { get; set; }
        public virtual DbSet<VIdentifyPerson> VIdentifyPeople { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer("Server=socem1.uopnet.plymouth.ac.uk; Database=COMP2001_JYarnold; User ID=Jyarnold; Password=MaqC175*");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AvailableTable>(entity =>
            {
                entity.HasKey(e => new { e.PubId, e.TableId });

                entity.Property(e => e.PubId).HasColumnName("Pub_ID");

                entity.Property(e => e.TableId).HasColumnName("Table_ID");

                entity.HasOne(d => d.Pub)
                    .WithMany(p => p.AvailableTables)
                    .HasForeignKey(d => d.PubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AvailableTablesPub_ID");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.AvailableTables)
                    .HasForeignKey(d => d.TableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AvailableTablesTable_ID");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerReferenceId)
                    .HasName("PK_Customer");

                entity.Property(e => e.CustomerReferenceId).HasColumnName("CustomerReference_ID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomersTablesAndTime>(entity =>
            {
                entity.HasKey(e => e.CtatTableReference)
                    .HasName("PK_CustomerTable");

                entity.Property(e => e.CtatTableReference).HasColumnName("CTAT_TableReference");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.DateArrived).HasColumnType("date");

                entity.Property(e => e.TableId).HasColumnName("Table_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomersTablesAndTimes)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_CustomerTableCustomer_ID");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.CustomersTablesAndTimes)
                    .HasForeignKey(d => d.TableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_CustomerTableTable_ID");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.Customer)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.OrderDate).HasColumnType("date");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId });

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderDetailS");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductIDOrderID");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductDetails)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("Product_Details");
            });

            modelBuilder.Entity<Pub>(entity =>
            {
                entity.Property(e => e.PubId).HasColumnName("Pub_ID");

                entity.Property(e => e.PubName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TableAndSeat>(entity =>
            {
                entity.HasKey(e => e.TableId);

                entity.Property(e => e.TableId).HasColumnName("Table_ID");
            });

            modelBuilder.Entity<VIdentifyPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_IdentifyPeople");

                entity.Property(e => e.DateArrived).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
