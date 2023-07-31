namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.ViewModels.Home;

    public class HomeController : Controller
    {
        private readonly IHomeService homeService;
        public HomeController(IHomeService homeService)
        {
            this.homeService = homeService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllQueryModel queryModel)
        {
            AllComponentsSearchResult serviceModel = await homeService
                .AllAsync(queryModel);

            queryModel.Cases = serviceModel.Cases;
            queryModel.Cpus = serviceModel.Cpus;
            queryModel.Gpus = serviceModel.Gpus;
            queryModel.Coolers = serviceModel.Coolers;
            queryModel.Motherboards = serviceModel.Motherboards;
            queryModel.Psus = serviceModel.Psus;
            queryModel.Rams = serviceModel.Rams;
            queryModel.Storages = serviceModel.Storages;
            queryModel.TotalComponents = serviceModel.TotalComponents;

            return View(queryModel);
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 400 || statusCode == 404)
            {
                return this.View("Error404");
            }

            if (statusCode == 401)
            {
                return this.View("Error401");
            }

            if (statusCode == 403)
            {
                return this.View("Error403");
            }

            return this.View();
        }
    }
}