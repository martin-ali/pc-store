namespace App.Models
{
    using App.Enumerations;

    public class MemoryModule
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public string Model { get; set; }

        public int CapacityBytes { get; set; }

        public int TypeId { get; set; }

        public MemoryType Type { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }
    }
}