﻿namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Data;
    using PCHCB.Web.ViewModels.Storage;

    using static PCHCB.Common.GeneralAppConstants;

    public class StorageService : IStorageService
    {
        private readonly PCHCBDbContext dbContext;

        public StorageService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> CreateStorageAsync(string providerId, StorageFormModel model)
        {
            Storage storage = new Storage()
            {
                Name = model.Name,
                Price = model.Price,
                Capacity = model.Capacity,
                Type = (StorageType)model.Type,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse(providerId)
            };

            await this.dbContext.Storages.AddAsync(storage);
            await this.dbContext.SaveChangesAsync();

            return storage.Id;
        }

        public async Task DeleteStorageByIdAsync(int storageId)
        {
            Storage storage = await this.dbContext.Storages
                .FirstAsync(s => s.Id == storageId);

            storage.Name = ComponentUnavailable;
            this.dbContext.Storages.Remove(storage);

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<StorageFormModel> GetStorageForEditByIdAsync(int storageId)
        {
            Storage storage = await this.dbContext.Storages
                .FirstAsync(s => s.Id == storageId);

            return new StorageFormModel()
            {
                Name = storage.Name,
                Price = storage.Price,
                Capacity = storage.Capacity,
                Type = (int)storage.Type,
                ImageUrl = storage.ImageUrl,
                Description = storage.Description
            };
        }

        public async Task EditStorageByIdAndFormModelAsync(int storageId, StorageFormModel model)
        {
            Storage storage = await this.dbContext.Storages
                .FirstAsync(s => s.Id == storageId);

            storage.Name = model.Name;
            storage.Price = model.Price;
            storage.Capacity = model.Capacity;
            storage.Type = (StorageType)model.Type;
            storage.ImageUrl = model.ImageUrl;
            storage.Description = model.Description;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsProviderIdOwnerOfStorageIdAsync(string providerId, int storageId)
        {
            Storage storage = await this.dbContext.Storages
                .FirstAsync(s => s.Id == storageId);

            return storage.ProviderId.ToString() == providerId;
        }

        public async Task<bool> IsStorageExistByIdAsync(int storageId)
        {
            bool result = await this.dbContext.Storages
                .AnyAsync(s => s.Id == storageId);

            return result;
        }
    }
}