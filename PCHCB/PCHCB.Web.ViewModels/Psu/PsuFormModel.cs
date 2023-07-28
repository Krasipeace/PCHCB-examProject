namespace PCHCB.Web.ViewModels.Psu
{
    using System.ComponentModel.DataAnnotations;

    using static PCHCB.Common.EntityValidationConstants.Component;
    using static PCHCB.Common.EntityValidationConstants.Psu;
    using static PCHCB.Common.InputValidationDataMessages.General;
    using static PCHCB.Common.InputValidationDataMessages.Psu;

    /// <summary>
    /// Create/Edit PSU
    /// </summary>
    public class PsuFormModel
    {
        [Required(ErrorMessage = RequiredFieldMessage)]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = NameLengthErrorMessage)]
        [Display(Name = "Power Supply Unit Name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(typeof(decimal), PriceMinValue, PriceMaxValue, ErrorMessage = PriceRangeErrorMessage)]
        [Display(Name = "Power Supply Unit Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(WattsMinValue, WattsMaxValue, ErrorMessage = WattsRangeErrorMessage)]
        [Display(Name = "PSU Wattage")]
        public int Wattage { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(FactorRangeMinValue, FactorRangeMaxValue, ErrorMessage = FactorRangeErrorMessage)]
        [Display(Name = "PSU Factor Type")]
        public int Factor { get; set; } 

        [Required]
        [Display(Name = "Nvidia Power Connector")]
        public bool NvidiaConnector { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Url]
        [StringLength(UrlMaxLength, MinimumLength = UrlMinLength, ErrorMessage = UrlLengthErrorMessage)]
        [Display(Name = "Image Link")]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = DescriptionLengthErrorMessage)]
        [Display(Name = "Description")]
        public string Description { get; set; } = null!;
    }
}
