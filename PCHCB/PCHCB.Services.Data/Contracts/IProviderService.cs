namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.Case;
    using PCHCB.Web.ViewModels.Cooler;
    using PCHCB.Web.ViewModels.Cpu;
    using PCHCB.Web.ViewModels.Gpu;
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Motherboard;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.ViewModels.Psu;
    using PCHCB.Web.ViewModels.Ram;
    using PCHCB.Web.ViewModels.Storage;

    public interface IProviderService
    {
        Task<bool> ProviderExistsByUserIdAsync(string userId);

        Task<bool> ProviderExistsByPhoneNumber(string phoneNumber);

        Task<bool> ProviderExistsByWebSite(string webPage);

        Task<bool> ProviderExistsByLogoUrl(string logoUrl);

        Task CreateProvider(string userId, BecomeProviderFormModel model);

        Task<string?> GetProviderByUserIdAsync(string userId);

        Task<ProviderDetailsViewModel> GetProviderDetailsByIdAsync(string providerId);

        Task<IEnumerable<CaseAllViewModel>> AllCasesByProviderIdAsync(string providerId);

        Task<IEnumerable<CoolerAllViewModel>> AllCoolersByProviderIdAsync(string providerId);

        Task<IEnumerable<CpuAllViewModel>> AllCpusByProviderIdAsync(string providerId);

        Task<IEnumerable<GpuAllViewModel>> AllGpusByProviderIdAsync(string providerId);

        Task<IEnumerable<MotherboardAllViewModel>> AllMotherboardsByProviderIdAsync(string providerId);

        Task<IEnumerable<PsuAllViewModel>> AllPsusByProviderIdAsync(string providerId);

        Task<IEnumerable<StorageAllViewModel>> AllStoragesByProviderIdAsync(string providerId);

        Task<IEnumerable<RamAllViewModel>> AllRamsByProviderIdAsync(string providerId);
    }
}
