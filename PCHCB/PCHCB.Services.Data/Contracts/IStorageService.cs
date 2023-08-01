namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.ViewModels.Storage;

    public interface IStorageService
    {
        Task<int> CreateStorageAsync(string providerId, StorageFormModel model);

        public Task<StorageFormModel> GetStorageForEditByIdAsync(int storageId);

        Task EditStorageByIdAndFormModelAsync(int storageId, StorageFormModel model);

        Task<DeleteDetailsViewModel> GetStorageForDeleteByIdAsync(int storageId);

        Task DeleteStorageByIdAsync(int storageId);

        Task<bool> IsStorageExistByIdAsync(int storageId);

        Task<bool> IsProviderIdOwnerOfStorageIdAsync(string providerId, int storageId);

        Task<IEnumerable<AllViewModel>> GetAllStoragesAsync();

        Task<SearchResult> SearchStoragesAsync(AllQueryModel queryModel);

        Task<StorageDetailsViewModel> GetStorageDetailsAsync(int storageId);
    }
}
