namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Common;
    using PCHCB.Services.Data;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.Case;
    using PCHCB.Web.ViewModels.Cooler;
    using PCHCB.Web.ViewModels.Cpu;
    using PCHCB.Web.ViewModels.Gpu;
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Motherboard;
    using PCHCB.Web.ViewModels.PcConfiguration;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.ViewModels.Psu;
    using PCHCB.Web.ViewModels.Ram;
    using PCHCB.Web.ViewModels.Storage;

    using static PCHCB.Common.NotificationMessages;
    using static PCHCB.Common.ExceptionMessages;
    using static PCHCB.Common.ErrorMessages.User;
    using static PCHCB.Common.GeneralAppConstants;
    using Microsoft.Extensions.Configuration.UserSecrets;

    public class PcConfigurationController : Controller
    {
        private readonly IPcConfigurationService pcConfigurationService;
        private readonly IProviderService providerService;

        public PcConfigurationController(IPcConfigurationService pcConfigurationService, IProviderService providerService)
        {
            this.pcConfigurationService = pcConfigurationService;
            this.providerService = providerService;
        }

        public async Task<IActionResult> Assemble(AssembleConfigurationFormModel model)
        {
            var @case = pcConfigurationService.SelectCaseForAssemble(model.CaseId);
            var cooler = pcConfigurationService.SelectCoolerForAssemble(model.CoolerId);
            var cpu = pcConfigurationService.SelectCpuForAssemble(model.CpuId);
            var gpu = pcConfigurationService.SelectGpuForAssemble(model.GpuId);
            var motherboard = pcConfigurationService.SelectMotherboardForAssemble(model.MotherboardId);
            var ram = pcConfigurationService.SelectRamForAssemble(model.RamId, cooler.Id, motherboard.Id);
            var storage = pcConfigurationService.SelectStorageForAssemble(model.StorageId);
            var powerSupply = pcConfigurationService.SelectPsuForAssemble(model.PsuId, cpu.Id, gpu.Id, motherboard.Id, cooler.Id, storage.Id, ram.Id);

            var buildConfiguration = new AssembleConfigurationFormModel()
            {
                CaseId = @case.Id,
                CoolerId = cooler.Id,
                CpuId = cpu.Id,
                GpuId = gpu.Id,
                MotherboardId = motherboard.Id,
                PsuId = powerSupply.Id,
                RamId = ram.Id,
                StorageId = storage.Id,
            };

            int buildPc = await this.pcConfigurationService.AssemblePcConfiguration(buildConfiguration);

            return this.RedirectToAction("Index", "PcConfiguration", new
            {
                Id = buildPc,
            });
        }

        public async Task<IActionResult> Index()
        {
            string userId = this.User.GetId()!;
            if (userId == null)
            {
                this.TempData[WarningMessage] = BuilderErrorMessage;

                return this.RedirectToAction("Index", "Home");
            }

            if (this.User.IsInRole(AdminRoleName))
            {
                return this.RedirectToAction("Index", "PcConfiguration", new { Area = AdminAreaName });
            }

            List<PcConfigurationViewModel> pcBuilds =
                new List<PcConfigurationViewModel>();

            try
            {
                pcBuilds.AddRange(await pcConfigurationService.GetMyBuilds(userId));

                return View(pcBuilds);
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
