namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.ViewModels.PcConfiguration;

    [Authorize]
    public class PcConfigurationController : Controller
    {
        private readonly IPcConfigurationService pcConfigurationService;

        public PcConfigurationController(IPcConfigurationService pcConfigurationService)
        {
            this.pcConfigurationService = pcConfigurationService;
        }

        public async Task<ActionResult> Assemble(AssembleConfigurationFormModel model)
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
                Id = model.Id,
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

            return this.RedirectToAction("Assemble", "PcConfiguration", new
            {
                Id = buildPc,
            });
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
