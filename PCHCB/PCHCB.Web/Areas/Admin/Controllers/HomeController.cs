namespace PCHCB.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using static PCHCB.Common.GeneralAppConstants;

    public class HomeController : AdminController
    {
        public IActionResult Index()
        {
            if (this.User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }
            
            return this.View();
        }
    }
}
