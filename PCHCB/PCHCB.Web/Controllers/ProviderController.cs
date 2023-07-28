namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.Infrastructure.Extensions;

    using static PCHCB.Common.NotificationMessages;
    using static PCHCB.Common.ErrorMessages.Provider;
    using static PCHCB.Common.ErrorMessages.General;
    using static PCHCB.Common.ExceptionMessages;
    using static PCHCB.Common.SuccessMessages;
    using PCHCB.Web.ViewModels.Case;
    using PCHCB.Web.ViewModels.Cpu;
    using PCHCB.Web.ViewModels.Cooler;
    using PCHCB.Web.ViewModels.Gpu;
    using PCHCB.Web.ViewModels.Motherboard;
    using PCHCB.Web.ViewModels.Psu;
    using PCHCB.Web.ViewModels.Ram;
    using PCHCB.Web.ViewModels.Storage;

    [Authorize]
    public class ProviderController : Controller
    {
        private readonly IProviderService providerService;

        public ProviderController(IProviderService providerService)
        {
            this.providerService = providerService;
        }

        [HttpGet]
        public async Task<IActionResult> BecomeProvider()
        {
            string? userId = this.User.GetId();
            bool isProviderExists = await this.providerService
                .ProviderExistsByUserIdAsync(userId!);

            if (isProviderExists)
            {
                this.TempData[ErrorMessage] = ProviderAlreadyExists;

                return this.RedirectToAction("Index", "Home");
            }

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> BecomeProvider(BecomeProviderFormModel model)
        {
            string? userId = this.User.GetId();
            bool isProviderExists = await this.providerService
                .ProviderExistsByUserIdAsync(userId!);

            if (isProviderExists)
            {
                this.TempData[ErrorMessage] = ProviderAlreadyExists;

                return this.RedirectToAction("Index", "Home");
            }

            bool isPhoneNumberExists = await this.providerService
                .ProviderExistsByPhoneNumber(model.PhoneNumber);
            if (isPhoneNumberExists)
            {
                this.ModelState.AddModelError(nameof(model.PhoneNumber), ProviderWithPhoneNumberAlreadyExists);

                return this.View(model);
            }

            bool isWebPageExists = await this.providerService
                .ProviderExistsByWebSite(model.WebPage);
            if (isWebPageExists)
            {
                this.ModelState.AddModelError(nameof(model.WebPage), ProviderWithSuchWebPageAlreadyExists);

                return this.View(model);
            }

            bool isLogoUrlExists = await this.providerService
                .ProviderExistsByLogoUrl(model.LogoUrl);
            if (isLogoUrlExists)
            {
                this.ModelState.AddModelError(nameof(model.LogoUrl), ProviderWithSuchLogoUrlAlreadyExists);

                return this.View(model);
            }

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            try
            {
                await this.providerService.CreateProvider(userId!, model);

                this.TempData[SuccessMessage] = ProviderCreatedSuccessfully;
            }
            catch (Exception)
            {
                this.TempData[ErrorMessage] = SomethingWentWrong;

                return this.RedirectToAction("Index", "Home");
            }

            return this.RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> ProviderDetails(string id)
        {
            try
            {
                ProviderDetailsViewModel viewModel = await this.providerService
                    .GetProviderDetailsByIdAsync(id);

                return View(viewModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            string userId = this.User.GetId()!;
            bool isProvider = await this.providerService
                .ProviderExistsByUserIdAsync(userId);

            List<CaseAllViewModel> cases = new List<CaseAllViewModel>();
            List<CpuAllViewModel> cpus = new List<CpuAllViewModel>();
            List<CoolerAllViewModel> coolers = new List<CoolerAllViewModel>();
            List<GpuAllViewModel> gpus = new List<GpuAllViewModel>();
            List<MotherboardAllViewModel> motherboards = new List<MotherboardAllViewModel>();
            List<PsuAllViewModel> psus = new List<PsuAllViewModel>();
            List<RamAllViewModel> rams = new List<RamAllViewModel>();
            List<StorageAllViewModel> storages = new List<StorageAllViewModel>();

            string? providerId = await providerService.GetProviderByUserIdAsync(userId);
            if (providerId == null)
            {
                this.TempData[WarningMessage] = OnlyProviderCanViewHisHardwareErrorMessage;

                return this.RedirectToAction("Index", "Home");
            }

            try
            {
                if (isProvider)
                {
                    cases.AddRange(await this.providerService
                        .AllCasesByProviderIdAsync(providerId));
                    cpus.AddRange(await this.providerService
                        .AllCpusByProviderIdAsync(providerId));
                    coolers.AddRange(await this.providerService
                        .AllCoolersByProviderIdAsync(providerId));
                    gpus.AddRange(await this.providerService
                        .AllGpusByProviderIdAsync(providerId));
                    motherboards.AddRange(await this.providerService
                        .AllMotherboardsByProviderIdAsync(providerId));
                    psus.AddRange(await this.providerService
                        .AllPsusByProviderIdAsync(providerId));
                    rams.AddRange(await this.providerService
                        .AllRamsByProviderIdAsync(providerId));
                    storages.AddRange(await this.providerService
                        .AllStoragesByProviderIdAsync(providerId));
                }

                return View(new MineViewModel
                {
                    Cases = cases,                   
                    Cpus = cpus,
                    Coolers = coolers,
                    Gpus = gpus,
                    Motherboards = motherboards,
                    Psus = psus,
                    Rams = rams,
                    Storages = storages
                });
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
