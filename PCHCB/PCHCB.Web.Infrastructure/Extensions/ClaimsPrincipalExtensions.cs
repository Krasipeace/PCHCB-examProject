namespace PCHCB.Web.Infrastructure.Extensions
{
    using System.Security.Claims;

    using static PCHCB.Common.GeneralAppConstants;

    public static class ClaimsPrincipalExtensions
    {
        /// <summary>
        /// Extension method to get the user's id from the claims principal
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Value of NameIdentifier as string</returns>
        public static string? GetId(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        /// <summary>
        /// Extension method to check if the user is an `admin`
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool IsAdmin(this ClaimsPrincipal user)
        {
            return user.IsInRole(AdminRoleName);
        }
    }
}
