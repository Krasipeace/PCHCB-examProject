namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data;
    using PCHCB.Data.Models;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.ViewModels.Case;
    using PCHCB.Web.ViewModels.Cooler;
    using PCHCB.Web.ViewModels.Cpu;
    using PCHCB.Web.ViewModels.Gpu;
    using PCHCB.Web.ViewModels.Motherboard;
    using PCHCB.Web.ViewModels.Psu;
    using PCHCB.Web.ViewModels.Ram;
    using PCHCB.Web.ViewModels.Storage;

    using static PCHCB.Common.ComponentsWattageConstants.Cooler;
    using static PCHCB.Common.EntityValidationConstants.Ram;
    using static PCHCB.Common.ComponentsWattageConstants.Motherboard;
    using static PCHCB.Common.ComponentsWattageConstants.Storage;
    using static PCHCB.Common.ComponentsWattageConstants.Ram;

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

        public async Task<MotherboardDetailsViewModel> SelectMotherboardForAssemble(int motherboardId)
        {
            Motherboard motherboard = await this.dbContext.Motherboards
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

        public async Task<CaseDetailsViewModel> SelectCaseForAssemble(int caseId)
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

        public async Task<CoolerDetailsViewModel> SelectCoolerForAssemble(int coolerId)
        {
            Cooler cooler = await this.dbContext.Coolers
                .AsNoTracking()
                .FirstAsync(c => c.Id == coolerId);

            if (cooler.Type == 0)
            {
                cooler = await this.dbContext.Coolers
                    .Include(c => c.ConfigurationHardwares)
                    .ThenInclude(cpu => cpu.Cpu)
                    .Where(c => c.ConfigurationHardwares
                        .Any(cpu => cpu.Cpu.Socket.ToLower()
                            .Contains(c.Compatibility.ToLower()) && c.Tdp >= (CoolerSecureTDPMultiplierValue * cpu.Cpu.Tdp)))
                    .Include(c => c.ConfigurationHardwares)
                    .ThenInclude(ca => ca.Case)
                    .Where(c => c.ConfigurationHardwares
                           .Any(ca => ca.Case.MaxAirCpuCoolerHeight >= c.CoolerHeight))
                    .FirstAsync(c => c.Id == coolerId);
            }
            else
            {
                int radiatorLength = 0;
                if ((int)cooler.RadiatorSize == 0)
                {
                    radiatorLength = 120;
                }
                else if ((int)cooler.RadiatorSize == 1)
                {
                    radiatorLength = 240;
                }
                else if ((int)cooler.RadiatorSize == 2)
                {
                    radiatorLength = 360;
                }
                else if ((int)cooler.RadiatorSize == 3)
                {
                    radiatorLength = 280;
                }
                else if ((int)cooler.RadiatorSize == 4)
                {
                    radiatorLength = 420;
                }

                cooler = await this.dbContext.Coolers
                    .Include(c => c.ConfigurationHardwares)
                    .ThenInclude(cpu => cpu.Cpu)
                    .Where(c => c.ConfigurationHardwares
                        .Any(cpu => cpu.Cpu.Socket.ToLower()
                            .Contains(c.Compatibility.ToLower()) && c.Tdp >= (CoolerSecureTDPMultiplierValue * cpu.Cpu.Tdp)))
                    .Include(c => c.ConfigurationHardwares)
                    .ThenInclude(ca => ca.Case)
                    .Where(c => c.ConfigurationHardwares
                        .Any(ca => ca.Case.MaxRadiatorLength >= radiatorLength))
                    .FirstAsync(c => c.Id == coolerId);
            }

            return new CoolerDetailsViewModel()
            {
                Name = cooler.Name,
                Compatibility = cooler.Compatibility,
                Tdp = cooler.Tdp,
                Price = cooler.Price,
            };
        }

        public async Task<RamDetailsViewModel> SelectRamForAssemble(int ramId, int coolerId, int motherboardId)
        {
            Ram ram = await this.dbContext.Rams
                .AsNoTracking()
                .FirstAsync(r => r.Id == ramId);
            Cooler cooler = await this.dbContext.Coolers
                .AsNoTracking()
                .FirstAsync(c => c.Id == coolerId);
            Motherboard motherboard = await this.dbContext.Motherboards
                .AsNoTracking()
                .FirstAsync(m => m.Id == motherboardId);

            // Current Problem: RAM might hit the air cooler, Cooler Width is not clear solution to the problem of ram hitting the cooler... for now i will check if the ram height is lower or equal than the standard for RAM Clearance = 32mm
            if (cooler.Type == 0)
            {
                ram = await this.dbContext.Rams
                    .Include(r => r.ConfigurationHardwares)
                    .ThenInclude(m => m.Motherboard)
                    .Where(r => r.ConfigurationHardwares
                        .Any(m => m.Motherboard.RamType == r.Type))
                    .Include(r => r.ConfigurationHardwares)
                    .ThenInclude(cool => cool.Cooler)
                    .Where(r => r.ConfigurationHardwares
                        .Any(r => r.Ram.Height <= RamClearanceValue))
                    .FirstAsync();
            }
            else if ((int)cooler.Type == 1)
            {
                ram = await this.dbContext.Rams
                    .Include(r => r.ConfigurationHardwares)
                    .ThenInclude(m => m.Motherboard)
                    .Where(r => r.ConfigurationHardwares
                        .Any(m => m.Motherboard.RamType == r.Type))
                    .FirstAsync();
            }

            return new RamDetailsViewModel()
            {
                Name = ram.Name,
                Frequency = ram.Frequency,
                Capacity = ram.Capacity,
                Height = ram.Height,
                Price = ram.Price,
            };
        }

        public async Task<StorageDetailsViewModel> SelectStorageForAssemble(int storageId)
        {
            Storage storage = await this.dbContext.Storages
                .AsNoTracking()
                .FirstAsync(s => s.Id == storageId);

            if ((int)storage.Type == 0 || (int)storage.Type == 1)
            {
                storage = await this.dbContext.Storages
                    .Include(s => s.ConfigurationHardwares)
                    .ThenInclude(c => c.Case)
                    .Where(s => s.ConfigurationHardwares
                        .Any(c => c.Case.MaxStorageDevices > 0))
                    .FirstAsync(s => s.Id == storageId);
            }
            else if ((int)storage.Type == 2)
            {
                storage = await this.dbContext.Storages
                    .Include(s => s.ConfigurationHardwares)
                    .ThenInclude(m => m.Motherboard)
                    .Where(s => s.ConfigurationHardwares
                        .Any(m => m.Motherboard.M2Slots > 0))
                    .FirstAsync(s => s.Id == storageId);
            }

            return new StorageDetailsViewModel()
            {
                Name = storage.Name,
                Capacity = storage.Capacity,
                Price = storage.Price,
            };
        }

        public async Task<PsuDetailsViewModel> SelectPsuForAssemble(int psuId, int cpuId, int gpuId, int motherboardId, int coolerId, int storageId, int ramId)
        {
            Cpu cpu = await this.dbContext.Cpus
                .AsNoTracking()
                .FirstAsync(c => c.Id == cpuId);
            Gpu gpu = await this.dbContext.Gpus
                .AsNoTracking()
                .FirstAsync(g => g.Id == gpuId);
            Motherboard motherboard = await this.dbContext.Motherboards
                .AsNoTracking()
                .FirstAsync(m => m.Id == motherboardId);
            Cooler cooler = await this.dbContext.Coolers
                .AsNoTracking()
                .FirstAsync(c => c.Id == coolerId);
            Storage storage = await this.dbContext.Storages
                .AsNoTracking()
                .FirstAsync(s => s.Id == storageId);
            Ram ram = await this.dbContext.Rams
                .AsNoTracking()
                .FirstAsync(r => r.Id == ramId);

            double ConfigurationWattage = await CalculateWattage(cpuId, motherboardId, gpuId, storageId, ramId, coolerId);

            Psu psu = await this.dbContext.Psus
                .Where(p => p.Wattage >= ConfigurationWattage)
                .FirstAsync(p => p.Id == psuId);

            return new PsuDetailsViewModel()
            {
                Name = psu.Name,
                Wattage = psu.Wattage,
                NvidiaConnector = psu.NvidiaConnector,
                Price = psu.Price,
            };
        }

        public Task<int> AssemblePcConfiguration(int pcConfigurationId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This Method is not Science-Proven, it is just a simple calculation that will sum up the wattage of the pc components in a pc configuration that will put all pc components performance to the max.
        /// </summary>
        /// <param name="cpuId"></param>
        /// <param name="gpuId"></param>
        /// <param name="motherboardId"></param>
        /// <param name="coolerId"></param>
        /// <param name="storageId"></param>
        /// <param name="ramId"></param>
        /// <returns></returns>
        public async Task<double> CalculateWattage(int cpuId, int gpuId, int motherboardId, int coolerId, int storageId, int ramId)
        {
            Cpu cpu = await this.dbContext.Cpus
                .AsNoTracking()
                .FirstAsync(c => c.Id == cpuId);
            Gpu gpu = await this.dbContext.Gpus
                .AsNoTracking()
                .FirstAsync(g => g.Id == gpuId);
            Motherboard motherboard = await this.dbContext.Motherboards
                .AsNoTracking()
                .FirstAsync(m => m.Id == motherboardId);
            Cooler cooler = await this.dbContext.Coolers
                .AsNoTracking()
                .FirstAsync(c => c.Id == coolerId);
            Storage storage = await this.dbContext.Storages
                .AsNoTracking()
                .FirstAsync(s => s.Id == storageId);
            Ram ram = await this.dbContext.Rams
                .AsNoTracking()
                .FirstAsync(r => r.Id == ramId);

            double motherboardWattage = GetMotherboardWattage(motherboard);
            double coolerWattage = GetCoolerWattage(cooler);
            double storageWattage = GetStorageWattage(storage);
            double ramWattage = GetRamWattage(ram);

            double totalWattage = cpu.Tdp +
                                  gpu.PowerConsumption +
                                  motherboardWattage +
                                  coolerWattage +
                                  storageWattage +
                                  ramWattage;

            return totalWattage;
        }

        private static double GetMotherboardWattage(Motherboard motherboard)
        {
            double motherboardWattage = 0;
            if ((int)motherboard.FormFactor == 0)
            {
                motherboardWattage = AtxWattage;
            }
            else if ((int)motherboard.FormFactor == 1)
            {
                motherboardWattage = MicroAtxWattage;
            }
            else if ((int)motherboard.FormFactor == 2)
            {
                motherboardWattage = MiniItxWattage;
            }
            else if ((int)motherboard.FormFactor == 3)
            {
                motherboardWattage = ExtendedAtxWattage;
            }

            return motherboardWattage;
        }

        private static double GetCoolerWattage(Cooler cooler)
        {
            double coolerWattage = 0;
            if ((int)cooler.Type == 0)
            {
                coolerWattage = AirWattage;
            }
            else if ((int)cooler.Type == 1)
            {
                coolerWattage = WaterWattage;
            }

            return coolerWattage;
        }

        private static double GetStorageWattage(Storage storage)
        {
            double storageWattage = 0;
            if ((int)storage.Type == 0)
            {
                storageWattage = HddWattage;
            }
            else if ((int)storage.Type == 1)
            {
                storageWattage = SsdWattage;
            }
            else if ((int)storage.Type == 2)
            {
                storageWattage = M2Wattage;
            }

            return storageWattage;
        }

        private static double GetRamWattage(Ram ram)
        {
            double ramWattage = 0;
            if ((int)ram.Type == 0)
            {
                ramWattage = Ddr3Wattage;
            }
            else if ((int)ram.Type == 1)
            {
                ramWattage = Ddr4Wattage;
            }
            else if ((int)ram.Type == 2)
            {
                ramWattage = Ddr5Wattage;
            }

            return ramWattage;
        }
    }
}
