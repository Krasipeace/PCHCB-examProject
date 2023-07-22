﻿namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Data;
    using PCHCB.Web.ViewModels.Ram;

    using static PCHCB.Common.GeneralAppConstants;

    public class RamService : IRamService
    {
        private readonly PCHCBDbContext dbContext;

        public RamService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> CreateRamAsync(string providerId, RamFormModel model)
        {
            Ram ram = new Ram()
            {
                Name = model.Name,
                Price = model.Price,
                Type = (RamType)model.Type,
                Frequency = model.Frequency,
                Capacity = model.Capacity,
                Height = model.Height,
                ModelNumber = model.ModelNumber,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse(providerId),
            };

            await this.dbContext.Rams.AddAsync(ram);
            await this.dbContext.SaveChangesAsync();

            return ram.Id;
        }

        public async Task DeleteRamByIdAsync(int ramId)
        {
            Ram ram = await this.dbContext.Rams
                .FirstAsync(r => r.Id == ramId);

            ram.Name = ComponentUnavailable;
            this.dbContext.Rams.Remove(ram);

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<RamFormModel> GetRamForEditByIdAsync(int ramId)
        {
            Ram ram = await this.dbContext.Rams
                .FirstAsync(r => r.Id == ramId);

            return new RamFormModel()
            {
                Name = ram.Name,
                Price = ram.Price,
                Type = (int)ram.Type,
                Frequency = ram.Frequency,
                Capacity = ram.Capacity,
                Height = ram.Height,
                ModelNumber = ram.ModelNumber,
                ImageUrl = ram.ImageUrl,
                Description = ram.Description,
            };
        }

        public async Task EditRamByIdAndFormModelAsync(int ramId, RamFormModel model)
        {
            Ram ram = await this.dbContext.Rams
                .FirstAsync(r => r.Id == ramId);

            ram.Name = model.Name;
            ram.Price = model.Price;
            ram.Type = (RamType)model.Type;
            ram.Frequency = model.Frequency;
            ram.Capacity = model.Capacity;
            ram.Height = model.Height;
            ram.ModelNumber = model.ModelNumber;
            ram.ImageUrl = model.ImageUrl;
            ram.Description = model.Description;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsProviderIdOwnerOfRamIdAsync(string providerId, int ramId)
        {
            Ram ram = await this.dbContext.Rams
                .FirstAsync(r => r.Id == ramId);

            return ram.ProviderId.ToString() == providerId;
        }

        public async Task<bool> IsRamExistByIdAsync(int ramId)
        {
            bool result = await this.dbContext.Rams
                .AnyAsync(r => r.Id == ramId);

            return result;
        }
    }
}