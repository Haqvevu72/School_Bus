
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Context.Configurations
{
    public class ClassConfig : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            // Has Data
            builder.HasData(
                new Class() { Id = 1, Name = "ZU-051", Created = DateTime.Now, Updated = DateTime.Now },
                new Class() { Id = 2, Name = "ZU-052", Created = DateTime.Now, Updated = DateTime.Now },
                new Class() { Id = 3, Name = "ZU-053", Created = DateTime.Now, Updated = DateTime.Now },
                new Class() { Id = 4, Name = "ZU-054", Created = DateTime.Now, Updated = DateTime.Now },
                new Class() { Id = 5, Name = "ZU-055", Created = DateTime.Now, Updated = DateTime.Now },
                new Class() { Id = 6, Name = "ZU-056", Created = DateTime.Now, Updated = DateTime.Now },
                new Class() { Id = 7, Name = "ZU-057", Created = DateTime.Now, Updated = DateTime.Now },
                new Class() { Id = 8, Name = "ZU-058", Created = DateTime.Now, Updated = DateTime.Now },
                new Class() { Id = 9, Name = "ZU-059", Created = DateTime.Now, Updated = DateTime.Now },
                new Class() { Id = 10, Name = "ZU-060", Created = DateTime.Now, Updated = DateTime.Now }
            );

        }
    }
}
