namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.ViewModels.Ram;

    public interface IRamService
    {
        Task<int> CreateRamAsync(string providerId, RamFormModel model);

        public Task<RamFormModel> GetRamForEditByIdAsync(int ramId);

        Task EditRamByIdAndFormModelAsync(int ramId, RamFormModel model);

        Task<DeleteDetailsViewModel> GetRamForDeleteByIdAsync(int ramId);

        Task DeleteRamByIdAsync(int ramId);

        Task<bool> IsRamExistByIdAsync(int ramId);

        Task<bool> IsProviderIdOwnerOfRamIdAsync(string providerId, int ramId);

        Task<IEnumerable<AllViewModel>> GetAllRamsAsync();

        Task<SearchResult> SearchRamsAsync(AllQueryModel queryModel);

        Task<RamDetailsViewModel> GetRamDetailsAsync(int ramId);
    }
}
