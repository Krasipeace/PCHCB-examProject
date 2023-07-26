namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data.Models;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Data;
    using PCHCB.Web.ViewModels.Provider;

    public class ProviderService : IProviderService
    {
        private readonly PCHCBDbContext dbContext;

        public ProviderService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateProvider(string userId, BecomeProviderFormModel model)
        {
            Provider newProvider = new()
            {
                PhoneNumber = model.PhoneNumber,
                WebPage = model.WebPage,
                LogoUrl = model.LogoUrl,
                Description = model.Description,
                UserId = Guid.Parse(userId),
            };

            await this.dbContext.Providers
                .AddAsync(newProvider);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<string?> GetProviderByUserIdAsync(string userId)
        {
            Provider? provider = await this.dbContext.Providers
                .FirstOrDefaultAsync(p => p.UserId.ToString() == userId);
            if (provider == null)
            {
                return null;
            }

            return provider.Id.ToString();
        }

        public async Task<ProviderDetailsViewModel> GetProviderDetailsByIdAsync(string providerId)
        {
            return await this.dbContext.Providers 
                .Select(p => new ProviderDetailsViewModel()
                {
                    Id = p.Id,
                    PhoneNumber = p.PhoneNumber,
                    WebPage = p.WebPage,
                    LogoUrl = p.LogoUrl,
                    Description = p.Description
                })
                .FirstAsync(p => p.Id.ToString().ToLower() == providerId.ToLower());
        }

        public async Task<bool> ProviderExistsByLogoUrl(string logoUrl)
        {
            bool result = await this.dbContext.Providers
                .AnyAsync(p => p.LogoUrl == logoUrl);

            return result;
        }

        public async Task<bool> ProviderExistsByPhoneNumber(string phoneNumber)
        {
            bool result = await this.dbContext.Providers
                .AnyAsync(p => p.PhoneNumber == phoneNumber);

            return result;
        }

        public async Task<bool> ProviderExistsByUserIdAsync(string userId)
        {
            bool result = await this.dbContext.Providers
                .AnyAsync(p => p.UserId.ToString() == userId);

            return result;
        }

        public async Task<bool> ProviderExistsByWebSite(string webPage)
        {
            bool result = await this.dbContext.Providers
                .AnyAsync(p => p.WebPage == webPage);

            return result;
        }       
    }
}
