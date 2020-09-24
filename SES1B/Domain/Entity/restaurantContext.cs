using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SES1BBackendAPI.Domain.Entity
{
    public partial class RestaurantContext : DbContext
    {

        public RestaurantContext(DbContextOptions<RestaurantContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Menuitems> Menuitems { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Orderitems> Orderitems { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Table> Table { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("booking");

                entity.HasIndex(e => e.BookingId)
                    .HasName("BookingID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.CustomerId)
                    .HasName("UserID_idx");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.NumberOfPeople).HasColumnName("Number of People");

                entity.Property(e => e.OrderPlaced).HasColumnName("Order Placed?");

                entity.Property(e => e.SpecialRequests)
                    .HasColumnName("Special Requests")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UserID");
            });

            modelBuilder.Entity<Menuitems>(entity =>
            {
                entity.ToTable("menuitems");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dinner).HasColumnName("Dinner?");

                entity.Property(e => e.Lunch).HasColumnName("Lunch?");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.HasIndex(e => e.BookingId)
                    .HasName("BookingID_idx");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.BookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Booking Number");
            });

            modelBuilder.Entity<Orderitems>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("orderitems");

                entity.HasIndex(e => e.MenuItemId)
                    .HasName("MenuItemID_idx");

                entity.HasIndex(e => e.OrderId)
                    .HasName("OrderID_idx");

                entity.Property(e => e.MenuItemId).HasColumnName("MenuItemID");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasColumnType("int unsigned");

                entity.HasOne(d => d.MenuItem)
                    .WithMany()
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MenuItemID");

                entity.HasOne(d => d.Order)
                    .WithMany()
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OrderID");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("staff");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("ManagerID_idx");

                entity.HasIndex(e => e.StaffId)
                    .HasName("StaffID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId).HasColumnName("Manager ID");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("Phone Number")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("ManagerID");
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.ToTable("table");

                entity.HasIndex(e => e.BookingId)
                    .HasName("BookingID_idx");

                entity.HasIndex(e => e.TableId)
                    .HasName("TableID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.TableId).HasColumnName("TableID");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.Table)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("BookingID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoyaltyMemberNumber)
                    .HasColumnName("Loyalty Member Number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("Phone Number")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
