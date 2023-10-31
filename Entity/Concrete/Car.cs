using Entity.Abstract;

namespace Entity.Concrete
{
    public class Car:BaseEntity
    {
        public int  DriverId { get; set; }

        public int Capacity { get; set; }

        public string Number { get; set; }

        // Navigation Property

        virtual public Driver Driver { get; set; }

        virtual public Ride Ride { get; set; }

        virtual public ICollection<Student> Students { get; set;}
    }

}
