namespace PCHCB.Services.Data
{
    using System;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Data;
    using PCHCB.Web.ViewModels.Cooler;

    public class CoolerService : ICoolerService
    {
        private readonly PCHCBDbContext dbContext;

        public CoolerService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task CreateCooler(string providerId, CoolerFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCoolerByIdAsync(int coolerId)
        {
            throw new NotImplementedException();
        }

        public Task EditCoolerByIdAndFormModelAsync(int coolerId, CoolerFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CoolerFormModel> GetCoolerForEditByIdAsync(int coolerId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsCoolerExistByIdAsync(int coolerId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsProviderIdOwnerOfCoolerIdAsync(string providerId, int coolerId)
        {
            throw new NotImplementedException();
        }
    }
}
