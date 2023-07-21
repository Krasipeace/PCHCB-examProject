namespace PCHCB.Services.Data
{
    using System;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Data;
    using PCHCB.Web.ViewModels.Storage;

    public class StorageService : IStorageService
    {
        private readonly PCHCBDbContext dbContext;

        public StorageService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task CreateStorage(string providerId, StorageFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteStorageByIdAsync(int storageId)
        {
            throw new NotImplementedException();
        }

        public Task EditStorageByIdAndFormModelAsync(int storageId, StorageFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsProviderIdOwnerOfStorageIdAsync(string providerId, int storageId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsStorageExistByIdAsync(int storageId)
        {
            throw new NotImplementedException();
        }
    }
}
