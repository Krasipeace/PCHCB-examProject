namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.Cooler;
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Provider;

    public interface ICoolerService
    {
        Task<int> CreateCoolerAsync(string providerId, CoolerFormModel model);

        Task<CoolerFormModel> GetCoolerForEditByIdAsync(int coolerId);

        Task EditCoolerByIdAndFormModelAsync(int coolerId, CoolerFormModel model);

        Task<DeleteDetailsViewModel> GetCoolerForDeleteByIdAsync(int coolerId);

        Task DeleteCoolerByIdAsync(int coolerId);

        Task<bool> IsCoolerExistByIdAsync(int coolerId);

        Task<bool> IsProviderIdOwnerOfCoolerIdAsync(string providerId, int coolerId);

        Task<IEnumerable<AllViewModel>> GetAllCoolersAsync();

        Task<SearchResult> SearchCoolersAsync(AllQueryModel queryModel);

        Task<CoolerDetailsViewModel> GetCoolerDetailsAsync(int coolerId);

        Task<IEnumerable<CoolerDetailsViewModel>> GetAllCoolersDetailsAsync();
    }
}
