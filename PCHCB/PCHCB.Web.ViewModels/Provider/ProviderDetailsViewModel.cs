namespace PCHCB.Web.ViewModels.Provider
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Full info about provider
    /// </summary>
    public class ProviderDetailsViewModel
    {
        [Display(Name = "Web Site")]
        public string WebPage { get; set; } = null!;

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = null!;
        
        public string LogoUrl { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
