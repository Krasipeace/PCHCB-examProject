namespace PCHCB.Services.Data.Contracts
{
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

        //Task<PsuDeleteDetailsViewModel> GetPsuForDeleteByIdAsync(int psuId);

        //Task<PsuDetailsViewModel> GetPsuDetailsAsync(int psuId);

        //Task<IEnumerable<PsuAllViewModel>> AllByProviderIdAsync(string providerId);

        //Task<IEnumerable<PsuAllViewModel>> AllAvailablePsus(int psuId);
    }
}
