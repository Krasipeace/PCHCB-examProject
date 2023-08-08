namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.ViewModels.ConfigurationHardware;

    public class ConfigurationHardwareController : Controller
    {
        private readonly IConfigurationHardwareService configurationHardwareService;

        public ConfigurationHardwareController(IConfigurationHardwareService configurationHardwareService)
        {
            this.configurationHardwareService = configurationHardwareService;
        }

        public async Task<ActionResult> Assemble(AssembleConfigurationFormModel model)
        {
            var @case = configurationHardwareService.SelectCaseForAssemble(model.CaseId);
            var cooler = configurationHardwareService.SelectCoolerForAssemble(model.CoolerId);
            var cpu = configurationHardwareService.SelectCpuForAssemble(model.CpuId);
            var gpu = configurationHardwareService.SelectGpuForAssemble(model.GpuId);
            var motherboard = configurationHardwareService.SelectMotherboardForAssemble(model.MotherboardId);
            var ram = configurationHardwareService.SelectRamForAssemble(model.RamId, cooler.Id, motherboard.Id);
            var storage = configurationHardwareService.SelectStorageForAssemble(model.StorageId);
            var powerSupply = configurationHardwareService.SelectPsuForAssemble(model.PsuId, cpu.Id, gpu.Id, motherboard.Id, cooler.Id, storage.Id, ram.Id);

            var buildConfiguration = new AssembleConfigurationFormModel
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

            await configurationHardwareService.AssemblePcConfiguration(buildConfiguration);

            return RedirectToAction("Index", "PcConfiguration", new
            {
                id = buildConfiguration.PcConfigurationId
            });
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
