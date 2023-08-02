namespace PCHCB.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Areas.Admin.Models;
    using PCHCB.Web.ViewModels.Case;
    using PCHCB.Web.ViewModels.Cooler;
    using PCHCB.Web.ViewModels.Cpu;
    using PCHCB.Web.ViewModels.Gpu;
    using PCHCB.Web.ViewModels.Motherboard;
    using PCHCB.Web.ViewModels.Psu;
    using PCHCB.Web.ViewModels.Ram;
    using PCHCB.Web.ViewModels.Storage;

    public class ProviderController : AdminController
    {
        private readonly IProviderService providerService;

        public ProviderController(IProviderService providerService)
        {
            this.providerService = providerService;
        }

        public async Task<IActionResult> Mine()
        {
            string? providerId = await this.providerService.GetProviderByUserIdAsync(this.User.GetId()!);

            List<CaseAllViewModel> cases = new List<CaseAllViewModel>();
            List<CpuAllViewModel> cpus = new List<CpuAllViewModel>();
            List<CoolerAllViewModel> coolers = new List<CoolerAllViewModel>();
            List<GpuAllViewModel> gpus = new List<GpuAllViewModel>();
            List<MotherboardAllViewModel> motherboards = new List<MotherboardAllViewModel>();
            List<PsuAllViewModel> psus = new List<PsuAllViewModel>();
            List<RamAllViewModel> rams = new List<RamAllViewModel>();
            List<StorageAllViewModel> storages = new List<StorageAllViewModel>();

            cases.AddRange(await this.providerService
                .AllCasesByProviderIdAsync(providerId!));
            cpus.AddRange(await this.providerService
                .AllCpusByProviderIdAsync(providerId!));
            coolers.AddRange(await this.providerService
                .AllCoolersByProviderIdAsync(providerId!));
            gpus.AddRange(await this.providerService
                .AllGpusByProviderIdAsync(providerId!));
            motherboards.AddRange(await this.providerService
                .AllMotherboardsByProviderIdAsync(providerId!));
            psus.AddRange(await this.providerService
                .AllPsusByProviderIdAsync(providerId!));
            rams.AddRange(await this.providerService
                .AllRamsByProviderIdAsync(providerId!));
            storages.AddRange(await this.providerService
                .AllStoragesByProviderIdAsync(providerId!));

            return View(new AdminMineViewModel
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
    }
}
