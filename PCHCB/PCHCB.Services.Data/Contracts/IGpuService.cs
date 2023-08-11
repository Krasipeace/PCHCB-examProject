namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.Cpu;
    using PCHCB.Web.ViewModels.Gpu;
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Provider;

    public interface IGpuService
    {
        Task<int> CreateGpuAsync(string providerId, GpuFormModel model);

        Task<GpuFormModel> GetGpuForEditByIdAsync(int gpuId);

        Task EditGpuByIdAndFormModelAsync(int gpuId, GpuFormModel model);

        Task<DeleteDetailsViewModel> GetGpuForDeleteByIdAsync(int gpuId);

        Task DeleteGpuByIdAsync(int gpuId);

        Task<bool> IsGpuExistByIdAsync(int gpuId);

        Task<bool> IsProviderIdOwnerOfGpuIdAsync(string providerId, int gpuId);

        Task<IEnumerable<AllViewModel>> GetAllGpusAsync();

        Task<SearchResult> SearchGpusAsync(AllQueryModel queryModel);

        Task<GpuDetailsViewModel> GetGpuDetailsAsync(int gpuId);
    }
}
