namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Data;
    using PCHCB.Web.ViewModels.Cooler;
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Provider;

    using static PCHCB.Common.GeneralAppConstants;

    public class CoolerService : ICoolerService
    {
        private readonly PCHCBDbContext dbContext;

        public CoolerService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> CreateCoolerAsync(string providerId, CoolerFormModel model)
        {
            Cooler cooler = new Cooler()
            {
                Name = model.Name,
                Price = model.Price,
                Type = (CoolerType)model.Type,
                Compatibility = model.Compatibility,
                RadiatorSize = (RadiatorSize)model.RadiatorSize,
                FanSize = model.FanSize,
                CoolerHeight = model.CoolerHeight,
                Tdp = model.Tdp,
                Width = model.Width,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse(providerId)
            };

            await this.dbContext.Coolers.AddAsync(cooler);
            await this.dbContext.SaveChangesAsync();

            return cooler.Id;
        }

        public async Task<CoolerFormModel> GetCoolerForEditByIdAsync(int coolerId)
        {
            Cooler cooler = await this.dbContext.Coolers
                .FirstAsync(c => c.Id == coolerId);

            return new CoolerFormModel()
            {
                Name = cooler.Name,
                Price = cooler.Price,
                Type = (int)cooler.Type,
                Compatibility = cooler.Compatibility,
                RadiatorSize = (int)cooler.RadiatorSize,
                FanSize = cooler.FanSize,
                CoolerHeight = cooler.CoolerHeight,
                Tdp = cooler.Tdp,
                Width = cooler.Width,
                ImageUrl = cooler.ImageUrl,
                Description = cooler.Description,
            };
        }

        public async Task EditCoolerByIdAndFormModelAsync(int coolerId, CoolerFormModel model)
        {
            Cooler cooler = await this.dbContext.Coolers
                .FirstAsync(c => c.Id == coolerId);

            cooler.Name = model.Name;
            cooler.Price = model.Price;
            cooler.Type = (CoolerType)model.Type;
            cooler.Compatibility = model.Compatibility;
            cooler.RadiatorSize = (RadiatorSize)model.RadiatorSize;
            cooler.FanSize = model.FanSize;
            cooler.CoolerHeight = model.CoolerHeight;
            cooler.Tdp = model.Tdp;
            cooler.Width = model.Width;
            cooler.ImageUrl = model.ImageUrl;
            cooler.Description = model.Description;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsCoolerExistByIdAsync(int coolerId)
        {
            bool result = await this.dbContext.Coolers
                .AnyAsync(c => c.Id == coolerId);

            return result;
        }

        public async Task<bool> IsProviderIdOwnerOfCoolerIdAsync(string providerId, int coolerId)
        {
            Provider? provider = await this.dbContext.Providers
                .Include(p => p.ProviderCoolers)
                .FirstOrDefaultAsync(p => p.Id.ToString().ToLower() == providerId.ToLower());

            if (provider == null)
            {
                return false;
            }

            return provider.ProviderCoolers.Any(pc => pc.Id == coolerId);
        }

        public async Task<DeleteDetailsViewModel> GetCoolerForDeleteByIdAsync(int coolerId)
        {
            Cooler cooler = await dbContext.Coolers
                .FirstAsync(c => c.Id == coolerId);

            return new DeleteDetailsViewModel
            {
                Name = cooler.Name,
                Description = cooler.Description,
                ImageUrl = cooler.ImageUrl
            };
        }

        public async Task DeleteCoolerByIdAsync(int coolerId)
        {
            Cooler cooler = await this.dbContext.Coolers
                .FirstAsync(c => c.Id == coolerId);

            cooler.Name = ComponentUnavailable;
            this.dbContext.Coolers.Remove(cooler);

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<AllViewModel>> GetAllCoolersAsync()
        {
            return await this.dbContext.Coolers
                .Select(c => new AllViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Price = c.Price,
                    ImageUrl = c.ImageUrl
                })
                .ToListAsync();
        }

        public async Task<CoolerDetailsViewModel> GetCoolerDetailsAsync(int coolerId)
        {
            Cooler cooler = await dbContext.Coolers
                .Include(c => c.Provider)
                .ThenInclude(u => u.User)
                .Where(c => c.Name != ComponentUnavailable)
                .FirstAsync(c => c.Id == coolerId);

            return new CoolerDetailsViewModel
            {
                Id = cooler.Id,
                Name = cooler.Name,
                Price = cooler.Price,
                Type = (int)cooler.Type,
                FanSize = cooler.FanSize,
                RadiatorSize = (int)cooler.RadiatorSize,
                CoolerHeight = cooler.CoolerHeight,
                Tdp = cooler.Tdp,
                Width = cooler.Width,
                ImageUrl = cooler.ImageUrl,
                Description = cooler.Description,
                Provider = new ProviderInfoViewModel()
                {
                    Id = cooler.Provider.Id,
                    WebPage = cooler.Provider.WebPage,
                    ProviderDetails = new ProviderDetailsViewModel()
                    {
                        PhoneNumber = cooler.Provider.User.PhoneNumber,
                        LogoUrl = cooler.Provider.LogoUrl,
                        WebPage = cooler.Provider.WebPage,
                    }
                }
            };
        }
    }
}
