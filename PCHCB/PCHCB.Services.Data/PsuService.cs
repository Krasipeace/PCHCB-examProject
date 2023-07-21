namespace PCHCB.Services.Data
{
    using System;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Data;
    using PCHCB.Web.ViewModels.Psu;

    public class PsuService : IPsuService
    {
        private readonly PCHCBDbContext dbContext;

        public PsuService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task CreatePsu(string providerId, PsuFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeletePsuByIdAsync(int psuId)
        {
            throw new NotImplementedException();
        }

        public Task EditPsuByIdAndFormModelAsync(int psuId, PsuFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsProviderIdOwnerOfPsuIdAsync(string providerId, int psuId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsPsuExistByIdAsync(int psuId)
        {
            throw new NotImplementedException();
        }
    }
}
