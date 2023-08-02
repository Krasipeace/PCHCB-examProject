namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data;
    using PCHCB.Data.Models;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.ViewModels.User;

    public class UserService : IUserService
    {
        private readonly PCHCBDbContext dbContext;

        public UserService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<string> GetFullNameByEmailAsync(string email)
        {
            ApplicationUser? user = await dbContext.Users
                .FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
            {
                return string.Empty;
            }

            return $"{user.FirstName} {user.LastName}";
        }

        public async Task<IEnumerable<UserViewModel>> AllUsersAsync()
        {
            List<UserViewModel> allUsers = await this.dbContext
                .Users
                .Select(u => new UserViewModel()
                {
                    Id = u.Id.ToString(),
                    Email = u.Email,
                    FullName = u.FirstName + " " + u.LastName
                })
                .ToListAsync();
            foreach (UserViewModel user in allUsers)
            {
                Provider? provider = this.dbContext
                    .Providers
                    .FirstOrDefault(a => a.UserId.ToString() == user.Id);
                if (provider != null)
                {
                    user.PhoneNumber = provider.PhoneNumber;
                }
                else
                {
                    user.PhoneNumber = string.Empty;
                }
            }

            return allUsers;
        }
    }
}
