namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.Cooler;

    using static PCHCB.Common.NotificationMessages;
    using static PCHCB.Common.ErrorMessages.Provider;
    using static PCHCB.Common.SuccessMessages;
    using static PCHCB.Common.ExceptionMessages;

    [Authorize]
    public class CoolerController : Controller
    {
        private readonly ICoolerService coolerService;
        private readonly IProviderService providerService;

        public CoolerController(ICoolerService coolerService, IProviderService providerService)
        {
            this.coolerService = coolerService;
            this.providerService = providerService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = UserCannotAddCoolersErrorMessage;

                return this.RedirectToAction("BecomeProvider", "Provider");
            }

            CoolerFormModel model = new CoolerFormModel();       
                
            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CoolerFormModel model)
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = UserCannotAddCasesErrorMessage;

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

                int coolerId = await this.coolerService.CreateCoolerAsync(providerId!, model);

                this.TempData[SuccessMessage] = CoolerAddedSuccessfully;

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
