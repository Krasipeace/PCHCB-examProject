namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.Case;

    using static PCHCB.Common.NotificationMessages;
    using static PCHCB.Common.ExceptionMessages;
    using static PCHCB.Common.ErrorMessages.Provider;
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
                this.TempData[ErrorMessage] = ProviderCannotAddCasesErrorMessage;

                return this.RedirectToAction("Become", "Provider");
            }

            try
            {
                CaseFormModel model = new();
                await this.caseService.CreateCaseAsync(this.User.GetId()!, model);

                return View(model);
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(CaseFormModel model)
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = ProviderCannotAddCasesErrorMessage;

                return this.RedirectToAction("Become", "Provider");
            }

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            try
            {
                string? providerId = await this.providerService
                    .GetProviderByUserIdAsync(this.User.GetId()!);

                int caseId = await this.caseService.CreateCaseAsync(providerId!, model);

                this.TempData[SuccessMessage] = CaseAddedSuccessfully;

                return this.RedirectToAction("Details", "Case");
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, GeneralErrorMessage);

                return this.View(model);
            }
        }

        private IActionResult GeneralError()
        {
            this.TempData[ErrorMessage] = GeneralErrorMessage;

            return this.RedirectToAction("Index", "Home");
        }
    }
}
