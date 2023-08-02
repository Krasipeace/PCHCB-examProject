namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using static PCHCB.Common.GeneralAppConstants;

    public class HomeController : Controller
    {   
        public IActionResult Index()
        {
            if (this.User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }
            
            return this.View();
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