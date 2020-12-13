namespace PcStore.Data.Common.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using PcStore.Data.Models;

    public abstract class Product : BaseDeletableModel<int>
    {
        public Product()
        {
            this.Reviews = new List<Review>();
        }

        [Required]
        [MinLength(3)]
        public string Model { get; set; }

        [Required]
        public Brand Brand { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Price { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
