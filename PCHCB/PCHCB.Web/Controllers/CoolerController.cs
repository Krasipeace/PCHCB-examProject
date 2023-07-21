namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class CoolerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
