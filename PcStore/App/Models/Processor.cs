namespace App.Models
{
    using App.Enumerations;

    public class Processor
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public string Model { get; set; }

        public float Frequency { get; set; }

        public int CoresCount { get; set; }

        public int SocketId { get; set; }

        public ProcessorSocket Socket { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }
    }
}