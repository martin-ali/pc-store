using App.Enumerations;

namespace App.Models
{
    public class Cooler
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public int CoolingTdpWatts { get; set; }

        public int SocketId { get; set; }

        public ProcessorSocket Socket { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }
    }
}