namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.PcConfiguration;
    using PCHCB.Web.ViewModels.Gpu;
    using PCHCB.Web.ViewModels.Cpu;

    using static PCHCB.Common.NotificationMessages;
    using static PCHCB.Common.ExceptionMessages;
    using static PCHCB.Common.ErrorMessages.User;
    using static PCHCB.Common.SuccessMessages;

    public class PcConfigurationController : Controller
    {
        private readonly IPcConfigurationService pcConfigurationService;
        private readonly ICaseService caseService;
        private readonly ICoolerService coolerService;
        private readonly ICpuService cpuService;
        private readonly IGpuService gpuService;
        private readonly IMotherboardService motherboardService;
        private readonly IPsuService psuService;
        private readonly IRamService ramService;
        private readonly IStorageService storageService;

        public PcConfigurationController(IPcConfigurationService pcConfigurationService, ICaseService caseService, ICoolerService coolerService, ICpuService cpuService, IGpuService gpuService, IMotherboardService motherboardService, IPsuService psuService, IRamService ramService, IStorageService storageService)
        {
            this.pcConfigurationService = pcConfigurationService;
            this.caseService = caseService;
            this.coolerService = coolerService;
            this.cpuService = cpuService;
            this.gpuService = gpuService;
            this.motherboardService = motherboardService;
            this.psuService = psuService;
            this.ramService = ramService;
            this.storageService = storageService;
        }

        [HttpGet]
        public async Task<IActionResult> Assemble()
        {
            try
            {
                ViewData["Gpus"] = await this.gpuService.GetAllGpusAsync();
                ViewData["Cpus"] = await this.cpuService.GetAllCpusAsync();
                ViewData["Motherboards"] = await this.motherboardService.GetAllMotherboardsAsync();
                ViewData["Cases"] = await this.caseService.GetAllCasesAsync();
                ViewData["Coolers"] = await this.coolerService.GetAllCoolersAsync();
                ViewData["Rams"] = await this.ramService.GetAllRamsAsync();
                ViewData["Storages"] = await this.storageService.GetAllStoragesAsync();
                ViewData["Psus"] = await this.psuService.GetAllPsusAsync();

                return this.View();
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Assemble(AssembleConfigurationFormModel model)
        {
            var gpu = pcConfigurationService.SelectGpuForAssemble(model.GpuId);
            var cpu = pcConfigurationService.SelectCpuForAssemble(model.CpuId);
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

            this.TempData[SuccessMessage] = PcBuildedSuccessfully;

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

            List<PcConfigurationViewModel> pcBuilds = new List<PcConfigurationViewModel>();

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
