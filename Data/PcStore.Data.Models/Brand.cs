namespace PcStore.Data.Models
{
    using PcStore.Data.Common.Models;

    public class Brand : BaseDeletableModel<int>
    {
        public string Name { get; set; }
    }
}
