namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Data;
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.ViewModels.Psu;
    using PCHCB.Web.ViewModels.Enums;

    using static PCHCB.Common.GeneralAppConstants;

    public class PsuService : IPsuService
    {
        private readonly PCHCBDbContext dbContext;

        public PsuService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> CreatePsuAsync(string providerId, PsuFormModel model)
        {
            Psu psu = new Psu()
            {
                Name = model.Name,
                Price = model.Price,
                Wattage = model.Wattage,
                Factor = (PsuFactor)model.Factor,
                NvidiaConnector = model.NvidiaConnector,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse(providerId),
            };

            await this.dbContext.Psus.AddAsync(psu);
            await this.dbContext.SaveChangesAsync();

            return psu.Id;
        }

        public async Task<PsuFormModel> GetPsuForEditByIdAsync(int psuId)
        {
            Psu psu = await this.dbContext.Psus
                .FirstAsync(p => p.Id == psuId);

            return new PsuFormModel
            {
                Name = psu.Name,
                Price = psu.Price,
                Wattage = psu.Wattage,
                Factor = (int)psu.Factor,
                NvidiaConnector = psu.NvidiaConnector,
                ImageUrl = psu.ImageUrl,
                Description = psu.Description
            };
        }

        public async Task EditPsuByIdAndFormModelAsync(int psuId, PsuFormModel model)
        {
            Psu psu = await this.dbContext.Psus
                .FirstAsync(p => p.Id == psuId);

            psu.Name = model.Name;
            psu.Price = model.Price;
            psu.Wattage = model.Wattage;
            psu.Factor = (PsuFactor)model.Factor;
            psu.NvidiaConnector = model.NvidiaConnector;
            psu.ImageUrl = model.ImageUrl;
            psu.Description = model.Description;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsProviderIdOwnerOfPsuIdAsync(string providerId, int psuId)
        {
            Provider? provider = await this.dbContext.Providers
                .Include(p => p.ProviderPsus)
                .FirstOrDefaultAsync(p => p.Id.ToString().ToLower() == providerId.ToLower());

            if (provider == null)
            {
                return false;
            }

            return provider.ProviderPsus.Any(pc => pc.Id == psuId);
        }

        public async Task<bool> IsPsuExistByIdAsync(int psuId)
        {
            bool result = await this.dbContext.Psus
                .AnyAsync(p => p.Id == psuId);

            return result;
        }

        public async Task<DeleteDetailsViewModel> GetPsuForDeleteByIdAsync(int psuId)
        {
            Psu psu = await dbContext.Psus
                .FirstAsync(p => p.Id == psuId);

            return new DeleteDetailsViewModel
            {
                Name = psu.Name,
                Description = psu.Description,
                ImageUrl = psu.ImageUrl
            };
        }

        public async Task DeletePsuByIdAsync(int psuId)
        {
            Psu psu = await this.dbContext.Psus
                .FirstAsync(p => p.Id == psuId);

            psu.Name = ComponentUnavailable;
            this.dbContext.Psus.Remove(psu);

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<AllViewModel>> GetAllPsusAsync()
        {
            return await this.dbContext.Psus
                .Where(p => p.Name != ComponentUnavailable)
                .Select(p => new AllViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<PsuDetailsViewModel>> GetAllPsusDetailsAsync()
        {
            return await this.dbContext.Psus
                .Where(p => p.Name != ComponentUnavailable)
                .Select(p => new PsuDetailsViewModel
                {
                    Name = p.Name,
                    Price = p.Price,
                    Wattage = p.Wattage,
                    Factor = (int)p.Factor,
                    NvidiaConnector = p.NvidiaConnector,
                    ImageUrl = p.ImageUrl,
                    Description = p.Description
                })
                .ToListAsync();
        }

        public async Task<SearchResult> SearchPsusAsync(AllQueryModel queryModel)
        {
            IQueryable<Psu> psuQuery = dbContext.Psus
                 .AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.SearchTerm))
            {
                string wildCard = $"%{queryModel.SearchTerm.ToLower()}%";

                psuQuery = psuQuery
                    .Where(p => EF.Functions.Like(p.Name, wildCard) ||
                                EF.Functions.Like(p.Description, wildCard));
            }

            psuQuery = queryModel.Sorting switch
            {
                GeneralSorting.Newest => psuQuery
                    .OrderByDescending(p => p.AddedOn),
                GeneralSorting.Oldest => psuQuery
                    .OrderBy(p => p.AddedOn),
                GeneralSorting.PriceAscending => psuQuery
                    .OrderBy(p => p.Price),
                GeneralSorting.PriceDescending => psuQuery
                    .OrderByDescending(p => p.Price),
                _ => psuQuery
                    .OrderByDescending(p => p.Id)
            };

            IEnumerable<AllViewModel> allPsus = await psuQuery
                .Where(p => p.Name != ComponentUnavailable)
                .Skip((queryModel.CurrentPage - 1) * queryModel.ComponentsPerPage)
                .Take(queryModel.ComponentsPerPage)
                .Select(p => new AllViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price,
                    Description = p.Description
                })
                .ToArrayAsync();
            int totalPsus = psuQuery.Count();

            return new SearchResult()
            {
                TotalComponents = totalPsus,
                Psus = allPsus
            };
        }

        public async Task<PsuDetailsViewModel> GetPsuDetailsAsync(int psuId)
        {
            Psu psu = await dbContext.Psus
                .Include(p => p.Provider)
                .ThenInclude(u => u.User)
                .Where(p => p.Name != ComponentUnavailable)
                .FirstAsync(p => p.Id == psuId);

            return new PsuDetailsViewModel
            {
                Id = psu.Id,
                Name = psu.Name,
                Price = psu.Price,
                Wattage = psu.Wattage,
                Factor = (int)psu.Factor,
                NvidiaConnector = psu.NvidiaConnector,
                ImageUrl = psu.ImageUrl,
                Description = psu.Description,
                Provider = new ProviderInfoViewModel()
                {
                    Id = psu.Provider.Id,
                    WebPage = psu.Provider.WebPage,
                    ProviderDetails = new ProviderDetailsViewModel()
                    {
                        PhoneNumber = psu.Provider.User.PhoneNumber,
                        LogoUrl = psu.Provider.LogoUrl,
                        WebPage = psu.Provider.WebPage,
                    }
                }
            };
        }
    }
}
