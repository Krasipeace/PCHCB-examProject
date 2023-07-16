namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.Provider;

    public interface IProviderService
    {
        Task<bool> ProviderExistsByUserIdAsync(string userId);

        Task<bool> ProviderExistsByPhoneNumber(string phoneNumber);

        Task<bool> ProviderExistsByWebSite(string webPage);

        Task<bool> ProviderExistsByLogoUrl(string logoUrl);

        Task CreateProvider(string userId, BecomeProviderFormModel model);

        Task<string?> GetProviderByUserIdAsync(string userId);
    }
}
