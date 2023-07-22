namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Data;
    using PCHCB.Web.ViewModels.Gpu;

    using static PCHCB.Common.GeneralAppConstants;

    public class GpuService : IGpuService
    {
        private readonly PCHCBDbContext dbContext;

        public GpuService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> CreateGpuAsync(string providerId, GpuFormModel model)
        {
            Gpu gpu = new Gpu()
            {
                Name = model.Name,
                Price = model.Price,
                Memory = model.Memory,
                Interface = (InterfaceType)model.Interface,
                Length = model.Length,
                SlotsRequired = model.SlotsRequired,
                PowerConsumption = model.PowerConsumption,
                NvidiaConnector = model.NvidiaConnector,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse(providerId),
            };

            await this.dbContext.Gpus.AddAsync(gpu);
            await this.dbContext.SaveChangesAsync();

            return gpu.Id;
        }

        public async Task<GpuFormModel> GetGpuForEditByIdAsync(int gpuId)
        {
            Gpu gpu = await this.dbContext.Gpus
                .FirstAsync(g => g.Id == gpuId);

            return new GpuFormModel()
            {
                Name = gpu.Name,
                Price = gpu.Price,
                Memory = gpu.Memory,
                Interface = (int)gpu.Interface,
                Length = gpu.Length,
                SlotsRequired = gpu.SlotsRequired,
                PowerConsumption = gpu.PowerConsumption,
                NvidiaConnector = gpu.NvidiaConnector,
                ImageUrl = gpu.ImageUrl,
                Description = gpu.Description,
            };
        }

        public async Task EditGpuByIdAndFormModelAsync(int gpuId, GpuFormModel model)
        {
            Gpu gpu = await this.dbContext.Gpus
                .FirstAsync(g => g.Id == gpuId);

            gpu.Name = model.Name;
            gpu.Price = model.Price;
            gpu.Memory = model.Memory;
            gpu.Interface = (InterfaceType)model.Interface;
            gpu.Length = model.Length;
            gpu.SlotsRequired = model.SlotsRequired;
            gpu.PowerConsumption = model.PowerConsumption;
            gpu.NvidiaConnector = model.NvidiaConnector;
            gpu.ImageUrl = model.ImageUrl;
            gpu.Description = model.Description;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteGpuByIdAsync(int gpuId)
        {
            Gpu gpu = await this.dbContext.Gpus
                .FirstAsync(g => g.Id == gpuId);

            gpu.Name = ComponentUnavailable;
            this.dbContext.Gpus.Remove(gpu);

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsGpuExistByIdAsync(int gpuId)
        {
            bool result = await this.dbContext.Gpus
                .AnyAsync(g => g.Id == gpuId);

            return result;
        }

        public async Task<bool> IsProviderIdOwnerOfGpuIdAsync(string providerId, int gpuId)
        {
            Gpu gpu = await this.dbContext.Gpus
                .FirstAsync(g => g.Id == gpuId);

            return gpu.ProviderId.ToString() == providerId;
        }
    }
}
