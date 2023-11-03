
namespace Entity.DTO
{
    public class RideDTO
    {
        public int Id { get; set; }

        public int BusId { get; set; }

        public string StartPoint { get; set; }

        public string EndPoint { get; set; }

        public int Passengers { get; set; }
    }
}
