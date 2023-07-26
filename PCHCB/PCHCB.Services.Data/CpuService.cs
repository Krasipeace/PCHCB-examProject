namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Data;
    using PCHCB.Web.ViewModels.Cpu;
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Provider;

    using static PCHCB.Common.GeneralAppConstants;

    public class CpuService : ICpuService
    {
        private readonly PCHCBDbContext dbContext;

        public CpuService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> CreateCpuAsync(string providerId, CpuFormModel model)
        {
            Cpu cpu = new Cpu()
            {
                Name = model.Name,
                Price = model.Price,
                Socket = model.Socket,
                Cores = model.Cores,
                Threads = model.Threads,
                Frequency = model.Frequency,
                TurboFrequency = model.TurboFrequency,
                Cache = model.Cache,
                Tdp = model.Tdp,
                RamFrequency = model.RamFrequency,
                RamType = (RamType)model.RamType,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse(providerId),
            };

            await this.dbContext.Cpus.AddAsync(cpu);
            await this.dbContext.SaveChangesAsync();

            return cpu.Id;
        }

        public async Task<CpuFormModel> GetCpuForEditByIdAsync(int cpuId)
        {
            Cpu cpu = await this.dbContext.Cpus
                .FirstAsync(c => c.Id == cpuId);

            return new CpuFormModel()
            {
                Name = cpu.Name,
                Price = cpu.Price,
                Socket = cpu.Socket,
                Cores = cpu.Cores,
                Threads = cpu.Threads,
                Frequency = cpu.Frequency,
                TurboFrequency = cpu.TurboFrequency,
                Cache = cpu.Cache,
                Tdp = cpu.Tdp,
                RamFrequency = cpu.RamFrequency,
                RamType = (int)cpu.RamType,
                ImageUrl = cpu.ImageUrl,
                Description = cpu.Description,
            };
        }

        public async Task EditCpuByIdAndFormModelAsync(int cpuId, CpuFormModel model)
        {
            Cpu cpu = await this.dbContext.Cpus
                .FirstAsync(c => c.Id == cpuId);

            cpu.Name = model.Name;
            cpu.Price = model.Price;
            cpu.Socket = model.Socket;
            cpu.Cores = model.Cores;
            cpu.Threads = model.Threads;
            cpu.Frequency = model.Frequency;
            cpu.TurboFrequency = model.TurboFrequency;
            cpu.Cache = model.Cache;
            cpu.Tdp = model.Tdp;
            cpu.RamFrequency = model.RamFrequency;
            cpu.RamType = (RamType)model.RamType;
            cpu.ImageUrl = model.ImageUrl;
            cpu.Description = model.Description;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsCpuExistByIdAsync(int cpuId)
        {
            bool result = await this.dbContext.Cpus
                .AnyAsync(c => c.Id == cpuId);

            return result;
        }

        public async Task<bool> IsProviderIdOwnerOfCpuIdAsync(string providerId, int cpuId)
        {
            Cpu cpu = await this.dbContext.Cpus
                .FirstAsync(c => c.Id == cpuId);

            return cpu.ProviderId.ToString() == providerId;
        }

        public async Task<DeleteDetailsViewModel> GetCpuForDeleteByIdAsync(int cpuId)
        {
            Cpu cooler = await dbContext.Cpus
                .FirstAsync(c => c.Id == cpuId);

            return new DeleteDetailsViewModel
            {
                Name = cooler.Name,
                Description = cooler.Description,
                ImageUrl = cooler.ImageUrl
            };
        }

        public async Task DeleteCpuByIdAsync(int cpuId)
        {
            Cpu cpu = await this.dbContext.Cpus
                .FirstAsync(c => c.Id == cpuId);

            cpu.Name = ComponentUnavailable;
            this.dbContext.Cpus.Remove(cpu);

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<AllViewModel>> GetAllCpusAsync()
        {
            return await this.dbContext.Cpus
                .Where(c => c.Name != ComponentUnavailable)
                .Select(c => new AllViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Price = c.Price,
                    ImageUrl = c.ImageUrl,
                })
                .ToListAsync();
        }

        public async Task<CpuDetailsViewModel> GetCpuDetailsAsync(int cpuId)
        {
            Cpu cpu = await dbContext.Cpus
                .Include(c => c.Provider)
                .ThenInclude(u => u.User)
                .Where(c => c.Name != ComponentUnavailable)
                .FirstAsync(c => c.Id == cpuId);

            return new CpuDetailsViewModel
            {
                Id = cpu.Id,
                Name = cpu.Name,
                Socket = cpu.Socket,
                Price = cpu.Price,
                Cores = cpu.Cores,
                Threads = cpu.Threads,
                Frequency = cpu.Frequency,
                TurboFrequency = cpu.TurboFrequency,
                Cache = cpu.Cache,
                Tdp = cpu.Tdp,
                RamFrequency = cpu.RamFrequency,
                RamType = (int)cpu.RamType,
                ImageUrl = cpu.ImageUrl,
                Description = cpu.Description,
                Provider = new ProviderInfoViewModel()
                {
                    WebPage = cpu.Provider.WebPage,
                }
            };
        }
    }
}
