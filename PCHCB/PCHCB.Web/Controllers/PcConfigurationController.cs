namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.PcConfiguration;
    using PCHCB.Web.ViewModels.Case;
    using PCHCB.Web.ViewModels.Cooler;
    using PCHCB.Web.ViewModels.Cpu;
    using PCHCB.Web.ViewModels.Gpu;
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Motherboard;
    using PCHCB.Web.ViewModels.Psu;
    using PCHCB.Web.ViewModels.Ram;
    using PCHCB.Web.ViewModels.Storage;

    using static PCHCB.Common.NotificationMessages;
    using static PCHCB.Common.ExceptionMessages;
    using static PCHCB.Common.ErrorMessages.User;

    public class PcConfigurationController : Controller
    {
        private readonly IPcConfigurationService pcConfigurationService;

        public PcConfigurationController(IPcConfigurationService pcConfigurationService)
        {
            this.pcConfigurationService = pcConfigurationService;
        }



        public async Task<IActionResult> Assemble(AssembleConfigurationFormModel model)
        {
            var cpu = pcConfigurationService.SelectCpuForAssemble(model.CpuId);
            var gpu = pcConfigurationService.SelectGpuForAssemble(model.GpuId);
            var motherboard = pcConfigurationService.SelectMotherboardForAssemble(model.MotherboardId);
            var @case = pcConfigurationService.SelectCaseForAssemble(model.CaseId);
            var cooler = pcConfigurationService.SelectCoolerForAssemble(model.CoolerId);
            var ram = pcConfigurationService.SelectRamForAssemble(model.RamId, cooler.Id);
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
