namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Data;
    using PCHCB.Web.ViewModels.Cooler;
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.ViewModels.Enums;

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
            Cooler cooler = new ()
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
            Cooler cooler = await this.dbContext.Coolers.FirstAsync(c => c.Id == coolerId);

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
            Cooler cooler = await this.dbContext.Coolers.FirstAsync(c => c.Id == coolerId);

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

            this.dbContext.Coolers.Update(cooler);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsCoolerExistByIdAsync(int coolerId)
        {
            bool result = await this.dbContext.Coolers.AnyAsync(c => c.Id == coolerId);

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
            Cooler cooler = await dbContext.Coolers.FirstAsync(c => c.Id == coolerId);

            return new DeleteDetailsViewModel
            {
                Name = cooler.Name,
                Description = cooler.Description,
                ImageUrl = cooler.ImageUrl
            };
        }

        public async Task DeleteCoolerByIdAsync(int coolerId)
        {
            Cooler cooler = await this.dbContext.Coolers.FirstAsync(c => c.Id == coolerId);

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
                    Description = c.Description,
                    ImageUrl = c.ImageUrl
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<CoolerDetailsViewModel>> GetAllCoolersDetailsAsync()
        {
            return await this.dbContext.Coolers
                .Select(c => new CoolerDetailsViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Price = c.Price,
                    Type = (int)c.Type,
                    Compatibility = c.Compatibility,
                    RadiatorSize = (int)c.RadiatorSize,
                    FanSize = c.FanSize,
                    CoolerHeight = c.CoolerHeight,
                    Tdp = c.Tdp,
                    Width = c.Width,
                    ImageUrl = c.ImageUrl,
                    Description = c.Description,
                })
                .ToListAsync();
        }

        public async Task<SearchResult> SearchCoolersAsync(AllQueryModel queryModel)
        {
            IQueryable<Cooler> coolerQuery = dbContext.Coolers.AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.SearchTerm))
            {
                string wildCard = $"%{queryModel.SearchTerm.ToLower()}%";

                coolerQuery = coolerQuery
                    .Where(c => EF.Functions.Like(c.Name, wildCard) ||
                                EF.Functions.Like(c.Description, wildCard));
            }

            coolerQuery = queryModel.Sorting switch
            {
                GeneralSorting.Newest => coolerQuery.OrderByDescending(c => c.AddedOn),
                GeneralSorting.Oldest => coolerQuery.OrderBy(c => c.AddedOn),
                GeneralSorting.PriceAscending => coolerQuery.OrderBy(c => c.Price),
                GeneralSorting.PriceDescending => coolerQuery.OrderByDescending(c => c.Price),
                _ => coolerQuery.OrderByDescending(c => c.Id)
            };

            IEnumerable<AllViewModel> allCoolers = await coolerQuery
                .Where(c => c.Name != ComponentUnavailable)
                .Skip((queryModel.CurrentPage - 1) * queryModel.ComponentsPerPage)
                .Take(queryModel.ComponentsPerPage)
                .Select(c => new AllViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.ImageUrl,
                    Price = c.Price,
                    Description = c.Description
                })
                .ToArrayAsync();
            int totalCoolers = coolerQuery.Count();

            return new SearchResult()
            {
                TotalComponents = totalCoolers,
                Coolers = allCoolers
            };
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
