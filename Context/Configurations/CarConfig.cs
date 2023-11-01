

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

            // HasData
            
            
        }
    }
}
