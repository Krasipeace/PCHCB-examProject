namespace PCHCB.Web.ViewModels.Ram
{
    using System.ComponentModel.DataAnnotations;

    using static PCHCB.Common.EntityValidationConstants.Component;
    using static PCHCB.Common.EntityValidationConstants.Ram;
    using static PCHCB.Common.InputValidationDataMessages.General;
    using static PCHCB.Common.InputValidationDataMessages.Ram;

    public class RamFormModel
    {
        [Required(ErrorMessage = RequiredFieldMessage)]
        [Display(Name = "Memory Stick(s) Name")]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = NameLengthErrorMessage)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(typeof(decimal), PriceMinValue, PriceMaxValue, ErrorMessage = PriceRangeErrorMessage)]
        [Display(Name = "Memory Stick(s) Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(DDRRangeMinValue, DDRRangeMaxValue, ErrorMessage = DDRTypeRangeErrorMessage)]
        [Display(Name = "RAM Type")]
        public int Type { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(FrequencyMinValue, FrequencyMaxValue, ErrorMessage = FrequencyRangeErrorMessage)]
        [Display(Name = "Frequency (MHz)")]
        public int Frequency { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(CapacityMinValue, CapacityMaxValue, ErrorMessage = CapacityRangeErrorMessage)]
        [Display(Name = "Capacity (GB)")]
        public int Capacity { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(HeightMinValue, HeightMaxValue, ErrorMessage = HeightRangeErrorMessage)]
        [Display(Name = "Height (mm)")]
        public double Height { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [StringLength(ModelNumberMaxLengthValue, MinimumLength = ModelNumberMinLengthValue, ErrorMessage = ModelNumberLengthErrorMessage)]
        [Display(Name = "Model Number")]
        public string ModelNumber { get; set; } = null!;

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
