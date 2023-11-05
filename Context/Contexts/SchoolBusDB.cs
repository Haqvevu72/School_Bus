using Context.Configurations;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.Contexts
{
    public class SchoolBusDB:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=STHQ0116-15;Initial Catalog=SchoolBusDb;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new RideConfig());
            modelBuilder.ApplyConfiguration(new CarConfig());
            modelBuilder.ApplyConfiguration(new AdminConfig());

            modelBuilder.ApplyConfiguration(new ClassConfig());
            modelBuilder.ApplyConfiguration(new ParentConfig());
            modelBuilder.ApplyConfiguration(new DriverConfig());



        }


        public DbSet<Admin> Admins { get; set; }

        public DbSet<Ride> Rides { get; set; }

        public DbSet<Class> Classes { get; set; }

        public DbSet<Parent> Parents { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Driver> Drivers { get; set; }

        public DbSet<Car> Cars { get; set; }
    }
}

