namespace PcStore.Web.Areas.Products.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using PcStore.Common;
    using PcStore.Data.Common.Models;
    using PcStore.Data.Models;
    using PcStore.Services.Data;
    using PcStore.Web.Controllers;

    [Area(GlobalConstants.ProductsArea)]
    public class ProductsController : BaseController
    {
        private readonly IProductsService<Product> productsService;

        public ProductsController(IProductsService<Product> productsService)
        {
            this.productsService = productsService;
        }

        public IActionResult Index()
        {
            return this.View();
        }
    }
}
