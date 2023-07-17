namespace PCHCB.Web.ViewModels.Provider
{
    using System.ComponentModel.DataAnnotations;

    using static PCHCB.Common.EntityValidationConstants.Provider;

    public class BecomeProviderFormModel
    {
        [Required(ErrorMessage = "The {0} is required.")]
        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength, ErrorMessage = "The Phone Number must be between {2} and {1} digits!")]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "The {0} is required.")]
        [StringLength(UrlMaxLength, MinimumLength = UrlMinLength, ErrorMessage = "The Web Page must be between {2} and {1} characters!")]
        [Url]
        [Display(Name = "Web Page URL")]
        public string WebPage { get; set; } = null!;

        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = "The Description must be between {2} and {1} characters!")]
        [Url]
        [Display(Name = "Logo Image URL")]
        public string LogoUrl { get; set; } = null!;

        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = "The Description must be between {2} and {1} characters!")]
        [Display(Name = "Description")]
        public string Description { get; set; } = null!;
    }
}
