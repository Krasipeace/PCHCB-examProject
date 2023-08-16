namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.Psu;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.ViewModels.Home;

    using static PCHCB.Common.NotificationMessages;
    using static PCHCB.Common.ErrorMessages.Provider;
    using static PCHCB.Common.ErrorMessages.Psu;
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

            try
            {
                PsuFormModel model = new PsuFormModel();

                return this.View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
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

                return this.RedirectToAction("Add", "Psu", new
                {
                    id = psuId
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
            bool psuExists = await psuService
                .IsPsuExistByIdAsync(id);
            if (!psuExists)
            {
                TempData[ErrorMessage] = PsuWithIdDoesNotExist;

                return RedirectToAction("All", "Psu");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotEditPowerSuppliesErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }
            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await psuService
                .IsProviderIdOwnerOfPsuIdAsync(providerId!, id);

            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotEditPowerSupplyHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                PsuFormModel formModel = await psuService
                    .GetPsuForEditByIdAsync(id);

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, PsuFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool psuExists = await psuService
                .IsPsuExistByIdAsync(id);
            if (!psuExists)
            {
                TempData[ErrorMessage] = PsuWithIdDoesNotExist;

                return RedirectToAction("All", "Psu");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotEditPowerSuppliesErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await psuService
                .IsProviderIdOwnerOfPsuIdAsync(providerId!, id);

            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotEditPowerSupplyHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                await psuService.EditPsuByIdAndFormModelAsync(id, model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, GeneralErrorMessage);

                return View(model);
            }

            TempData[SuccessMessage] = PowerSupplyEditedSuccessfully;

            return RedirectToAction("Edit", "Psu", new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            bool psuExists = await psuService
                .IsPsuExistByIdAsync(id);
            if (!psuExists)
            {
                TempData[ErrorMessage] = PsuWithIdDoesNotExist;

                return RedirectToAction("All", "Psu");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotDeletePowerSuppliesErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await psuService
                .IsProviderIdOwnerOfPsuIdAsync(providerId!, id);
            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotDeletePowerSupplyHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                DeleteDetailsViewModel viewModel = await psuService
                    .GetPsuForDeleteByIdAsync(id);

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
            bool psuExists = await psuService
                .IsPsuExistByIdAsync(id);
            if (!psuExists)
            {
                TempData[ErrorMessage] = PsuWithIdDoesNotExist;

                return RedirectToAction("All", "Psu");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotDeletePowerSuppliesErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await psuService
                .IsProviderIdOwnerOfPsuIdAsync(providerId!, id);
            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotDeletePowerSupplyHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                await psuService.DeletePsuByIdAsync(id);

                TempData[WarningMessage] = PowerSupplyDeletedSuccessfully;

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
            bool psuExists = await psuService
                .IsPsuExistByIdAsync(id);
            if (!psuExists)
            {
                TempData[ErrorMessage] = PsuWithIdDoesNotExist;

                return RedirectToAction("All", "Psu");
            }

            try
            {
                PsuDetailsViewModel viewModel = await psuService
                    .GetPsuDetailsAsync(id);

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
            SearchResult serviceModel = await psuService.SearchPsusAsync(queryModel);

            queryModel.Psus = serviceModel.Psus;
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
