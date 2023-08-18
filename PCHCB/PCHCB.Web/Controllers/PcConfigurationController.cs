namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Infrastructure.Extensions;
    using PCHCB.Web.ViewModels.PcConfiguration;

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
        private readonly IUserService userService;

        public PcConfigurationController(IPcConfigurationService pcConfigurationService, 
                                        ICaseService caseService, 
                                        ICoolerService coolerService, 
                                        ICpuService cpuService, 
                                        IGpuService gpuService, 
                                        IMotherboardService motherboardService, 
                                        IPsuService psuService, 
                                        IRamService ramService, 
                                        IStorageService storageService,
                                        IUserService userService)
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
            this.userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Assemble()
        {
            try
            {
                ViewData["Gpus"] = await this.gpuService.GetAllGpusDetailsAsync();
                ViewData["Cpus"] = await this.cpuService.GetAllCpusDetailsAsync();
                ViewData["Motherboards"] = await this.motherboardService.GetAllMotherboardsDetailsAsync();
                ViewData["Cases"] = await this.caseService.GetAllCasesDetailsAsync();
                ViewData["Coolers"] = await this.coolerService.GetAllCoolersDetailsAsync();
                ViewData["Rams"] = await this.ramService.GetAllRamsDetailsAsync();
                ViewData["Storages"] = await this.storageService.GetAllStoragesDetailsAsync();
                ViewData["Psus"] = await this.psuService.GetAllPsusDetailsAsync();

                return this.View();
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Assemble(AssembleConfigurationFormModel model, string builderId)
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
                BuilderId = Guid.Parse(builderId)
            };

            await this.pcConfigurationService.AssemblePcConfiguration(buildConfiguration, builderId);

            this.TempData[SuccessMessage] = PcBuildedSuccessfully;

            return this.RedirectToAction("MyBuilds", "PcConfiguration");
        }

        public async Task<IActionResult> MyBuilds()
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
