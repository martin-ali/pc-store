namespace PcStore.Data.Common.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    using PcStore.Data.Models;

    public class Product : BaseDeletableModel<int>
    {
        public string Model { get; set; }

        public Brand Brand { get; set; }

        [Column(TypeName = "decimal(18, 4)")]
        public decimal Price { get; set; }
    }
}
