using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Context.Configurations
{
    public class RideConfig : IEntityTypeConfiguration<Ride>
    {
        public void Configure(EntityTypeBuilder<Ride> builder)
        {
            // Relationships

                // {Bus - Ride}  => {One To One}
                builder.HasOne(r => r.Car)
                       .WithOne(b => b.Ride)
                       .HasForeignKey<Ride>(r => r.BusId);

            // Has Data

            builder.HasData(
                     new Ride() { Id = 1, BusId = 1, StartPoint = "Manchester", EndPoint = "Liverpool", Passengers = 10, Created = DateTime.Now, Updated = DateTime.Now },
                     new Ride() { Id = 2, BusId = 2, StartPoint = "London", EndPoint = "Birmingham", Passengers = 15, Created = DateTime.Now, Updated = DateTime.Now },
                     new Ride() { Id = 3, BusId = 3, StartPoint = "Glasgow", EndPoint = "Edinburgh", Passengers = 12, Created = DateTime.Now, Updated = DateTime.Now },
                     new Ride() { Id = 4, BusId = 4, StartPoint = "New York", EndPoint = "Boston", Passengers = 8, Created = DateTime.Now, Updated = DateTime.Now },
                     new Ride() { Id = 5, BusId = 5, StartPoint = "Los Angeles", EndPoint = "San Francisco", Passengers = 20, Created = DateTime.Now, Updated = DateTime.Now },
                     new Ride() { Id = 6, BusId = 6, StartPoint = "Paris", EndPoint = "Amsterdam", Passengers = 16, Created = DateTime.Now, Updated = DateTime.Now },
                     new Ride() { Id = 7, BusId = 7, StartPoint = "Sydney", EndPoint = "Melbourne", Passengers = 18, Created = DateTime.Now, Updated = DateTime.Now },
                     new Ride() { Id = 8, BusId = 8, StartPoint = "Berlin", EndPoint = "Munich", Passengers = 14, Created = DateTime.Now, Updated = DateTime.Now },
                     new Ride() { Id = 9, BusId = 9, StartPoint = "Tokyo", EndPoint = "Osaka", Passengers = 11, Created = DateTime.Now, Updated = DateTime.Now },
                     new Ride() { Id = 10, BusId = 10, StartPoint = "Rome", EndPoint = "Florence", Passengers = 9, Created = DateTime.Now, Updated = DateTime.Now }
                 );

        }
    }
}
