namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.Psu;

    using static PCHCB.Common.NotificationMessages;
    using static PCHCB.Common.ErrorMessages.Provider;
    using static PCHCB.Common.SuccessMessages;
    using static PCHCB.Common.ExceptionMessages;

    [Authorize]
    public class PsuController : Controller
    {
        private readonly IPsuService psuService;
        private readonly IProviderService providerService;

        public PsuController(IPsuService psuService, IProviderService providerService)
        {
            this.psuService = psuService;
            this.providerService = providerService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = UserCannotAddPowerSuppliesErrorMessage;

                return this.RedirectToAction("BecomeProvider", "Provider");
            }

            PsuFormModel model = new PsuFormModel();       
                
            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(PsuFormModel model)
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = UserCannotAddPowerSuppliesErrorMessage;

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

                int psuId = await this.psuService.CreatePsuAsync(providerId!, model);

                this.TempData[SuccessMessage] = PowerSupplyAddedSuccessfully;

                return this.RedirectToAction("Details", "Psu");
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, GeneralErrorMessage);

                return this.View(model);
            }
        }
    }
}
