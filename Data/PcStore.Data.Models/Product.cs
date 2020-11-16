namespace PcStore.Data.Common.Models
{
    using PcStore.Data.Models;

    public class Product : BaseDeletableModel<int>
    {
        public string Model { get; set; }

        public Brand Brand { get; set; }

        public decimal Price { get; set; }
    }
}