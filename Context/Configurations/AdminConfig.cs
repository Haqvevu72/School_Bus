using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Context.Configurations
{
    public class AdminConfig : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            // Has Data

            builder.HasData(new Admin() {Id=1, Username = "admin", Password = "admin",Created=DateTime.Now,Updated=DateTime.Now });
        }
    }
}
