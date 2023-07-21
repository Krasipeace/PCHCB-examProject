namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.Cpu;

    public interface ICpuService
    {
        Task CreateCpu(string providerId, CpuFormModel model);

        Task EditCpuByIdAndFormModelAsync(int cpuId, CpuFormModel model);

        Task DeleteCpuByIdAsync(int cpuId);

        Task<bool> IsCpuExistByIdAsync(int cpuId);

        Task<bool> IsProviderIdOwnerOfCpuIdAsync(string providerId, int cpuId);

        //Task<CpuDeleteDetailsViewModel> GetCpuForDeleteByIdAsync(int cpuId);

        //Task<CpuDetailsViewModel> GetCpuDetailsAsync(int cpuId);

        //Task<IEnumerable<CpuAllViewModel>> AllByProviderIdAsync(string providerId);

        //Task<IEnumerable<CpuAllViewModel>> AllAvailableCpus(int cpuId);
    }
}
