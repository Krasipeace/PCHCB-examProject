namespace PCHCB.Web.ViewModels.Provider
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Full info about provider
    /// </summary>
    public class ProviderDetailsViewModel : ProviderInfoViewModel
    {
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = null!;
        
        public string LogoUrl { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
