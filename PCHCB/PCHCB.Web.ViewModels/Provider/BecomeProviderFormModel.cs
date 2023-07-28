namespace PCHCB.Web.ViewModels.Provider
{
    using System.ComponentModel.DataAnnotations;

    using static PCHCB.Common.EntityValidationConstants.Provider;
    using static PCHCB.Common.InputValidationDataMessages.General;
    using static PCHCB.Common.InputValidationDataMessages.Provider;

    /// <summary>
    /// Register User as Provider Form Model
    /// </summary>
    public class BecomeProviderFormModel
    {
        [Required(ErrorMessage = RequiredFieldMessage)]
        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength, ErrorMessage = PhoneNumberLengthErrorMessage)]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [StringLength(UrlMaxLength, MinimumLength = UrlMinLength, ErrorMessage = WebPageLengthErrorMessage)]
        [Url]
        [Display(Name = "Web Site Link")]
        public string WebPage { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [StringLength(UrlMaxLength, MinimumLength = UrlMinLength, ErrorMessage = LogoUrlLengthErrorMessage)]
        [Url]
        [Display(Name = "Logo Image Link")]
        public string LogoUrl { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = DescriptionLengthErrorMessage)]
        [Display(Name = "Description")]
        public string Description { get; set; } = null!;
    }
}
