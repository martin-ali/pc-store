namespace App.Controllers
{
    using App.Services;
    using Microsoft.AspNetCore.Mvc;

    public class ProcessorsController : Controller
    {
        private readonly IProcessorsService processorsService;

        public ProcessorsController(IProcessorsService processorsService)
        {
            this.processorsService = processorsService;
        }

        public IActionResult Index()
        {
            this.processorsService.GenerateNew();

            return this.View();
        }
    }
}