namespace App.Models
{
    using App.Enumerations;

    public class GraphicsCard
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public string Model { get; set; }

        public int MemoryCapacityBytes { get; set; }

        public float CoreFrequency { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }
    }
}