namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

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

        [HttpGet]
        public async Task<IActionResult> SelectCpu()
        {
            var cpus = await this.cpuService.GetAllCpusAsync();

            return this.View(cpus);
        }
        // thinking about how to do this
        //[HttpPost]
        //public async Task<IActionResult> SelectMotherboard(int selectedCpuId)
        //{
        //    var selectedCpu = await dbContext.Cpus.FirstOrDefault(c => c.Id == selectedCpuId);

        //    var cpus = await dbContext.Cpus.Where(c => c.Socket == selectedCpu.Socket).ToList();

        //    return this.View(gpus);
        //}

        //[HttpPost]
        //public async Task<IActionResult> SelectMotherboard(int selectedCpuId, int selectedGpuId)
        //{
        //    var selectedCpu = await dbContext.Cpus.FirstOrDefault(c => c.Id == selectedCpuId);
        //    var selectedGpu = await dbContext.Gpus.FirstOrDefault(g => g.Id == selectedGpuId);

        //    var motherboards = dbContext.Motherboards.Where(m => m.Socket == selectedCpu.Socket && m.PcieSlots >= selectedGpu.PcieSlots).ToList();

        //    return this.View(motherboards);
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}
