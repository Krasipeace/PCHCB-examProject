namespace PCHCB.Services.Data.Contracts
{
    public interface IPcConfigurationService
    {
        Task<decimal> CalculatePcConfigurationPrice(int pcConfigurationId);
    }
}
