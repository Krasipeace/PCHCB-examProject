namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class PcConfiguration : Controller
    {
        public IActionResult My()
        {
            return View();
        }
    }
}
