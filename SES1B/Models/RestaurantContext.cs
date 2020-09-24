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

        public virtual DbSet<User> User { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // #warning directive
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=restaurantdb.cvz3e6ne8iwm.ap-southeast-2.rds.amazonaws.com;database=Restaurant;uid=root;pwd=$E$1Bcovid19", x => x.ServerVersion("8.0.17-mysql"));
#pragma warning restore CS1030 // #warning directive
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


            //Model builder for the User 
            modelBuilder.Entity<User>(entity =>
           {
               entity.Property(e => e.userId)
               .HasColumnName("UserID")
               .HasColumnType("int(11)");

               entity.Property(e => e.firstName)
               .HasColumnName("First Name")
               .HasColumnType("varchar(50)");

               entity.Property(e => e.lastName)
               .HasColumnName("Last Name")
               .HasColumnType("varchar(50)");

               entity.Property(e => e.email)
               .HasColumnName("Email")
               .HasColumnType("varchar(100)");

               entity.Property(e => e.password)
               .HasColumnName("Password")
               .HasColumnType("varchar(50)");

               entity.Property(e => e.DOB)
               .HasColumnName("DOB");

               entity.Property(e => e.phoneNumber)
               .HasColumnName("Phone Number")
               .HasColumnType("varchar(10)");

               entity.Property(e => e.loyaltyNumber)
               .HasColumnName("Loyalty Member")
               .HasColumnType("varchar(10)");
           });

            OnModelCreatingPartial(modelBuilder);
        }

        private void HasColumnType(string v)
        {
            throw new NotImplementedException();
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
