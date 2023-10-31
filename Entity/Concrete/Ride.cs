using Entity.Abstract;

namespace Entity.Concrete
{
    public class Ride:BaseEntity
    {
        // Properties

        public int BusId { get; set; }

        public string StartPoint { get; set; }

        public string EndPoint { get; set; }

        public int Passengers { get; set; }

        // Navigation Property

        virtual public Car Car { get; set; }

    }
}
