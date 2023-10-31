using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Context.Configurations
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // Relationships

                // {Parent - Student}  => { One To Many}
                builder.HasOne(s => s.Parent)
                       .WithMany(p => p.Students)
                       .HasForeignKey(s => s.ParentId);

                // {Bus - Student} => {One To Many}
                builder.HasOne(s => s.Car)
                       .WithMany(c => c.Students)
                       .HasForeignKey(s => s.BusId);

                // {Class - Student} => {One To Many}
                builder.HasOne(s => s.Class)
                       .WithMany(c => c.Students)
                       .HasForeignKey(s => s.ClassId);


        }
    }
}
