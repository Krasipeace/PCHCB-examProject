namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data.Models;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Data;
    using PCHCB.Web.ViewModels.Case;
    using PCHCB.Web.ViewModels.Cooler;
    using PCHCB.Web.ViewModels.Cpu;
    using PCHCB.Web.ViewModels.Gpu;
    using PCHCB.Web.ViewModels.Motherboard;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.ViewModels.Psu;
    using PCHCB.Web.ViewModels.Ram;
    using PCHCB.Web.ViewModels.Storage;

    public class ProviderService : IProviderService
    {
        private readonly PCHCBDbContext dbContext;

        public ProviderService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateProvider(string userId, BecomeProviderFormModel model)
        {
            Provider newProvider = new()
            {
                PhoneNumber = model.PhoneNumber,
                WebPage = model.WebPage,
                LogoUrl = model.LogoUrl,
                Description = model.Description,
                UserId = Guid.Parse(userId),
            };

            await this.dbContext.Providers
                .AddAsync(newProvider);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<string?> GetProviderByUserIdAsync(string userId)
        {
            Provider? provider = await this.dbContext.Providers
                .FirstOrDefaultAsync(p => p.UserId.ToString() == userId);
            if (provider == null)
            {
                return null;
            }

            return provider.Id.ToString();
        }

        public async Task<ProviderDetailsViewModel> GetProviderDetailsByIdAsync(string providerId)
        {
            return await this.dbContext.Providers
                .Select(p => new ProviderDetailsViewModel()
                {
                    Id = p.Id,
                    PhoneNumber = p.PhoneNumber,
                    WebPage = p.WebPage,
                    LogoUrl = p.LogoUrl,
                    Description = p.Description
                })
                .FirstAsync(p => p.Id.ToString().ToLower() == providerId.ToLower());
        }

        public async Task<bool> ProviderExistsByLogoUrl(string logoUrl)
        {
            bool result = await this.dbContext.Providers
                .AnyAsync(p => p.LogoUrl == logoUrl);

            return result;
        }

        public async Task<bool> ProviderExistsByPhoneNumber(string phoneNumber)
        {
            bool result = await this.dbContext.Providers
                .AnyAsync(p => p.PhoneNumber == phoneNumber);

            return result;
        }

        public async Task<bool> ProviderExistsByUserIdAsync(string userId)
        {
            bool result = await this.dbContext.Providers
                .AnyAsync(p => p.UserId.ToString() == userId);

            return result;
        }

        public async Task<bool> ProviderExistsByWebSite(string webPage)
        {
            bool result = await this.dbContext.Providers
                .AnyAsync(p => p.WebPage == webPage);

            return result;
        }

        public async Task<IEnumerable<CaseAllViewModel>> AllCasesByProviderIdAsync(string providerId)
        {
            IEnumerable<CaseAllViewModel> allProviderCases = await dbContext.Cases
                .Where(p => p.ProviderId.ToString().ToLower() == providerId.ToLower())
                .Select(c => new CaseAllViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Price = c.Price,
                    ImageUrl = c.ImageUrl
                })
                .ToArrayAsync();

            return allProviderCases;
        }

        public async Task<IEnumerable<CoolerAllViewModel>> AllCoolersByProviderIdAsync(string providerId)
        {
            IEnumerable<CoolerAllViewModel> allProviderCoolers = await dbContext.Coolers
                .Where(p => p.ProviderId.ToString().ToLower() == providerId.ToLower())
                .Select(c => new CoolerAllViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Price = c.Price,
                    ImageUrl = c.ImageUrl
                })
                .ToArrayAsync();

            return allProviderCoolers;
        }

        public async Task<IEnumerable<CpuAllViewModel>> AllCpusByProviderIdAsync(string providerId)
        {
            IEnumerable<CpuAllViewModel> allProviderCpus = await dbContext.Cpus
                .Where(p => p.ProviderId.ToString().ToLower() == providerId.ToLower())
                .Select(c => new CpuAllViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Price = c.Price,
                    ImageUrl = c.ImageUrl
                })
                .ToArrayAsync();

            return allProviderCpus;
        }

        public async Task<IEnumerable<GpuAllViewModel>> AllGpusByProviderIdAsync(string providerId)
        {
            IEnumerable<GpuAllViewModel> allProviderGpus = await dbContext.Gpus
                .Where(p => p.ProviderId.ToString().ToLower() == providerId.ToLower())
                .Select(g => new GpuAllViewModel
                {
                    Id = g.Id,
                    Name = g.Name,
                    Price = g.Price,
                    ImageUrl = g.ImageUrl
                })
                .ToArrayAsync();

            return allProviderGpus;
        }

        public async Task<IEnumerable<MotherboardAllViewModel>> AllMotherboardsByProviderIdAsync(string providerId)
        {
            IEnumerable<MotherboardAllViewModel> allProviderMotherboards = await dbContext.Motherboards
                .Where(p => p.ProviderId.ToString().ToLower() == providerId.ToLower())
                .Select(m => new MotherboardAllViewModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    Price = m.Price,
                    ImageUrl = m.ImageUrl
                })
                .ToArrayAsync();

            return allProviderMotherboards;
        }

        public async Task<IEnumerable<PsuAllViewModel>> AllPsusByProviderIdAsync(string providerId)
        {
            IEnumerable<PsuAllViewModel> allProviderPsus = await dbContext.Psus
                .Where(p => p.ProviderId.ToString().ToLower() == providerId.ToLower())
                .Select(psu => new PsuAllViewModel
                {
                    Id = psu.Id,
                    Name = psu.Name,
                    Price = psu.Price,
                    ImageUrl = psu.ImageUrl
                })
                .ToArrayAsync();

            return allProviderPsus;
        }

        public async Task<IEnumerable<RamAllViewModel>> AllRamsByProviderIdAsync(string providerId)
        {
            IEnumerable<RamAllViewModel> allProviderRams = await dbContext.Rams
                .Where(p => p.ProviderId.ToString().ToLower() == providerId.ToLower())
                .Select(r => new RamAllViewModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    Price = r.Price,
                    ImageUrl = r.ImageUrl
                })
                .ToArrayAsync();

            return allProviderRams;
        }

        public async Task<IEnumerable<StorageAllViewModel>> AllStoragesByProviderIdAsync(string providerId)
        {
            IEnumerable<StorageAllViewModel> allProviderStorages = await dbContext.Storages
                .Where(p => p.ProviderId.ToString().ToLower() == providerId.ToLower())
                .Select(r => new StorageAllViewModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    Price = r.Price,
                    ImageUrl = r.ImageUrl
                })
                .ToListAsync();

            return allProviderStorages;
        }
    }
}
