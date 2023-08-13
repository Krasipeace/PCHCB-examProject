namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Data;
    using PCHCB.Web.ViewModels.Case;
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.ViewModels.Enums;

    using static PCHCB.Common.GeneralAppConstants;
    using PCHCB.Web.ViewModels.Cpu;

    public class CaseService : ICaseService
    {
        private readonly PCHCBDbContext dbContext;

        public CaseService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> CreateCaseAsync(string providerId, CaseFormModel model)
        {
            Case newCase = new Case
            {
                Name = model.Name,
                Price = model.Price,
                CaseSize = (CaseSize)model.CaseSize,
                FormFactor = (MbFormFactor)model.FormFactor,
                MaxGpuLength = model.MaxGpuLength,
                MaxAirCpuCoolerHeight = (int)model.MaxAirCpuCoolerHeight,
                PsuFactor = (PsuFactor)model.PsuFactor,
                ImageUrl = model.ImageUrl,
                MaxRadiatorLength = model.MaxRadiatorLength,
                Description = model.Description,
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse(providerId),
            };

            await this.dbContext.Cases.AddAsync(newCase);
            await this.dbContext.SaveChangesAsync();

            return newCase.Id;
        }

        public async Task<CaseFormModel> GetCaseForEditByIdAsync(int caseId)
        {
            Case @case = await this.dbContext.Cases
                .FirstAsync(c => c.Id == caseId);

            return new CaseFormModel()
            {
                Name = @case.Name,
                Price = @case.Price,
                CaseSize = (int)@case.CaseSize,
                FormFactor = (int)@case.FormFactor,
                MaxGpuLength = @case.MaxGpuLength,
                MaxAirCpuCoolerHeight = (int)@case.MaxAirCpuCoolerHeight,
                PsuFactor = (int)@case.PsuFactor,
                ImageUrl = @case.ImageUrl,
                MaxRadiatorLength = @case.MaxRadiatorLength,
                Description = @case.Description
            };
        }

        public async Task EditCaseByIdAndFormModelAsync(int caseId, CaseFormModel formModel)
        {
            Case @case = await this.dbContext.Cases
                .FirstAsync(c => c.Id == caseId);

            @case.Name = formModel.Name;
            @case.Price = formModel.Price;
            @case.CaseSize = (CaseSize)formModel.CaseSize;
            @case.FormFactor = (MbFormFactor)formModel.FormFactor;
            @case.MaxGpuLength = formModel.MaxGpuLength;
            @case.MaxAirCpuCoolerHeight = (int)formModel.MaxAirCpuCoolerHeight;
            @case.PsuFactor = (PsuFactor)formModel.PsuFactor;
            @case.ImageUrl = formModel.ImageUrl;
            @case.MaxRadiatorLength = formModel.MaxRadiatorLength;
            @case.Description = formModel.Description;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsCaseExistByIdAsync(int caseId)
        {
            bool result = await this.dbContext.Cases
                .AnyAsync(c => c.Id == caseId);

            return result;
        }

        public async Task<bool> IsProviderIdOwnerOfCaseIdAsync(string providerId, int caseId)
        {
            Provider? provider = await this.dbContext.Providers
                .Include(p => p.ProviderCases)
                .FirstOrDefaultAsync(p => p.Id.ToString().ToLower() == providerId.ToLower());

            if (provider == null)
            {
                return false;
            }

            return provider.ProviderCases.Any(pc => pc.Id == caseId);
        }

        public async Task<DeleteDetailsViewModel> GetCaseForDeleteByIdAsync(int caseId)
        {
            Case @case = await dbContext.Cases
                .FirstAsync(c => c.Id == caseId);

            return new DeleteDetailsViewModel
            {
                Name = @case.Name,
                Description = @case.Description,
                ImageUrl = @case.ImageUrl
            };
        }

        public async Task DeleteCaseByIdAsync(int caseId)
        {
            Case @case = await this.dbContext.Cases
                .FirstAsync(c => c.Id == caseId);

            @case.Name = ComponentUnavailable;
            this.dbContext.Cases.Remove(@case);

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<AllViewModel>> GetAllCasesAsync()
        {
            return await this.dbContext.Cases
                .Where(c => c.Name != ComponentUnavailable)
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

        public async Task<IEnumerable<CaseDetailsViewModel>> GetAllCasesDetailsAsync()
        {
            return await this.dbContext.Cases
                .Where(c => c.Name != ComponentUnavailable)
                .Select(c => new CaseDetailsViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Price = c.Price,
                    CaseSize = (int)c.CaseSize,
                    FormFactor = (int)c.FormFactor,
                    MaxGpuLength = c.MaxGpuLength,
                    MaxAirCpuCoolerHeight = c.MaxAirCpuCoolerHeight,
                    PsuFactor = (int)c.PsuFactor,
                    ImageUrl = c.ImageUrl,
                    MaxRadiatorLength = c.MaxRadiatorLength,
                    Description = c.Description
                })
                .ToListAsync();
        }

        public async Task<SearchResult> SearchCasesAsync(AllQueryModel queryModel)
        {
            IQueryable<Case> casesQuery = dbContext.Cases
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.SearchTerm))
            {
                string wildCard = $"%{queryModel.SearchTerm.ToLower()}%";

                casesQuery = casesQuery
                    .Where(c => EF.Functions.Like(c.Name, wildCard) ||
                                EF.Functions.Like(c.Description, wildCard));
            }

            casesQuery = queryModel.Sorting switch
            {
                GeneralSorting.Newest => casesQuery
                    .OrderByDescending(c => c.AddedOn),
                GeneralSorting.Oldest => casesQuery
                    .OrderBy(c => c.AddedOn),
                GeneralSorting.PriceAscending => casesQuery
                    .OrderBy(c => c.Price),
                GeneralSorting.PriceDescending => casesQuery
                    .OrderByDescending(c => c.Price),
                _ => casesQuery
                    .OrderByDescending(c => c.Id)
            };

            IEnumerable<AllViewModel> allCases = await casesQuery
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
            int totalCases = casesQuery.Count();

            return new SearchResult()
            {
                TotalComponents = totalCases,
                Cases = allCases
            };
        }

        public async Task<CaseDetailsViewModel> GetCaseDetailsAsync(int caseId)
        {
            Case @case = await dbContext.Cases
                .Include(c => c.Provider)
                .ThenInclude(u => u.User)
                .Where(c => c.Name != ComponentUnavailable)
                .FirstAsync(c => c.Id == caseId);

            return new CaseDetailsViewModel
            {
                Id = @case.Id,
                Name = @case.Name,
                Price = @case.Price,
                CaseSize = (int)@case.CaseSize,
                FormFactor = (int)@case.FormFactor,
                MaxGpuLength = @case.MaxGpuLength,
                MaxAirCpuCoolerHeight = @case.MaxAirCpuCoolerHeight,
                PsuFactor = (int)@case.PsuFactor,
                ImageUrl = @case.ImageUrl,
                MaxRadiatorLength = @case.MaxRadiatorLength,
                Description = @case.Description,
                Provider = new ProviderInfoViewModel()
                {
                    Id = @case.Provider.Id,
                    WebPage = @case.Provider.WebPage,
                    ProviderDetails = new ProviderDetailsViewModel()
                    {
                        PhoneNumber = @case.Provider.User.PhoneNumber,
                        LogoUrl = @case.Provider.LogoUrl,
                        WebPage = @case.Provider.WebPage,
                    }
                }
            };
        }
    }
}
