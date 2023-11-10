

using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Context.Configurations
{
    public class CarConfig : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            // Relationships

                // {Driver - Car}  {One To One}
                builder.HasOne(c => c.Driver)
                       .WithOne(d => d.Car)
                       .HasForeignKey<Car>(c => c.DriverId);

            // Has Data

                builder.HasData(
                    new Car() { Id = 1, DriverId = 1, Capacity = 20, Number = "01-AA-001", Created = DateTime.Now, Updated = DateTime.Now },
                    new Car() { Id = 2, DriverId = 2, Capacity = 18, Number = "02-BB-002", Created = DateTime.Now, Updated = DateTime.Now },
                    new Car() { Id = 3, DriverId = 3, Capacity = 25, Number = "03-CC-003", Created = DateTime.Now, Updated = DateTime.Now },
                    new Car() { Id = 4, DriverId = 4, Capacity = 22, Number = "04-DD-004", Created = DateTime.Now, Updated = DateTime.Now },
                    new Car() { Id = 5, DriverId = 5, Capacity = 30, Number = "05-EE-005", Created = DateTime.Now, Updated = DateTime.Now },
                    new Car() { Id = 6, DriverId = 6, Capacity = 21, Number = "06-FF-006", Created = DateTime.Now, Updated = DateTime.Now },
                    new Car() { Id = 7, DriverId = 7, Capacity = 28, Number = "07-GG-007", Created = DateTime.Now, Updated = DateTime.Now },
                    new Car() { Id = 8, DriverId = 8, Capacity = 24, Number = "08-HH-008", Created = DateTime.Now, Updated = DateTime.Now },
                    new Car() { Id = 9, DriverId = 9, Capacity = 19, Number = "09-II-009", Created = DateTime.Now, Updated = DateTime.Now },
                    new Car() { Id = 10, DriverId = 10, Capacity = 15, Number = "10-JJ-010", Created = DateTime.Now, Updated = DateTime.Now }
                    );

            // Constraint

            builder.HasIndex(x => x.Number)
                    .IsUnique();




        }
    }
}
