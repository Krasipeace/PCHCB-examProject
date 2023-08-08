namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data;
    using PCHCB.Services.Data.Contracts;

    public class PcConfigurationService : IPcConfigurationService
    {
        private readonly PCHCBDbContext dbContext;

        public PcConfigurationService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<decimal> CalculatePcConfigurationPrice(int pcConfigurationId)
        {
            //decimal totalPrice = 0;
            //var components = await dbContext.PcConfigurations
            //    .Where(c => c.ConfigurationHardwares.First().PcConfigurationId == pcConfigurationId).ToListAsync();
            //foreach (var component in components)
            //{
            //    totalPrice += component.Price;
            //}
            //return totalPrice;
            return 0m;
        }
    }
}
