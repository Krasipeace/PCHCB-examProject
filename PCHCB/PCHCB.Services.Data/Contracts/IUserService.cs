namespace PCHCB.Services.Data.Contracts
{
    public interface IUserService
    {
        Task<string> GetFullNameByEmailAsync(string email);
    }
}
