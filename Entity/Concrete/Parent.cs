using Entity.Abstract;

namespace Entity.Concrete
{
    public class Parent:BaseEntity
    {
        // Properties

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        // Navigation Property

        virtual public ICollection<Student> Students { get; set; }
    }
}
