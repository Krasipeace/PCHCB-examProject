namespace PCHCB.Services.Data
{
    using System;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Data;
    using PCHCB.Web.ViewModels.Motherboard;

    public class MotherboardService : IMotherboardService
    {
        private readonly PCHCBDbContext dbContext;

        public MotherboardService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task CreateMotherboard(string providerId, MotherboardFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMotherboardByIdAsync(int motherboardId)
        {
            throw new NotImplementedException();
        }

        public Task EditMotherboardByIdAndFormModelAsync(int motherboardId, MotherboardFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsMotherboardExistByIdAsync(int motherboardId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsProviderIdOwnerOfMotherboardIdAsync(string providerId, int motherboardId)
        {
            throw new NotImplementedException();
        }
    }
}
