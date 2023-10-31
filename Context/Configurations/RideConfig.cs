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
        }
    }
}
