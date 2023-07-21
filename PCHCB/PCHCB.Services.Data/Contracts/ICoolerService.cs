namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.Case;
    using PCHCB.Web.ViewModels.Cooler;

    public interface ICoolerService
    {
        Task CreateCooler(string providerId, CoolerFormModel model);

        public Task<CoolerFormModel> GetCoolerForEditByIdAsync(int coolerId);

        Task EditCoolerByIdAndFormModelAsync(int coolerId, CoolerFormModel model);

        Task DeleteCoolerByIdAsync(int coolerId);

        Task<bool> IsCoolerExistByIdAsync(int coolerId);

        Task<bool> IsProviderIdOwnerOfCoolerIdAsync(string providerId, int coolerId);

        //Task<CoolerDeleteDetailsViewModel> GetCoolerForDeleteByIdAsync(int coolerId);

        //Task<CoolerDetailsViewModel> GetCoolerDetailsAsync(int coolerId);

        //Task<IEnumerable<CoolerAllViewModel>> AllByProviderIdAsync(string providerId);

        //Task<IEnumerable<CoolerAllViewModel>> AllAvailableCoolers(int coolerId);
    }
}
