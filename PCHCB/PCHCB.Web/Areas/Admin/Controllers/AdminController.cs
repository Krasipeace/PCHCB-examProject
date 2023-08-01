namespace PCHCB.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using static PCHCB.Common.GeneralAppConstants;

    [Area(AdminAreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class AdminController : Controller
    {
    }
}
