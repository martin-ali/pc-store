namespace App.Models
{
Added Cooler initial propertiesGrapgh    using App.Enumerations;

    public class StorageDevice
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public string Model { get; set; }

        public int CapacityBytes { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }
    }
}