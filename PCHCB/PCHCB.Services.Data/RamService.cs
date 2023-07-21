namespace PCHCB.Services.Data
{
    using System;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Data;
    using PCHCB.Web.ViewModels.Ram;

    public class RamService : IRamService
    {
        private readonly PCHCBDbContext dbContext;

        public RamService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task CreateRam(string providerId, RamFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRamByIdAsync(int ramId)
        {
            throw new NotImplementedException();
        }

        public Task EditRamByIdAndFormModelAsync(int ramId, RamFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsProviderIdOwnerOfRamIdAsync(string providerId, int ramId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsRamExistByIdAsync(int ramId)
        {
            throw new NotImplementedException();
        }
    }
}
