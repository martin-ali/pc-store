namespace PcStore.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using PcStore.Data.Common.Models;

    public class Review : BaseDeletableModel<int>
    {
        [MinLength(10)]
        [MaxLength(1000)]
        public string Content { get; set; }

        public ApplicationUser Author { get; set; }

        [Required]
        public int AuthorId { get; set; }

        public Product Product { get; set; }

        [Required]
        public int ProductId { get; set; }
    }
}
