﻿using System;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=restaurantdb.cvz3e6ne8iwm.ap-southeast-2.rds.amazonaws.com;database=Restaurant;uid=root;pwd=12345678", x => x.ServerVersion("8.0.17-mysql"));
            }
        }

        public DbSet<NewAccount> newAccounts { get; set; }
        public object Users { get; internal set; }

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

            modelBuilder.Entity<NewAccount>(entity =>
            {

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.firstname)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("string(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasColumnType("string(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("string(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");


            });

            OnModelCreatingPartial(modelBuilder);
            //takes info from database and autogenerates it for teh code. All things in quotes match what's in the database


        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
