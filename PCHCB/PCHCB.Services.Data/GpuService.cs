namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Data;
    using PCHCB.Web.ViewModels.Gpu;
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.ViewModels.Enums;

    using static PCHCB.Common.GeneralAppConstants;

    public class GpuService : IGpuService
    {
        private readonly PCHCBDbContext dbContext;

        public GpuService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> CreateGpuAsync(string providerId, GpuFormModel model)
        {
            Gpu gpu = new ()
            {
                Name = model.Name,
                Price = model.Price,
                Memory = model.Memory,
                Interface = (InterfaceType)model.Interface,
                Length = model.Length,
                SlotsRequired = model.SlotsRequired,
                PowerConsumption = model.PowerConsumption,
                NvidiaConnector = model.NvidiaConnector,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse(providerId),
            };

            await this.dbContext.Gpus.AddAsync(gpu);
            await this.dbContext.SaveChangesAsync();

            return gpu.Id;
        }

        public async Task<GpuFormModel> GetGpuForEditByIdAsync(int gpuId)
        {
            Gpu gpu = await this.dbContext.Gpus
                .FirstAsync(g => g.Id == gpuId);

            return new GpuFormModel()
            {
                Name = gpu.Name,
                Price = gpu.Price,
                Memory = gpu.Memory,
                Interface = (int)gpu.Interface,
                Length = gpu.Length,
                SlotsRequired = gpu.SlotsRequired,
                PowerConsumption = gpu.PowerConsumption,
                NvidiaConnector = gpu.NvidiaConnector,
                ImageUrl = gpu.ImageUrl,
                Description = gpu.Description,
            };
        }

        public async Task EditGpuByIdAndFormModelAsync(int gpuId, GpuFormModel model)
        {
            Gpu gpu = await this.dbContext.Gpus
                .FirstAsync(g => g.Id == gpuId);

            gpu.Name = model.Name;
            gpu.Price = model.Price;
            gpu.Memory = model.Memory;
            gpu.Interface = (InterfaceType)model.Interface;
            gpu.Length = model.Length;
            gpu.SlotsRequired = model.SlotsRequired;
            gpu.PowerConsumption = model.PowerConsumption;
            gpu.NvidiaConnector = model.NvidiaConnector;
            gpu.ImageUrl = model.ImageUrl;
            gpu.Description = model.Description;

            this.dbContext.Gpus.Update(gpu);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<DeleteDetailsViewModel> GetGpuForDeleteByIdAsync(int gpuId)
        {
            Gpu gpu = await dbContext.Gpus
                .FirstAsync(g => g.Id == gpuId);

            return new DeleteDetailsViewModel
            {
                Name = gpu.Name,
                Description = gpu.Description,
                ImageUrl = gpu.ImageUrl
            };
        }

        public async Task DeleteGpuByIdAsync(int gpuId)
        {
            Gpu gpu = await this.dbContext.Gpus
                .FirstAsync(g => g.Id == gpuId);

            gpu.Name = ComponentUnavailable;
            this.dbContext.Gpus.Remove(gpu);

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsGpuExistByIdAsync(int gpuId)
        {
            bool result = await this.dbContext.Gpus
                .AnyAsync(g => g.Id == gpuId);

            return result;
        }

        public async Task<bool> IsProviderIdOwnerOfGpuIdAsync(string providerId, int gpuId)
        {
            Provider? provider = await this.dbContext.Providers
                .Include(p => p.ProviderGpus)
                .FirstOrDefaultAsync(p => p.Id.ToString().ToLower() == providerId.ToLower());

            if (provider == null)
            {
                return false;
            }

            return provider.ProviderGpus.Any(pg => pg.Id == gpuId);
        }

        public async Task<IEnumerable<AllViewModel>> GetAllGpusAsync()
        {
            return await this.dbContext.Gpus
                .Where(g => g.Name != ComponentUnavailable)
                .Select(g => new AllViewModel()
                {
                    Id = g.Id,
                    Name = g.Name,
                    Price = g.Price,
                    ImageUrl = g.ImageUrl,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<GpuDetailsViewModel>> GetAllGpusDetailsAsync()
        {
            return await this.dbContext.Gpus
                .Where(g => g.Name != ComponentUnavailable)
                .Select(g => new GpuDetailsViewModel()
                {
                    Id = g.Id,
                    Name = g.Name,
                    Price = g.Price,
                    ImageUrl = g.ImageUrl,
                    Description = g.Description,
                    Memory = g.Memory,
                    Interface = (int)g.Interface,
                    Length = g.Length,
                    SlotsRequired = g.SlotsRequired,
                    PowerConsumption = g.PowerConsumption,
                    NvidiaConnector = g.NvidiaConnector,
                })
                .ToListAsync();
        }

        public async Task<SearchResult> SearchGpusAsync(AllQueryModel queryModel)
        {
            IQueryable<Gpu> gpuQuery = dbContext.Gpus
                 .AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.SearchTerm))
            {
                string wildCard = $"%{queryModel.SearchTerm.ToLower()}%";

                gpuQuery = gpuQuery
                    .Where(g => EF.Functions.Like(g.Name, wildCard) ||
                                EF.Functions.Like(g.Description, wildCard));
            }

            gpuQuery = queryModel.Sorting switch
            {
                GeneralSorting.Newest => gpuQuery
                    .OrderByDescending(g => g.AddedOn),
                GeneralSorting.Oldest => gpuQuery
                    .OrderBy(g => g.AddedOn),
                GeneralSorting.PriceAscending => gpuQuery
                    .OrderBy(g => g.Price),
                GeneralSorting.PriceDescending => gpuQuery
                    .OrderByDescending(g => g.Price),
                _ => gpuQuery
                    .OrderByDescending(g => g.Id)
            };

            IEnumerable<AllViewModel> allGpus = await gpuQuery
                .Where(g => g.Name != ComponentUnavailable)
                .Skip((queryModel.CurrentPage - 1) * queryModel.ComponentsPerPage)
                .Take(queryModel.ComponentsPerPage)
                .Select(g => new AllViewModel
                {
                    Id = g.Id,
                    Name = g.Name,
                    ImageUrl = g.ImageUrl,
                    Price = g.Price,
                    Description = g.Description
                })
                .ToArrayAsync();
            int totalGpus = gpuQuery.Count();

            return new SearchResult()
            {
                TotalComponents = totalGpus,
                Gpus = allGpus
            };
        }

        public async Task<GpuDetailsViewModel> GetGpuDetailsAsync(int gpuId)
        {
            Gpu gpu = await dbContext.Gpus
                .Include(g => g.Provider)
                .ThenInclude(u => u.User)
                .Where(g => g.Name != ComponentUnavailable)
                .FirstAsync(g => g.Id == gpuId);

            return new GpuDetailsViewModel
            {
                Id = gpu.Id,
                Name = gpu.Name,
                Price = gpu.Price,
                Memory = gpu.Memory,
                Interface = (int)gpu.Interface,
                Length = gpu.Length,
                SlotsRequired = gpu.SlotsRequired,
                PowerConsumption = gpu.PowerConsumption,
                NvidiaConnector = gpu.NvidiaConnector,
                ImageUrl = gpu.ImageUrl,
                Description = gpu.Description,
                Provider = new ProviderInfoViewModel()
                {
                    Id = gpu.Provider.Id,
                    WebPage = gpu.Provider.WebPage,
                    ProviderDetails = new ProviderDetailsViewModel()
                    {
                        PhoneNumber = gpu.Provider.User.PhoneNumber,
                        LogoUrl = gpu.Provider.LogoUrl,
                        WebPage = gpu.Provider.WebPage,
                    }
                }
            };
        }
    }
}
