namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.Gpu;

    public interface IGpuService
    {
        Task CreateGpu(string providerId, GpuFormModel model);

        Task EditGpuByIdAndFormModelAsync(int gpuId, GpuFormModel model);

        Task DeleteGpuByIdAsync(int gpuId);

        Task<bool> IsGpuExistByIdAsync(int gpuId);

        Task<bool> IsProviderIdOwnerOfGpuIdAsync(string providerId, int gpuId);

        //Task<GpuDeleteDetailsViewModel> GetGpuForDeleteByIdAsync(int gpuId);

        //Task<GpuDetailsViewModel> GetGpuDetailsAsync(int gpuId);

        //Task<IEnumerable<GpuAllViewModel>> AllByProviderIdAsync(string providerId);

        //Task<IEnumerable<GpuAllViewModel>> AllAvailableGpus(int gpuId);
    }
}
