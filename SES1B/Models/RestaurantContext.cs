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

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=restaurantdb.cvz3e6ne8iwm.ap-southeast-2.rds.amazonaws.com;database=Restaurant;uid=root;pwd=12345678", x => x.ServerVersion("8.0.17-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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


            OnModelCreatingPartial(modelBuilder);
            //takes info from database and autogenerates it for the code. All things in quotes match what's in the database


            modelBuilder.Entity<User>(entity =>
           {
               entity.Property(e => e.userId)
               .HasColumnName("UserId");

               entity.Property(e => e.firstName)
               .HasColumnName("First Name");

               entity.Property(e => e.lastName)
               .HasColumnName("Last Name");

               entity.Property(e => e.email)
               .HasColumnName("Email");

               entity.Property(e => e.password)
               .HasColumnName("Password");

               entity.Property(e => e.DOB)
               .HasColumnName("DOB");

               entity.Property(e => e.phoneNumber)
               .HasColumnName("Phone Number");

               entity.Property(e => e.loyaltyNumber)
               .HasColumnName("Loyalty Member");
           });


        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
