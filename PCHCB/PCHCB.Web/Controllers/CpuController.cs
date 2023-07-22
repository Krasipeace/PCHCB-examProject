namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.Cpu;

    using static PCHCB.Common.NotificationMessages;
    using static PCHCB.Common.ErrorMessages.Provider;
    using static PCHCB.Common.SuccessMessages;
    using static PCHCB.Common.ExceptionMessages;

    [Authorize]
    public class CpuController : Controller
    {
        private readonly ICpuService cpuService;
        private readonly IProviderService providerService;

        public CpuController(ICpuService cpuService, IProviderService providerService)
        {
            this.cpuService = cpuService;
            this.providerService = providerService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = UserCannotAddCpusErrorMessage;

                return this.RedirectToAction("BecomeProvider", "Provider");
            }

            CpuFormModel model = new CpuFormModel();       
                
            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CpuFormModel model)
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = UserCannotAddCpusErrorMessage;

                return this.RedirectToAction("BecomeProvider", "Provider");
            }

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            try
            {
                string? providerId = await this.providerService
                .GetProviderByUserIdAsync(this.User.GetId()!);

                int caseId = await this.cpuService.CreateCpuAsync(providerId!, model);

                this.TempData[SuccessMessage] = CpuAddedSuccessfully;

                return this.RedirectToAction("Details", "Cooler");
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, GeneralErrorMessage);

                return this.View(model);
            }
        }
    }
}
