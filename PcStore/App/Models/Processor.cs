namespace App.Models
{
    using App.Enumerations;

    public class Processor
    {
        public int Id { get; set; }

        public float Frequency { get; set; }

        public int CoresCount { get; set; }

        public ProcessorManufacturer Manufacturer { get; set; }
    }
}