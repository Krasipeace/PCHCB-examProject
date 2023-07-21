namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Data;
    using PCHCB.Web.ViewModels.Case;

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

        public async Task DeleteCaseByIdAsync(int caseId)
        {
            Case @case = await this.dbContext.Cases
                .FirstAsync(c => c.Id == caseId);

            @case.Name = ComponentUnavailable;
            this.dbContext.Cases.Remove(@case);

            await this.dbContext.SaveChangesAsync();
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

        public Task<CaseFormModel> GetCaseDetailsAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsCaseExistByIdAsync(int caseId)
        {
            bool result = await this.dbContext
                .Cases
                .AnyAsync(c => c.Id == caseId);

            return result;
        }

        public async Task<bool> IsProviderIdOwnerOfCaseIdAsync(string providerId, int caseId)
        {
            Case @case = await this.dbContext
                .Cases
                .FirstAsync(c => c.Id == caseId);

            return @case.ProviderId.ToString() == providerId;
        }
    }
}
