namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Data;
    using PCHCB.Web.ViewModels.Case;
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Provider;

    using static PCHCB.Common.GeneralAppConstants;

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
                    ImageUrl = c.ImageUrl
                })
                .ToListAsync();
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
