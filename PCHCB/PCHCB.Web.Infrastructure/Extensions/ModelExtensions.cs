namespace PCHCB.Web.Infrastructure.Extensions
{
    using PCHCB.Web.ViewModels.Contracts;

    public static class ModelExtensions
    {
        public static string GetUrlInformation(this IProtectedUrlsModel model)
        {
            return model.Name.Replace(" ", "-");
        }
    }
}
