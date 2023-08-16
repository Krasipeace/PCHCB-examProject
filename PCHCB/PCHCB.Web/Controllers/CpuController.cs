namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.Cpu;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.ViewModels.Home;

    using static PCHCB.Common.NotificationMessages;
    using static PCHCB.Common.ErrorMessages.Provider;
    using static PCHCB.Common.ErrorMessages.Cpu;
    using static PCHCB.Common.SuccessMessages;
    using static PCHCB.Common.ExceptionMessages;

    [Authorize]
    public class CpuController : Controller
    {
        private readonly ICpuService cpuService;
        private readonly IProviderService providerService;

        public CpuController(ICpuService cpuService, IProviderService providerService)
        {
            this.cpuService = cpuService;
            this.providerService = providerService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = UserCannotAddCpusErrorMessage;

                return this.RedirectToAction("BecomeProvider", "Provider");
            }

            try
            {
                CpuFormModel model = new CpuFormModel();

                return this.View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(CpuFormModel model)
        {
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(this.User.GetId()!);

            if (!isProvider)
            {
                this.TempData[ErrorMessage] = UserCannotAddCpusErrorMessage;

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

                int cpuId = await this.cpuService
                    .CreateCpuAsync(providerId!, model);

                this.TempData[SuccessMessage] = CpuAddedSuccessfully;

                return this.RedirectToAction("Add", "Cpu", new
                {
                    id = cpuId
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
            bool cpuExists = await cpuService
                .IsCpuExistByIdAsync(id);
            if (!cpuExists)
            {
                TempData[ErrorMessage] = CpuWithIdDoesNotExist;

                return RedirectToAction("All", "Cpu");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotEditCpusErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }
            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await cpuService
                .IsProviderIdOwnerOfCpuIdAsync(providerId!, id);

            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotEditCpuHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                CpuFormModel formModel = await cpuService
                    .GetCpuForEditByIdAsync(id);

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CpuFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool cpuExists = await cpuService
                .IsCpuExistByIdAsync(id);
            if (!cpuExists)
            {
                TempData[ErrorMessage] = CpuWithIdDoesNotExist;

                return RedirectToAction("All", "Cpu");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotEditCpusErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await cpuService
                .IsProviderIdOwnerOfCpuIdAsync(providerId!, id);

            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotEditCpuHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                await cpuService.EditCpuByIdAndFormModelAsync(id, model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, GeneralErrorMessage);

                return View(model);
            }

            TempData[SuccessMessage] = CpuEditedSuccessfully;

            return RedirectToAction("Edit", "Cpu", new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            bool cpuExists = await cpuService
                .IsCpuExistByIdAsync(id);
            if (!cpuExists)
            {
                TempData[ErrorMessage] = CpuWithIdDoesNotExist;

                return RedirectToAction("All", "Cpu");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotDeleteCpusErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await cpuService
                .IsProviderIdOwnerOfCpuIdAsync(providerId!, id);
            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotDeleteCpuHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }
            try
            {
                DeleteDetailsViewModel viewModel = await cpuService
                    .GetCpuForDeleteByIdAsync(id);

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
            bool cpuExists = await cpuService
                .IsCpuExistByIdAsync(id);
            if (!cpuExists)
            {
                TempData[ErrorMessage] = CpuWithIdDoesNotExist;

                return RedirectToAction("All", "Cpu");
            }

            bool isUserProvider = await providerService
                .ProviderExistsByUserIdAsync(User.GetId()!);
            if (!isUserProvider)
            {
                TempData[ErrorMessage] = UserCannotDeleteCpusErrorMessage;

                return RedirectToAction("BecomeProvider", "Provider");
            }

            string? providerId = await providerService
                .GetProviderByUserIdAsync(User.GetId()!);
            bool isProviderOwner = await cpuService
                .IsProviderIdOwnerOfCpuIdAsync(providerId!, id);
            if (!isProviderOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = ProviderCannotDeleteCpuHeDoesNotOwnErrorMessage;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                await cpuService.DeleteCpuByIdAsync(id);

                TempData[WarningMessage] = CpuDeletedSuccessfully;

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
            bool cpuExists = await cpuService
                .IsCpuExistByIdAsync(id);
            if (!cpuExists)
            {
                TempData[ErrorMessage] = CpuWithIdDoesNotExist;

                return RedirectToAction("Mine", "Provider");
            }

            try
            {
                CpuDetailsViewModel viewModel = await cpuService
                    .GetCpuDetailsAsync(id);

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
            SearchResult serviceModel = await cpuService.SearchCpusAsync(queryModel);

            queryModel.Cpus = serviceModel.Cpus;
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
