namespace PCHCB.Web.ViewModels.Storage
{
    using System.ComponentModel.DataAnnotations;

    using static PCHCB.Common.EntityValidationConstants.Component;
    using static PCHCB.Common.EntityValidationConstants.Storage;
    using static PCHCB.Common.InputValidationDataMessages.General;
    using static PCHCB.Common.InputValidationDataMessages.Storage;

    public class StorageFormModel
    {
        [Required(ErrorMessage = RequiredFieldMessage)]
        [Display(Name = "Storage Drive Name")]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = NameLengthErrorMessage)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(typeof(decimal), PriceMinValue, PriceMaxValue, ErrorMessage = PriceRangeErrorMessage)]
        [Display(Name = "Storage Drive Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(CapacityMinValue, CapacityMaxValue, ErrorMessage = CapacityRangeErrorMessage)]
        [Display(Name = "Storage Drive Capacity (MB)")]
        public int Capacity { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(TypeMinValue, TypeMaxValue, ErrorMessage = TypeRangeErrorMessage)]
        public int Type { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Url]
        [Display(Name = "Image Link")]
        [StringLength(UrlMaxLength, MinimumLength = UrlMinLength, ErrorMessage = UrlLengthErrorMessage)]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Display(Name = "Description")]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = DescriptionLengthErrorMessage)]
        public string Description { get; set; } = null!;
    }
}
