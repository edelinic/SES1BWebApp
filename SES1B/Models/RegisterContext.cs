using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace SES1B.Models

{
    public partial class NewAccountContext : DbContext
    {
        public NewAccountContext()
        {
        }

        public NewAccountContext(DbContextOptions<NewAccountContext> options)
            : base(options)
        {
        }



        //entites 
        public virtual DbSet<NewAccount> NewAccounts { get; set; } //Call back to the new account class. 

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { //This line links this database to the my SQL server. 
                optionsBuilder.UseMySql("server=restaurantdb.cvz3e6ne8iwm.ap-southeast-2.rds.amazonaws.com;database=Restaurant;uid=root;pwd=$E$1Bcovid19", x => x.ServerVersion("8.0.17-mysql"));

            }
        }


        public DbSet<NewAccount> newAccounts { get; set; }
        public object Users { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<NewAccount> (entity =>
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
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
       

//We'll need to add some code to import the databse context sql server over to here. Figure it out!!

//No database provider has been configured for this DbContext.
  //  A provider can be configured by overriding the DbContext.
   // OnConfiguring method or by using AddDbContext on the application service provider.
   // If AddDbContext is used, then also ensure that your DbContext type accepts a DbContextOptions<TContext>
   // object in its constructor and passes it to the base constructor for DbContext.