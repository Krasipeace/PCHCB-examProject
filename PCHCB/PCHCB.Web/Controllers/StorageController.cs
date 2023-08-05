namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.Storage;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.ViewModels.Home;

    using static PCHCB.Common.NotificationMessages;
    using static PCHCB.Common.ErrorMessages.Provider;
    using static PCHCB.Common.ErrorMessages.Storage;
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

            try
            {
                StorageFormModel model = new StorageFormModel();

                return this.View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
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

                return this.RedirectToAction("Details", "Storage", new
                {
                    id = storageId
                });
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, GeneralErrorMessage);

                return this.View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            bool storageExists = await storageService
                .IsStorageExistByIdAsync(id);
            if (!storageExists)
            {
                TempData[ErrorMessage] = StorageWithIdDoesNotExist;

                return RedirectToAction("All", "Storage");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotEditStorageDevicesErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }
            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await storageService
                .IsProviderIdOwnerOfStorageIdAsync(providerId!, id);

            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotEditStorageDeviceHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                StorageFormModel formModel = await storageService
                    .GetStorageForEditByIdAsync(id);

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, StorageFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool storageExists = await storageService
                .IsStorageExistByIdAsync(id);
            if (!storageExists)
            {
                TempData[ErrorMessage] = StorageWithIdDoesNotExist;

                return RedirectToAction("All", "Storage");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotEditStorageDevicesErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await storageService
                .IsProviderIdOwnerOfStorageIdAsync(providerId!, id);

            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotEditStorageDeviceHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                await storageService.EditStorageByIdAndFormModelAsync(id, model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty,
                    GeneralErrorMessage);

                return View(model);
            }

            TempData[SuccessMessage] = StorageEditedSuccessfully;

            return RedirectToAction("Details", "Storage", new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            bool storageExists = await storageService
                .IsStorageExistByIdAsync(id);
            if (!storageExists)
            {
                TempData[ErrorMessage] = StorageWithIdDoesNotExist;

                return RedirectToAction("All", "Storage");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotDeleteStorageDevicesErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await storageService
                .IsProviderIdOwnerOfStorageIdAsync(providerId!, id);
            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotDeleteStorageDeviceHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                DeleteDetailsViewModel viewModel = await storageService
                    .GetStorageForDeleteByIdAsync(id);

                return View(viewModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, DeleteDetailsViewModel model)
        {
            bool storageExists = await storageService
                .IsStorageExistByIdAsync(id);
            if (!storageExists)
            {
                TempData[ErrorMessage] = StorageWithIdDoesNotExist;

                return RedirectToAction("Mine", "Provider");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotDeleteStorageDevicesErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await storageService
                .IsProviderIdOwnerOfStorageIdAsync(providerId!, id);
            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotDeleteStorageDeviceHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                await storageService.DeleteStorageByIdAsync(id);

                TempData[WarningMessage] = StorageDeletedSuccessfully;

                return RedirectToAction("Mine", "Provider");
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            bool storageExists = await storageService
                .IsStorageExistByIdAsync(id);
            if (!storageExists)
            {
                TempData[ErrorMessage] = StorageWithIdDoesNotExist;

                return RedirectToAction("All", "Storage");
            }

            try
            {
                StorageDetailsViewModel viewModel = await storageService
                    .GetStorageDetailsAsync(id);

                return View(viewModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllQueryModel queryModel)
        {
            SearchResult serviceModel = await storageService.SearchStoragesAsync(queryModel);

            queryModel.Storages = serviceModel.Storages;
            queryModel.TotalComponents = serviceModel.TotalComponents;

            return View(queryModel);
        }

        private IActionResult GeneralError()
        {
            this.TempData[ErrorMessage] = GeneralErrorMessage;

            return this.RedirectToAction("Index", "Home");
        }
    }
}
