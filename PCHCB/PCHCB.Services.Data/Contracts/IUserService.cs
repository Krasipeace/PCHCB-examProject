namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.User;

    public interface IUserService
    {
        Task<string> GetFullNameByEmailAsync(string email);

        Task<IEnumerable<UserViewModel>> AllUsersAsync();
    }
}
