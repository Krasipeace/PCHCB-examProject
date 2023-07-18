namespace PCHCB.Web.Infrastructure.Extensions
{
    using System.Security.Claims;

    public static class ClaimsPrincipalExtensions
    {
        /// <summary>
        /// Extentsion method to get the user's id from the claims principal
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Value of NameIdentifier as string</returns>
        public static string? GetId(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
