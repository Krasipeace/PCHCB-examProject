namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data;
    using PCHCB.Data.Models;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.ViewModels.Case;
    using PCHCB.Web.ViewModels.ConfigurationHardware;
    using PCHCB.Web.ViewModels.Cooler;
    using PCHCB.Web.ViewModels.Cpu;
    using PCHCB.Web.ViewModels.Gpu;
    using PCHCB.Web.ViewModels.Motherboard;
    using PCHCB.Web.ViewModels.Psu;
    using PCHCB.Web.ViewModels.Ram;
    using PCHCB.Web.ViewModels.Storage;

    public class ConfigurationHardwareService : IConfigurationHardwareService
    {
        private readonly PCHCBDbContext dbContext;

        public ConfigurationHardwareService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<CpuDetailsViewModel> SelectCpuForAssemble(int cpuId)
        {
            Cpu cpu = await this.dbContext.Cpus
                .FirstAsync(c => c.Id == cpuId);

            return new CpuDetailsViewModel()
            {
                Name = cpu.Name, 
                Tdp = cpu.Tdp,
                Socket = cpu.Socket,
                Frequency = cpu.Frequency,
                Cores = cpu.Cores,
                Price = cpu.Price,
            };
        }

        public async Task<GpuDetailsViewModel> SelectGpuForAssemble(int gpuId)
        {
            Gpu gpu = await this.dbContext.Gpus
                .FirstAsync(g => g.Id == gpuId);

            return new GpuDetailsViewModel()
            {
                Name = gpu.Name,
                Memory = gpu.Memory,
                PowerConsumption = gpu.PowerConsumption,
                NvidiaConnector = gpu.NvidiaConnector,
                Interface = (int)gpu.Interface,
                Price = gpu.Price,
            };
        }

        public async Task<MotherboardDetailsViewModel> SelectMotherboardForAssemble(int motherboardId, int cpuId)
        {
            Motherboard motherboard = await this.dbContext.Motherboards
                .AsNoTracking()
                .Include(m => m.ConfigurationHardwares)
                .ThenInclude(c => c.Cpu)
                .Where(m => m.ConfigurationHardwares
                    .Any(c => c.Cpu.Socket.ToLower()
                        .Contains(m.Socket.ToLower())))
                .FirstAsync(m => m.Id == motherboardId);

            return new MotherboardDetailsViewModel()
            {
                Name = motherboard.Name,
                Socket = motherboard.Socket,
                Chipset = motherboard.Chipset,
                RamType = (int)motherboard.RamType,
                M2Slots = motherboard.M2Slots,
                FormFactor = (int)motherboard.FormFactor,
                Price = motherboard.Price,
            };
        }

        public async Task<CaseDetailsViewModel> SelectCaseForAssemble(int caseId, int motherboardId, int gpuId)
        {
            Case @case = await this.dbContext.Cases
                .AsNoTracking()
                .Include(c => c.ConfigurationHardwares)
                .ThenInclude(m => m.Motherboard)
                .Where(c => c.ConfigurationHardwares
                    .Any(m => m.Motherboard.FormFactor == c.FormFactor))
                .FirstAsync(c => c.Id == caseId);

            return new CaseDetailsViewModel()
            {
                Name = @case.Name,
                CaseSize = (int)@case.CaseSize,
                FormFactor = (int)@case.FormFactor,
                PsuFactor = (int)@case.PsuFactor,
                Price = @case.Price,
            };
        }

        public async Task<CoolerDetailsViewModel> SelectCoolerForAssemble(int coolerId, int caseId, int cpuId)
        {
            Cooler cooler = await this.dbContext.Coolers
                .FirstAsync(c => c.Id == coolerId);

            if (cooler.Type == 0)
            {
                cooler.RadiatorSize = 0;

                cooler = await this.dbContext.Coolers
                    .Include(c => c.ConfigurationHardwares)
                    .ThenInclude(cpu => cpu.Cpu)
                    .Where(c => c.ConfigurationHardwares
                        .Any(cpu => cpu.Cpu.Socket.ToLower()
                            .Contains(c.Compatibility.ToLower())))
                    .Include(c => c.ConfigurationHardwares)
                    .ThenInclude(ca => ca.Case)
                        .Where(c => c.ConfigurationHardwares
                           .Any(ca => ca.Case.MaxAirCpuCoolerHeight >= c.CoolerHeight))
                    .FirstAsync(c => c.Id == coolerId);
            }

            return new CoolerDetailsViewModel()
            {
                Name = cooler.Name,
                CoolerHeight = cooler.CoolerHeight,
                RadiatorSize = (int)cooler.RadiatorSize,
                Compatibility = cooler.Compatibility,
                Tdp = cooler.Tdp,
                Price = cooler.Price,
            };
        }

        public async Task<RamDetailsViewModel> SelectRamForAssemble(int ramId, int motherboardId, int cpuId)
        {
            Ram ram = await this.dbContext.Rams
                .FirstAsync(r => r.Id == ramId);

            return new RamDetailsViewModel()
            {
                Name = ram.Name,
                Frequency = ram.Frequency,
                Capacity = ram.Capacity,
                Type = (int)ram.Type,
                Height = ram.Height,
                Price = ram.Price,
            };
        }

        public async Task<StorageDetailsViewModel> SelectStorageForAssemble(int storageId, int motherboardId)
        {
            Storage storage = await this.dbContext.Storages
                .FirstAsync(s => s.Id == storageId);

            return new StorageDetailsViewModel()
            {
                Name = storage.Name,
                Capacity = storage.Capacity,
                Type = (int)storage.Type,
                Price = storage.Price,
            };
        }

        public async Task<PsuDetailsViewModel> SelectPsuForAssemble(int psuId, int caseId)
        {
            Psu psu = await this.dbContext.Psus
                .FirstAsync(p => p.Id == psuId);

            return new PsuDetailsViewModel()
            {
                Name = psu.Name,
                Wattage = psu.Wattage,
                NvidiaConnector = psu.NvidiaConnector,
                Price = psu.Price,
            };
        }

        public Task<IEnumerable<AssembleConfigurationFormModel>> AssemblePcConfiguration(int pcConfigurationId)
        {
            throw new NotImplementedException();
        }

        public Task<double> CalculateWattage(int cpuId, int gpuId, int motherboardId, int coolerId, int storageId)
        {
            throw new NotImplementedException();
        }
    }
}
