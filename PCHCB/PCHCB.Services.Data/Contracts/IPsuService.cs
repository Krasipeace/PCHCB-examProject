namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.ViewModels.Psu;

    public interface IPsuService
    {
        Task<int> CreatePsuAsync(string providerId, PsuFormModel model);

        public Task<PsuFormModel> GetPsuForEditByIdAsync(int psuId);

        Task EditPsuByIdAndFormModelAsync(int psuId, PsuFormModel model);

        Task<DeleteDetailsViewModel> GetPsuForDeleteByIdAsync(int psuId);

        Task DeletePsuByIdAsync(int psuId);

        Task<bool> IsPsuExistByIdAsync(int psuId);

        Task<bool> IsProviderIdOwnerOfPsuIdAsync(string providerId, int psuId);

        Task<IEnumerable<AllViewModel>> GetAllPsusAsync();

        Task<PsuDetailsViewModel> GetPsuDetailsAsync(int psuId);
    }
}
