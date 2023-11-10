

using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Context.Configurations
{
    public class DriverConfig : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            // Has Data

            builder.HasData(
                    new Driver() { Id = 1, FirstName = "Daniel", LastName = "Cormier", Phone = "0509891232", Address = "San-Francisco", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 2, FirstName = "Michael", LastName = "Johnson", Phone = "0509894567", Address = "New York", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 3, FirstName = "Emily", LastName = "Smith", Phone = "0509897890", Address = "Los Angeles", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 4, FirstName = "John", LastName = "Brown", Phone = "0509892345", Address = "Chicago", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 5, FirstName = "Olivia", LastName = "Miller", Phone = "0509896789", Address = "Miami", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 6, FirstName = "Lucas", LastName = "Davis", Phone = "0509894321", Address = "San Diego", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 7, FirstName = "Ava", LastName = "Garcia", Phone = "0509898765", Address = "Seattle", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 8, FirstName = "Liam", LastName = "Martinez", Phone = "0509892109", Address = "Boston", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 9, FirstName = "Mia", LastName = "Clark", Phone = "0509895432", Address = "Houston", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 10, FirstName = "Noah", LastName = "Taylor", Phone = "0509898765", Address = "Denver", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 11, FirstName = "Sophia", LastName = "Walker", Phone = "0509891232", Address = "San-Francisco", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 12, FirstName = "William", LastName = "White", Phone = "0509894567", Address = "New York", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 13, FirstName = "Emma", LastName = "Jones", Phone = "0509897890", Address = "Los Angeles", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 14, FirstName = "James", LastName = "Wilson", Phone = "0509892345", Address = "Chicago", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 15, FirstName = "Isabella", LastName = "Jackson", Phone = "0509896789", Address = "Miami", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 16, FirstName = "Benjamin", LastName = "Harris", Phone = "0509894321", Address = "San Diego", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 17, FirstName = "Lucy", LastName = "Turner", Phone = "0509898765", Address = "Seattle", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 18, FirstName = "Logan", LastName = "Smith", Phone = "0509892109", Address = "Boston", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 19, FirstName = "Ella", LastName = "Anderson", Phone = "0509895432", Address = "Houston", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 20, FirstName = "Alexander", LastName = "Brown", Phone = "0509898765", Address = "Denver", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 21, FirstName = "Oliver", LastName = "Garcia", Phone = "0509891232", Address = "San-Francisco", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 22, FirstName = "Mia", LastName = "Johnson", Phone = "0509894567", Address = "New York", Created = DateTime.Now, Updated = DateTime.Now },
                    new Driver() { Id = 23, FirstName = "William", LastName = "Gonzalez", Phone = "0509897890", Address = "Los Angeles", Created = DateTime.Now, Updated = DateTime.Now }
                );


            // Constraints

            builder.Property(d => d.Phone)
                   .IsRequired()
                   .HasMaxLength(10)

        }
    }
}
