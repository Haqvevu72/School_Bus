using Entity.Abstract;

namespace Entity.Concrete
{
    public class Class:BaseEntity
    {
        // Properties

        public string Name { get; set; }

        // Navigation Property

        virtual public ICollection<Student> Students { get; set; }
    }
}
