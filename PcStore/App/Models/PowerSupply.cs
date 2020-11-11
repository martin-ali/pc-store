namespace App.Models
{
    using App.Enumerations;

    public class PowerSupply
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public string Model { get; set; }

        public int PowerWatts { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }
    }
}