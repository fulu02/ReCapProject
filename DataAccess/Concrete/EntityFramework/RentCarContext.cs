using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class RentCarContext : DbContext
    {
        public class RentcarContext : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Rentcar;Trusted_Connection=true");
            }
            public DbSet<Cer> Cars { get; set; }
            public DbSet<Brand> Brands { get; set; }
            public DbSet<Color> Colors { get; set; }
            public DbSet<Users> Users { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Rentals> Rentals { get; set; }

        }


    }


}
;

        public object Car { get; internal set; }
        public object Cars { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString;
        private const string ConnectionString = (V