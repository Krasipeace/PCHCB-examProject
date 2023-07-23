namespace PCHCB.Web.ViewModels.Provider
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Short info about provider
    /// </summary>
    public class ProviderInfoViewModel
    {
        public string LogoUrl { get; set; } = null!;

        [Display(Name = "Web Site")]
        public string WebPage { get; set; } = null!;
    }
}
