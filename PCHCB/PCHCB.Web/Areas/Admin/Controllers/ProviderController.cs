namespace PCHCB.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Services.Data;
    using PCHCB.Web.Areas.Admin.Models;

    public class ProviderController : AdminController
    {
        private readonly IProviderService providerService;

        public ProviderController(IProviderService providerService)
        {
            this.providerService = providerService;
        }

        public async Task<IActionResult> Mine()
        {
            string? ProviderId = await this.providerService.GetProviderByUserIdAsync(this.User.GetId()!);

            AdminMineViewModel viewModel = new AdminMineViewModel()
            {
                Cases = (List<ViewModels.Case.CaseAllViewModel>)await this.providerService.AllCasesByProviderIdAsync(ProviderId!),
                Coolers = (List<ViewModels.Cooler.CoolerAllViewModel>)await this.providerService.AllCoolersByProviderIdAsync(ProviderId!),
                Cpus = (List<ViewModels.Cpu.CpuAllViewModel>)await this.providerService.AllCpusByProviderIdAsync(ProviderId!),
                Gpus = (List<ViewModels.Gpu.GpuAllViewModel>)await this.providerService.AllGpusByProviderIdAsync(ProviderId!),
                Motherboards = (List<ViewModels.Motherboard.MotherboardAllViewModel>)await this.providerService.AllMotherboardsByProviderIdAsync(ProviderId!),
                Psus = (List<ViewModels.Psu.PsuAllViewModel>)await this.providerService.AllPsusByProviderIdAsync(ProviderId!),
                Rams = (List<ViewModels.Ram.RamAllViewModel>)await this.providerService.AllRamsByProviderIdAsync(ProviderId!),
                Storages = (List<ViewModels.Storage.StorageAllViewModel>)await this.providerService.AllStoragesByProviderIdAsync(ProviderId!)
            };

            return this.View(viewModel);
        }
    }
}
