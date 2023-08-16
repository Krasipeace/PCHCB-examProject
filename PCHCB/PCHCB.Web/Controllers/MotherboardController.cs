namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.Motherboard;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.ViewModels.Home;

    using static PCHCB.Common.NotificationMessages;
    using static PCHCB.Common.ErrorMessages.Provider;
    using static PCHCB.Common.ErrorMessages.Motherboard;
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

            try
            {
                MotherboardFormModel model = new MotherboardFormModel();

                return this.View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
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

                return this.RedirectToAction("Add", "Motherboard", new
                {
                    id = motherboardId
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
            bool motherboardExists = await motherboardService
                .IsMotherboardExistByIdAsync(id);
            if (!motherboardExists)
            {
                TempData[ErrorMessage] = MotherboardWithIdDoesNotExist;

                return RedirectToAction("All", "Motherboard");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotEditMotherboardsErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }
            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await motherboardService
                .IsProviderIdOwnerOfMotherboardIdAsync(providerId!, id);

            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotEditMotherboardHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                MotherboardFormModel formModel = await motherboardService
                    .GetMotherboardForEditByIdAsync(id);

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, MotherboardFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool motherboardExists = await motherboardService
                .IsMotherboardExistByIdAsync(id);
            if (!motherboardExists)
            {
                TempData[ErrorMessage] = MotherboardWithIdDoesNotExist;

                return RedirectToAction("All", "Motherboard");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotEditMotherboardsErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await motherboardService
                .IsProviderIdOwnerOfMotherboardIdAsync(providerId!, id);

            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotEditMotherboardHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                await motherboardService.EditMotherboardByIdAndFormModelAsync(id, model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, GeneralErrorMessage);

                return View(model);
            }

            TempData[SuccessMessage] = MotherboardEditedSuccessfully;

            return RedirectToAction("Edit", "Motherboard", new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            bool motherboardExists = await motherboardService
                .IsMotherboardExistByIdAsync(id);
            if (!motherboardExists)
            {
                TempData[ErrorMessage] = MotherboardWithIdDoesNotExist;

                return RedirectToAction("All", "Motherboard");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotDeleteMotherboardsErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await motherboardService
                .IsProviderIdOwnerOfMotherboardIdAsync(providerId!, id);
            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotDeleteMotherboardHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                DeleteDetailsViewModel viewModel =
                    await motherboardService.GetMotherboardForDeleteByIdAsync(id);

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
            bool motherboardExists = await motherboardService
                .IsMotherboardExistByIdAsync(id);
            if (!motherboardExists)
            {
                TempData[ErrorMessage] = MotherboardWithIdDoesNotExist;

                return RedirectToAction("All", "Motherboard");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotDeleteMotherboardsErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId =
                await providerService.GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await motherboardService
                .IsProviderIdOwnerOfMotherboardIdAsync(providerId!, id);
            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotDeleteMotherboardHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                await motherboardService.DeleteMotherboardByIdAsync(id);

                TempData[WarningMessage] = MotherboardDeletedSuccessfully;

                return RedirectToAction("Mine", "Provider");
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id, string information)
        {
            bool motherboardExists = await motherboardService
                .IsMotherboardExistByIdAsync(id);
            if (!motherboardExists)
            {
                TempData[ErrorMessage] = MotherboardWithIdDoesNotExist;

                return RedirectToAction("All", "Motherboard");
            }

            try
            {
                MotherboardDetailsViewModel viewModel = await motherboardService
                    .GetMotherboardDetailsAsync(id);

                if (viewModel.GetUrlInformation() != information)
                {
                    return RedirectToAction("Error", "Home", StatusCode(404));
                }

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
            SearchResult serviceModel = await motherboardService.SearchMotherboardsAsync(queryModel);

            queryModel.Motherboards = serviceModel.Motherboards;
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
