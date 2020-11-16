namespace PcStore.Data.Models
{
    using PcStore.Data.Common.Models;

    public class Brand : BaseDeletableModel<Processor>
    {
        public string Name { get; set; }
    }
}