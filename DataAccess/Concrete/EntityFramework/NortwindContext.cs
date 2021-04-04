using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class NortwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server(localdb)/mssqllocaldb,DataBase=Nortwind,Trusted_connection=true;");
        }

        public DbSet<Brand> cars { get; set; }

        public DbSet<Brand> brands { get; set; }
        public DbSet<Color> colors { get; set; }






    }
}
