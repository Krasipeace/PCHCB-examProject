namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.Gpu;

    using static PCHCB.Common.NotificationMessages;
    using static PCHCB.Common.ErrorMessages.Provider;
    using static PCHCB.Common.SuccessMessages;
    using static PCHCB.Common.ExceptionMessages;

    [Authorize]
    public class GpuController : Controller
    {
        private readonly IGpuService gpuService;
        private readonly IProviderService providerService;

        public GpuController(IGpuService gpuService, IProviderService providerService)
        {
            this.gpuService = gpuService;
            this.providerService = providerService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = UserCannotAddGpusErrorMessage;

                return this.RedirectToAction("BecomeProvider", "Provider");
            }

            GpuFormModel model = new GpuFormModel();       
                
            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(GpuFormModel model)
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = UserCannotAddGpusErrorMessage;

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

                int caseId = await this.gpuService.CreateGpuAsync(providerId!, model);

                this.TempData[SuccessMessage] = GpuAddedSuccessfully;

                return this.RedirectToAction("Details", "Gpu");
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, GeneralErrorMessage);

                return this.View(model);
            }
        }
    }
}
