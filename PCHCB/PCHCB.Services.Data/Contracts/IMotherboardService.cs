namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.Motherboard;

    public interface IMotherboardService
    {
        Task<int> CreateMotherboardAsync(string providerId, MotherboardFormModel model);

        public Task<MotherboardFormModel> GetMotherboardForEditByIdAsync(int motherboardId);

        Task EditMotherboardByIdAndFormModelAsync(int motherboardId, MotherboardFormModel model);

        Task DeleteMotherboardByIdAsync(int motherboardId);

        Task<bool> IsMotherboardExistByIdAsync(int motherboardId);

        Task<bool> IsProviderIdOwnerOfMotherboardIdAsync(string providerId, int motherboardId);

        //Task<MotherboardDeleteDetailsViewModel> GetMotherboardForDeleteByIdAsync(int motherboardId);

        //Task<MotherboardDetailsViewModel> GetMotherboardDetailsAsync(int motherboardId);

        //Task<IEnumerable<MotherboardAllViewModel>> AllByProviderIdAsync(string providerId);

        //Task<IEnumerable<MotherboardAllViewModel>> AllAvailableMotherboards(int motherboardId);
    }
}
