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


            // Has Data

            builder.HasData(
                   new Student() { Id = 1, FirstName = "Elgun", LastName = "Haqverdiyev", ClassId = 1, ParentId = 1, BusId = 1, Created = DateTime.Now, Updated = DateTime.Now },
                   new Student() { Id = 2, FirstName = "Alice", LastName = "Johnson", ClassId = 2, ParentId = 2, BusId = 2, Created = DateTime.Now, Updated = DateTime.Now },
                   new Student() { Id = 3, FirstName = "John", LastName = "Smith", ClassId = 3, ParentId = 3, BusId = 3, Created = DateTime.Now, Updated = DateTime.Now },
                   new Student() { Id = 4, FirstName = "Emily", LastName = "Wilson", ClassId = 4, ParentId = 4, BusId = 4, Created = DateTime.Now, Updated = DateTime.Now },
                   new Student() { Id = 5, FirstName = "David", LastName = "Brown", ClassId = 5, ParentId = 5, BusId = 5, Created = DateTime.Now, Updated = DateTime.Now },
                   new Student() { Id = 6, FirstName = "Sophia", LastName = "Miller", ClassId = 6, ParentId = 6, BusId = 6, Created = DateTime.Now, Updated = DateTime.Now },
                   new Student() { Id = 7, FirstName = "Oliver", LastName = "Davis", ClassId = 7, ParentId = 7, BusId = 7, Created = DateTime.Now, Updated = DateTime.Now },
                   new Student() { Id = 8, FirstName = "Lily", LastName = "Garcia", ClassId = 8, ParentId = 8, BusId = 8, Created = DateTime.Now, Updated = DateTime.Now },
                   new Student() { Id = 9, FirstName = "Ethan", LastName = "Martinez", ClassId = 9, ParentId = 9, BusId = 9, Created = DateTime.Now, Updated = DateTime.Now },
                   new Student() { Id = 10, FirstName = "Ava", LastName = "Clark", ClassId = 10, ParentId = 10, BusId = 10, Created = DateTime.Now, Updated = DateTime.Now }
                );



        }
    }
}
