using Entity.Abstract;

namespace Entity.Concrete
{
    public class Student:BaseEntity
    {
        // Properties

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ClassId { get; set; }

        public int ParentId { get; set; }

        public int BusId { get; set; }

        // Navigation Property

        virtual public Class Class { get; set; }

        virtual public Parent Parent { get; set; }

        virtual public Car Car { get; set; }
    }
}
