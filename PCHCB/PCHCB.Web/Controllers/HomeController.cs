namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data;

    public class HomeController : Controller
    {
        public HomeController()
        {
        }
            // TODO: 
        //[HttpGet]
        //[AllowAnonymous]
        //public async Task<IActionResult> All([FromQuery]AllCasesQueryModel queryModel)
        //{
        //    AllCasesFilteredAndPagedServiceModel serviceModel =
        //        await caseService.AllAsync(queryModel);

        //    queryModel.Cases = serviceModel.Cases;
        //    queryModel.TotalCases = serviceModel.TotalCasesCount;

        //    return View(queryModel);
        //}

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