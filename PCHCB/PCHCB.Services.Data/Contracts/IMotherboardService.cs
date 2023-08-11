namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.Cpu;
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Motherboard;
    using PCHCB.Web.ViewModels.Provider;

    public interface IMotherboardService
    {
        Task<int> CreateMotherboardAsync(string providerId, MotherboardFormModel model);

        Task<MotherboardFormModel> GetMotherboardForEditByIdAsync(int motherboardId);

        Task EditMotherboardByIdAndFormModelAsync(int motherboardId, MotherboardFormModel model);

        Task<DeleteDetailsViewModel> GetMotherboardForDeleteByIdAsync(int motherboardId);

        Task DeleteMotherboardByIdAsync(int motherboardId);

        Task<bool> IsMotherboardExistByIdAsync(int motherboardId);

        Task<bool> IsProviderIdOwnerOfMotherboardIdAsync(string providerId, int motherboardId);

        Task<IEnumerable<AllViewModel>> GetAllMotherboardsAsync();

        Task<SearchResult> SearchMotherboardsAsync(AllQueryModel queryModel);

        Task<MotherboardDetailsViewModel> GetMotherboardDetailsAsync(int motherboardId);
    }
}
