namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Data;
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.ViewModels.Ram;
    using PCHCB.Web.ViewModels.Enums;

    using static PCHCB.Common.GeneralAppConstants;

    public class RamService : IRamService
    {
        private readonly PCHCBDbContext dbContext;

        public RamService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> CreateRamAsync(string providerId, RamFormModel model)
        {
            Ram ram = new Ram()
            {
                Name = model.Name,
                Price = model.Price,
                Type = (RamType)model.Type,
                Frequency = model.Frequency,
                Capacity = model.Capacity,
                Height = model.Height,
                ModelNumber = model.ModelNumber,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse(providerId),
            };

            await this.dbContext.Rams.AddAsync(ram);
            await this.dbContext.SaveChangesAsync();

            return ram.Id;
        }

        public async Task<RamFormModel> GetRamForEditByIdAsync(int ramId)
        {
            Ram ram = await this.dbContext.Rams
                .FirstAsync(r => r.Id == ramId);

            return new RamFormModel()
            {
                Name = ram.Name,
                Price = ram.Price,
                Type = (int)ram.Type,
                Frequency = ram.Frequency,
                Capacity = ram.Capacity,
                Height = ram.Height,
                ModelNumber = ram.ModelNumber,
                ImageUrl = ram.ImageUrl,
                Description = ram.Description,
            };
        }

        public async Task EditRamByIdAndFormModelAsync(int ramId, RamFormModel model)
        {
            Ram ram = await this.dbContext.Rams
                .FirstAsync(r => r.Id == ramId);

            ram.Name = model.Name;
            ram.Price = model.Price;
            ram.Type = (RamType)model.Type;
            ram.Frequency = model.Frequency;
            ram.Capacity = model.Capacity;
            ram.Height = model.Height;
            ram.ModelNumber = model.ModelNumber;
            ram.ImageUrl = model.ImageUrl;
            ram.Description = model.Description;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsProviderIdOwnerOfRamIdAsync(string providerId, int ramId)
        {
            Provider? provider = await this.dbContext.Providers
                .Include(p => p.ProviderRams)
                .FirstOrDefaultAsync(p => p.Id.ToString().ToLower() == providerId.ToLower());

            if (provider == null)
            {
                return false;
            }

            return provider.ProviderRams.Any(pc => pc.Id == ramId);
        }

        public async Task<bool> IsRamExistByIdAsync(int ramId)
        {
            bool result = await this.dbContext.Rams
                .AnyAsync(r => r.Id == ramId);

            return result;
        }

        public async Task<DeleteDetailsViewModel> GetRamForDeleteByIdAsync(int ramId)
        {
            Ram ram = await dbContext.Rams
                .FirstAsync(r => r.Id == ramId);

            return new DeleteDetailsViewModel
            {
                Name = ram.Name,
                Description = ram.Description,
                ImageUrl = ram.ImageUrl
            };
        }

        public async Task DeleteRamByIdAsync(int ramId)
        {
            Ram ram = await this.dbContext.Rams
                .FirstAsync(r => r.Id == ramId);

            ram.Name = ComponentUnavailable;
            this.dbContext.Rams.Remove(ram);

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<AllViewModel>> GetAllRamsAsync()
        {
            return await this.dbContext.Rams
                .Where(r => r.Name != ComponentUnavailable)
                .Select(r => new AllViewModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    Price = r.Price,
                    ImageUrl = r.ImageUrl
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<RamDetailsViewModel>> GetAllRamsDetailsAsync()
        {
            return await this.dbContext.Rams
                .Where(r => r.Name != ComponentUnavailable)
                .Select(r => new RamDetailsViewModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    Price = r.Price,
                    ImageUrl = r.ImageUrl,
                    Description = r.Description,
                    Type = (int)r.Type,
                    Frequency = r.Frequency,
                    Capacity = r.Capacity,
                    Height = r.Height,
                    ModelNumber = r.ModelNumber,
                })
                .ToListAsync();           
        }

        public async Task<SearchResult> SearchRamsAsync(AllQueryModel queryModel)
        {
            IQueryable<Ram> ramQuery = dbContext.Rams
                 .AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.SearchTerm))
            {
                string wildCard = $"%{queryModel.SearchTerm.ToLower()}%";

                ramQuery = ramQuery
                    .Where(r => EF.Functions.Like(r.Name, wildCard) ||
                                EF.Functions.Like(r.Description, wildCard));
            }

            ramQuery = queryModel.Sorting switch
            {
                GeneralSorting.Newest => ramQuery
                    .OrderByDescending(r => r.AddedOn),
                GeneralSorting.Oldest => ramQuery
                    .OrderBy(r => r.AddedOn),
                GeneralSorting.PriceAscending => ramQuery
                    .OrderBy(r => r.Price),
                GeneralSorting.PriceDescending => ramQuery
                    .OrderByDescending(r => r.Price),
                _ => ramQuery
                    .OrderByDescending(r => r.Id)
            };

            IEnumerable<AllViewModel> allRams = await ramQuery
                .Where(r => r.Name != ComponentUnavailable)
                .Skip((queryModel.CurrentPage - 1) * queryModel.ComponentsPerPage)
                .Take(queryModel.ComponentsPerPage)
                .Select(r => new AllViewModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    ImageUrl = r.ImageUrl,
                    Price = r.Price,
                    Description = r.Description
                })
                .ToArrayAsync();
            int totalRams = ramQuery.Count();

            return new SearchResult()
            {
                TotalComponents = totalRams,
                Rams = allRams
            };
        }

        public async Task<RamDetailsViewModel> GetRamDetailsAsync(int ramId)
        {
            Ram ram = await dbContext.Rams
                .Include(r => r.Provider)
                .ThenInclude(u => u.User)
                .Where(r => r.Name != ComponentUnavailable)
                .FirstAsync(r => r.Id == ramId);

            return new RamDetailsViewModel
            {
                Id = ram.Id,
                Name = ram.Name,
                Price = ram.Price,
                Type = (int)ram.Type,
                Frequency = ram.Frequency,
                Capacity = ram.Capacity,
                Height = ram.Height,
                ModelNumber = ram.ModelNumber,
                ImageUrl = ram.ImageUrl,
                Description = ram.Description,
                Provider = new ProviderInfoViewModel()
                {
                    Id = ram.Provider.Id,
                    WebPage = ram.Provider.WebPage,
                    ProviderDetails = new ProviderDetailsViewModel()
                    {
                        PhoneNumber = ram.Provider.User.PhoneNumber,
                        LogoUrl = ram.Provider.LogoUrl,
                        WebPage = ram.Provider.WebPage,
                    }
                }
            };
        }
    }
}
