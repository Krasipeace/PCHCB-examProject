namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.Psu;

    public interface IPsuService
    {
        Task CreatePsu(string providerId, PsuFormModel model);

        Task EditPsuByIdAndFormModelAsync(int psuId, PsuFormModel model);

        Task DeletePsuByIdAsync(int psuId);

        Task<bool> IsPsuExistByIdAsync(int psuId);

        Task<bool> IsProviderIdOwnerOfPsuIdAsync(string providerId, int psuId);

        //Task<PsuDeleteDetailsViewModel> GetPsuForDeleteByIdAsync(int psuId);

        //Task<PsuDetailsViewModel> GetPsuDetailsAsync(int psuId);

        //Task<IEnumerable<PsuAllViewModel>> AllByProviderIdAsync(string providerId);

        //Task<IEnumerable<PsuAllViewModel>> AllAvailablePsus(int psuId);
    }
}
