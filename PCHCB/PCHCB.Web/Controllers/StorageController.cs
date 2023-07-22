namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.Storage;

    using static PCHCB.Common.NotificationMessages;
    using static PCHCB.Common.ErrorMessages.Provider;
    using static PCHCB.Common.SuccessMessages;
    using static PCHCB.Common.ExceptionMessages;

    [Authorize]
    public class StorageController : Controller
    {
        private readonly IStorageService storageService;
        private readonly IProviderService providerService;

        public StorageController(IStorageService storageService, IProviderService providerService)
        {
            this.storageService = storageService;
            this.providerService = providerService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = UserCannotAddStorageDevicesErrorMessage;

                return this.RedirectToAction("BecomeProvider", "Provider");
            }

            StorageFormModel model = new StorageFormModel();       
                
            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(StorageFormModel model)
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = UserCannotAddStorageDevicesErrorMessage;

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

                int storageId = await this.storageService.CreateStorageAsync(providerId!, model);

                this.TempData[SuccessMessage] = StorageAddedSuccessfully;

                return this.RedirectToAction("Details", "Storage");
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, GeneralErrorMessage);

                return this.View(model);
            }
        }
    }
}
