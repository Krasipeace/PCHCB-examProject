namespace PCHCB.Services.Data
{
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Data;
    using PCHCB.Web.ViewModels.Gpu;

    public class GpuService : IGpuService
    {
        private readonly PCHCBDbContext dbContext;

        public GpuService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task CreateGpu(string providerId, GpuFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteGpuByIdAsync(int gpuId)
        {
            throw new NotImplementedException();
        }

        public Task EditGpuByIdAndFormModelAsync(int gpuId, GpuFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsGpuExistByIdAsync(int gpuId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsProviderIdOwnerOfGpuIdAsync(string providerId, int gpuId)
        {
            throw new NotImplementedException();
        }
    }
}
