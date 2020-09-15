using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SES1B.Models
{
    public partial class RestaurantContext : DbContext
    {
        public RestaurantContext()
        {
        }

        public RestaurantContext(DbContextOptions<RestaurantContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MenuItems> MenuItems { get; set; }
        public virtual DbSet<Order> Order {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=restaurantdb.cvz3e6ne8iwm.ap-southeast-2.rds.amazonaws.com;database=Restaurant;uid=root;pwd=$E$1Bcovid19", x => x.ServerVersion("8.0.17-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //model builder for MenuItems
            modelBuilder.Entity<MenuItems>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Availability)
                    .HasColumnName("availability")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(5,2)");
            });

            //model builder for Order 
            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderID)
                    .HasColumnName("OrderID")
                    .HasColumnType("int(10)");

                entity.Property(e => e.BookingID)
                    .HasColumnName("BookingID")
                    .HasColumnType("int(11)");
            });

            //model builder for MenuItems
            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.Property(e => e.idReservation)
                    .HasColumnName("idReservation")
                    .HasColumnType("int(1)");
                
                entity.Property(e => e.numPeople)
                    .HasColumnName("numPeople")
                    .HasColumnType("int(2)");

                entity.Property(e => e.tableNum)
                    .HasColumnName("tableNum")
                    .HasColumnType("int(13)");

                entity.Property(e => e.specialRequest)
                    .HasColumnName("specialRequest")
                    .HasColumnType("String(1)");

                entity.Property(e => e.phoneNum)
                    .HasColumnName("phoneNum")
                    .HasColumnType("int(1)");
                
                entity.Property(e => e.dateandtime)
                    .HasColumnName("dateandtime")
                    .HasColumnType("int(1)");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
