namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.Ram;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.ViewModels.Home;

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

            try
            {
                RamFormModel model = new RamFormModel();

                return this.View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
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

                return this.RedirectToAction("Add", "Ram", new
                {
                    id = ramId
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

            if (!isProviderOwner && !User.IsAdmin())
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

            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotEditRamHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
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

            return RedirectToAction("Edit", "Ram", new { id });
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
            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotDeleteRamHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                DeleteDetailsViewModel viewModel = await ramService.GetRamForDeleteByIdAsync(id);

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
            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotDeleteRamHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                await ramService.DeleteRamByIdAsync(id);

                TempData[WarningMessage] = RamDeletedSuccessfully;

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
            SearchResult serviceModel = await ramService.SearchRamsAsync(queryModel);

            queryModel.Rams = serviceModel.Rams;
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
