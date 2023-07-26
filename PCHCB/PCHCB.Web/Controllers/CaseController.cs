namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.Case;
    using PCHCB.Web.ViewModels.Provider;

    using static PCHCB.Common.NotificationMessages;
    using static PCHCB.Common.ExceptionMessages;
    using static PCHCB.Common.ErrorMessages.Provider;
    using static PCHCB.Common.ErrorMessages.Case;
    using static PCHCB.Common.SuccessMessages;

    [Authorize]
    public class CaseController : Controller
    {
        private readonly ICaseService caseService;
        private readonly IProviderService providerService;

        public CaseController(ICaseService caseService, IProviderService providerService)
        {
            this.caseService = caseService;
            this.providerService = providerService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = UserCannotAddCasesErrorMessage;

                return this.RedirectToAction("BecomeProvider", "Provider");
            }

            CaseFormModel model = new CaseFormModel();

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CaseFormModel model)
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

                int caseId = await this.caseService
                    .CreateCaseAsync(providerId!, model);

                this.TempData[SuccessMessage] = CaseAddedSuccessfully;

                return this.RedirectToAction("Details", "Case");
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
            bool caseExists = await caseService
                .IsCaseExistByIdAsync(id);
            if (!caseExists)
            {
                TempData[ErrorMessage] = CaseWithIdDoesNotExist;

                return RedirectToAction("All", "Case");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotEditCasesErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }
            string? providerId =
                await providerService.GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await caseService
                .IsProviderIdOwnerOfCaseIdAsync(providerId!, id);

            if (!isProviderOwner)
            {
                TempData[ErrorMessage] = ProviderCannotEditCaseHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Case");
            }

            try
            {
                CaseFormModel formModel = await caseService
                    .GetCaseForEditByIdAsync(id);

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CaseFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool caseExists = await caseService
                .IsCaseExistByIdAsync(id);
            if (!caseExists)
            {
                TempData[ErrorMessage] = CaseWithIdDoesNotExist;

                return RedirectToAction("All", "Case");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotEditCasesErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId =
                await providerService.GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await caseService
                .IsProviderIdOwnerOfCaseIdAsync(providerId!, id);

            if (!isProviderOwner)
            {
                TempData[ErrorMessage] = ProviderCannotEditCaseHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Case");
            }

            try
            {
                await caseService.EditCaseByIdAndFormModelAsync(id, model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, GeneralErrorMessage);

                return View(model);
            }

            TempData[SuccessMessage] = CaseEditedSuccessfully;

            return RedirectToAction("Details", "Case", new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            bool caseExists = await caseService
                .IsCaseExistByIdAsync(id);
            if (!caseExists)
            {
                TempData[ErrorMessage] = CaseWithIdDoesNotExist;

                return RedirectToAction("All", "Case");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotDeleteCasesErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await caseService
                .IsProviderIdOwnerOfCaseIdAsync(providerId!, id);

            if (!isProviderOwner)
            {
                TempData[ErrorMessage] = ProviderCannotDeleteCaseHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Case");
            }

            try
            {
                DeleteDetailsViewModel viewModel = await caseService
                    .GetCaseForDeleteByIdAsync(id);

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
            bool caseExists = await caseService
                .IsCaseExistByIdAsync(id);
            if (!caseExists)
            {
                TempData[ErrorMessage] = CaseWithIdDoesNotExist;

                return RedirectToAction("All", "Case");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);

            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotDeleteCasesErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await caseService
                .IsProviderIdOwnerOfCaseIdAsync(providerId!, id);

            if (!isProviderOwner)
            {
                TempData[ErrorMessage] = ProviderCannotDeleteCaseHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Case");
            }

            try
            {
                await caseService.DeleteCaseByIdAsync(id);

                TempData[WarningMessage] = CaseDeletedSuccessfully;

                return RedirectToAction("Mine", "Case");
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
            bool caseExists = await caseService
                .IsCaseExistByIdAsync(id);
            if (!caseExists)
            {
                TempData[ErrorMessage] = CaseWithIdDoesNotExist;

                return RedirectToAction("All", "Case");
            }

            try
            {
                CaseDetailsViewModel viewModel = await caseService
                    .GetCaseDetailsAsync(id);               

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
