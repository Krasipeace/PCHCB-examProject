namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.Motherboard;

    using static PCHCB.Common.NotificationMessages;
    using static PCHCB.Common.ErrorMessages.Provider;
    using static PCHCB.Common.SuccessMessages;
    using static PCHCB.Common.ExceptionMessages;

    [Authorize]
    public class MotherboardController : Controller
    {
        private readonly IMotherboardService motherboardService;
        private readonly IProviderService providerService;

        public MotherboardController(IMotherboardService motherboardService, IProviderService providerService)
        {
            this.motherboardService = motherboardService;
            this.providerService = providerService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = UserCannotAddMotherboardsErrorMessage;

                return this.RedirectToAction("BecomeProvider", "Provider");
            }

            MotherboardFormModel model = new MotherboardFormModel();        
                
            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(MotherboardFormModel model)
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = UserCannotAddMotherboardsErrorMessage;

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

                int motherboardId = await this.motherboardService.CreateMotherboardAsync(providerId!, model);

                this.TempData[SuccessMessage] = MotherboardAddedSuccessfully;

                return this.RedirectToAction("Details", "Motherboard");
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, GeneralErrorMessage);

                return this.View(model);
            }
        }
    }
}
