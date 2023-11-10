using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Context.Configurations
{
    public class ParentConfig : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
        {
            // Has Data

                builder.HasData(
                    new Parent() { Id = 1, FirstName = "Ali", LastName = "Muradov", Phone = "0555555555", Address = "Sumqayit City", Created = DateTime.Now, Updated = DateTime.Now },
                    new Parent() { Id = 2, FirstName = "Ayse", LastName = "Kara", Phone = "0555123456", Address = "Istanbul", Created = DateTime.Now, Updated = DateTime.Now },
                    new Parent() { Id = 3, FirstName = "David", LastName = "Brown", Phone = "0555234567", Address = "New York", Created = DateTime.Now, Updated = DateTime.Now },
                    new Parent() { Id = 4, FirstName = "Sophia", LastName = "Smith", Phone = "0555345678", Address = "Los Angeles", Created = DateTime.Now, Updated = DateTime.Now },
                    new Parent() { Id = 5, FirstName = "John", LastName = "Johnson", Phone = "0555456789", Address = "Chicago", Created = DateTime.Now, Updated = DateTime.Now },
                    new Parent() { Id = 6, FirstName = "Emma", LastName = "Wilson", Phone = "0555567890", Address = "Miami", Created = DateTime.Now, Updated = DateTime.Now },
                    new Parent() { Id = 7, FirstName = "Michael", LastName = "Harris", Phone = "0555678901", Address = "San Diego", Created = DateTime.Now, Updated = DateTime.Now },
                    new Parent() { Id = 8, FirstName = "Olivia", LastName = "Davis", Phone = "0555789012", Address = "Seattle", Created = DateTime.Now, Updated = DateTime.Now },
                    new Parent() { Id = 9, FirstName = "Lucas", LastName = "Miller", Phone = "0555890123", Address = "Boston", Created = DateTime.Now, Updated = DateTime.Now },
                    new Parent() { Id = 10, FirstName = "Ava", LastName = "Clark", Phone = "0555101234", Address = "Houston", Created = DateTime.Now, Updated = DateTime.Now }
                    );

            // Constraints

                builder.Property(p => p.Phone)
                       .IsRequired()
                       .HasMaxLength(10)

        }
    }
}
