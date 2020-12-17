namespace PcStore.Web.Areas.Products.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using PcStore.Common;
    using PcStore.Data.Models;
    using PcStore.Services.Data;
    using PcStore.Web.Controllers;

    [Area(GlobalConstants.ProductsArea)]
    public class ProcessorsController : BaseController
    {
        private readonly IProductsService<Processor> processorsService;

        public ProcessorsController(IProductsService<Processor> processorsService)
        {
            this.processorsService = processorsService;
        }

        public IActionResult Test()
        {
            return this.NotFound();
        }
    }
}
