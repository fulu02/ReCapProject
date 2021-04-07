using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class RentCarContext : DbContext
    {
        public object Car { get; internal set; }
        public object Cars { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\MSSQLLocalDb;Database = RentCar; Trusted_Connection=true"");
        }

        public DbSet<Car> Cars { get; set; } 

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<Users>  Users { get; set; }

        public DbSet<Customers> Customers { get; set; }

        public DbSet <Rental> Rentals { get; set; }
       

     } 

    
}


}
