using Entity.Abstract;

namespace Entity.Concrete
{
    public class Driver:BaseEntity
    {
        // Properties

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        // Navigation Property

        virtual public Car Car{ get; set; }
    }
}
