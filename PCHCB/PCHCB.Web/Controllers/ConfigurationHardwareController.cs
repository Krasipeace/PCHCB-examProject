namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PCHCB.Services.Data.Contracts;

    public class ConfigurationHardwareController : Controller
    {
        private readonly IConfigurationHardwareService configurationHardwareService;
        private readonly ICaseService caseService;
        private readonly ICpuService cpuService;
        private readonly ICoolerService coolerService;
        private readonly IMotherboardService motherboardService;
        private readonly IRamService ramService;
        private readonly IStorageService storageService;
        private readonly IGpuService gpuService;
        private readonly IPsuService psuService;

        public ConfigurationHardwareController(IConfigurationHardwareService configurationHardwareService, ICaseService caseService, ICpuService cpuService, ICoolerService coolerService, IMotherboardService motherboardService, IRamService ramService, IStorageService storageService, IGpuService gpuService, IPsuService psuService)
        {
            this.configurationHardwareService = configurationHardwareService;
            this.caseService = caseService;
            this.cpuService = cpuService;
            this.coolerService = coolerService;
            this.motherboardService = motherboardService;
            this.ramService = ramService;
            this.storageService = storageService;
            this.gpuService = gpuService;
            this.psuService = psuService;
        }
     
        public IActionResult Index()
        {
            return View();
        }
    }
}
