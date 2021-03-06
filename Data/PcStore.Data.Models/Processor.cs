namespace PcStore.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using PcStore.Data.Common.Models;
    public class Processor : Product
    {
        [Required]
        [Display(Name = "Cores count")]
        [Range(1, 128)]
        public int CoresCount { get; set; }

        [Display(Name = "Clock frequency")]
        [Range(0.1, 5)]
        public float ClockFrequency { get; set; }
    }
}
