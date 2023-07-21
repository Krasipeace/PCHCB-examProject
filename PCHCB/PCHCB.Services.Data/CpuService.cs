namespace PCHCB.Services.Data
{
    using System;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Data;
    using PCHCB.Web.ViewModels.Cpu;

    public class CpuService : ICpuService
    {
        private readonly PCHCBDbContext dbContext;

        public CpuService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task CreateCpu(string providerId, CpuFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCpuByIdAsync(int cpuId)
        {
            throw new NotImplementedException();
        }

        public Task EditCpuByIdAndFormModelAsync(int cpuId, CpuFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsCpuExistByIdAsync(int cpuId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsProviderIdOwnerOfCpuIdAsync(string providerId, int cpuId)
        {
            throw new NotImplementedException();
        }
    }
}
