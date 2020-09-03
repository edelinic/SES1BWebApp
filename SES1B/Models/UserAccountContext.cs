using System;
using Microsoft.EntityFrameworkCore;

namespace SES1B.Models

{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<RestaurantContext> options) : base(options)
        {
        }

        public DbSet<UserAccount> userAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning //To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=restaurantdb.cvz3e6ne8iwm.ap-southeast-2.rds.amazonaws.com;database=Restaurant;uid=root;pwd=12345678", x => x.ServerVersion("8.0.17-mysql"));
            }
        }

        public DbSet<NewAccount> Accounts { get; set; } //Call back to the account class.





        //There's a section below where we configure the hell out of the database and say it's all here. 

    }
}
