namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.Ram;
    using PCHCB.Web.ViewModels.Provider;

    using static PCHCB.Common.NotificationMessages;
    using static PCHCB.Common.ErrorMessages.Provider;
    using static PCHCB.Common.ErrorMessages.Ram;
    using static PCHCB.Common.SuccessMessages;
    using static PCHCB.Common.ExceptionMessages;

    [Authorize]
    public class RamController : Controller
    {
        private readonly IRamService ramService;
        private readonly IProviderService providerService;

        public RamController(IRamService ramService, IProviderService providerService)
        {
            this.ramService = ramService;
            this.providerService = providerService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = UserCannotAddRamsErrorMessage;

                return this.RedirectToAction("BecomeProvider", "Provider");
            }

            RamFormModel model = new RamFormModel();

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(RamFormModel model)
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = UserCannotAddRamsErrorMessage;

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

                int ramId = await this.ramService
                    .CreateRamAsync(providerId!, model);

                this.TempData[SuccessMessage] = RamAddedSuccessfully;

                return this.RedirectToAction("Details", "Ram");
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
            bool ramExists = await ramService
                .IsRamExistByIdAsync(id);
            if (!ramExists)
            {
                TempData[ErrorMessage] = RamWithIdDoesNotExist;

                return RedirectToAction("All", "Ram");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotEditRamsErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }
            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await ramService
                .IsProviderIdOwnerOfRamIdAsync(providerId!, id);

            if (!isProviderOwner)
            {
                TempData[ErrorMessage] = ProviderCannotEditRamHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                RamFormModel formModel = await ramService
                    .GetRamForEditByIdAsync(id);

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, RamFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool ramExists = await ramService
                .IsRamExistByIdAsync(id);
            if (!ramExists)
            {
                TempData[ErrorMessage] = RamWithIdDoesNotExist;

                return RedirectToAction("All", "Ram");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotEditRamsErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await ramService
                .IsProviderIdOwnerOfRamIdAsync(providerId!, id);

            if (!isProviderOwner)
            {
                TempData[ErrorMessage] = ProviderCannotEditRamHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Ram");
            }

            try
            {
                await ramService.EditRamByIdAndFormModelAsync(id, model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, GeneralErrorMessage);

                return View(model);
            }

            TempData[SuccessMessage] = RamEditedSuccessfully;

            return RedirectToAction("Details", "Ram", new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            bool ramExists = await ramService
                .IsRamExistByIdAsync(id);
            if (!ramExists)
            {
                TempData[ErrorMessage] = RamWithIdDoesNotExist;

                return RedirectToAction("All", "Ram");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotDeleteRamsErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await ramService
                .IsProviderIdOwnerOfRamIdAsync(providerId!, id);
            if (!isProviderOwner)
            {
                TempData[ErrorMessage] = ProviderCannotDeleteRamHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Ram");
            }

            try
            {
                DeleteDetailsViewModel viewModel =
                    await ramService.GetRamForDeleteByIdAsync(id);

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
            bool ramExists = await ramService
                .IsRamExistByIdAsync(id);
            if (!ramExists)
            {
                TempData[ErrorMessage] = RamWithIdDoesNotExist;

                return RedirectToAction("All", "Ram");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotDeleteRamsErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await ramService
                .IsProviderIdOwnerOfRamIdAsync(providerId!, id);
            if (!isProviderOwner)
            {
                TempData[ErrorMessage] = ProviderCannotDeleteRamHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Ram");
            }

            try
            {
                await ramService.DeleteRamByIdAsync(id);

                TempData[WarningMessage] = RamDeletedSuccessfully;

                return RedirectToAction("Mine", "Ram");
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
            bool ramExists = await ramService
                .IsRamExistByIdAsync(id);
            if (!ramExists)
            {
                TempData[ErrorMessage] = RamWithIdDoesNotExist;

                return RedirectToAction("All", "Ram");
            }

            try
            {
                RamDetailsViewModel viewModel = await ramService
                    .GetRamDetailsAsync(id);

                return View(viewModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        private IActionResult GeneralError()
        {
            this.TempData[ErrorMessage] = GeneralErrorMessage;

            return this.RedirectToAction("Index", "Home");
        }
    }
}
