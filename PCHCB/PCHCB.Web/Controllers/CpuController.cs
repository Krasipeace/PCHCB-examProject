namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class CpuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
