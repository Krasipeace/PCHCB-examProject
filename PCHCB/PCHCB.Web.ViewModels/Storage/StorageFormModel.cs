namespace PCHCB.Web.ViewModels.Storage
{
    using System.ComponentModel.DataAnnotations;

    using static PCHCB.Common.EntityValidationConstants.Component;
    using static PCHCB.Common.EntityValidationConstants.Storage;
    using static PCHCB.Common.InputValidationDataMessages.General;
    using static PCHCB.Common.InputValidationDataMessages.Storage;

    /// <summary>
    /// Create/Edit Storage
    /// </summary>
    public class StorageFormModel
    {
        [Required(ErrorMessage = RequiredFieldMessage)]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = NameLengthErrorMessage)]
        [Display(Name = "Storage Drive Name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(typeof(decimal), PriceMinValue, PriceMaxValue, ErrorMessage = PriceRangeErrorMessage)]
        [Display(Name = "Storage Drive Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(CapacityMinValue, CapacityMaxValue, ErrorMessage = CapacityRangeErrorMessage)]
        [Display(Name = "Storage Drive Capacity (GB)")]
        public int Capacity { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(TypeMinValue, TypeMaxValue, ErrorMessage = TypeRangeErrorMessage)]
        [Display(Name = "Storage Drive Type")]
        public int Type { get; set; }

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
