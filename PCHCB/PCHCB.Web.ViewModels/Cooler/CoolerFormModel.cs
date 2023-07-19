namespace PCHCB.Web.ViewModels.Cooler
{
    using System.ComponentModel.DataAnnotations;

    using static PCHCB.Common.EntityValidationConstants.Component;
    using static PCHCB.Common.EntityValidationConstants.Cooler;
    using static PCHCB.Common.InputValidationDataMessages.General;
    using static PCHCB.Common.InputValidationDataMessages.Cooler;

    public class CoolerFormModel
    {
        [Required(ErrorMessage = RequiredFieldMessage)]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = NameLengthErrorMessage)]
        [Display(Name = "Cooler Name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(typeof(decimal), PriceMinValue, PriceMaxValue, ErrorMessage = PriceRangeErrorMessage)]
        [Display(Name = "Cooler Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Display(Name = "Cooler Type")]
        [Range(CoolerTypeMinValue, CoolerTypeMaxValue, ErrorMessage = CoolerTypeErrorMessage)]
        public int Type { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Url]
        [Display(Name = "Image Link")]
        [StringLength(UrlMaxLength, MinimumLength = UrlMinLength, ErrorMessage = UrlLengthErrorMessage)]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Display(Name = "Cooler's Cpu Socket Compatibility")]
        [StringLength(CompatibilityMaxLength, MinimumLength = CompatibilityMinLength, ErrorMessage = CoolerCompatibilityLengthMessage)]
        public string Compatibility { get; set; } = null!;

        [Display(Name = "Water Cooler Radiator Length Size (in mm)")]
        [Range(RadiatorSizeMinValue, RadiatorSizeMaxValue)]
        public int RadiatorSize { get; set; }

        [Display(Name = "Fan Size (in mm)")]
        [Range(FanSizeMinValue, FanSizeMaxValue)]
        public int FanSize { get; set; }

        [Display(Name = "Cooler Height (in mm)")]
        [Range(CoolerHeightMinValue, CoolerHeightMaxValue)]
        public double CoolerHeight { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Display(Name = "Cooler Thermal Design Point(TDP)")]
        [Range(TdpMinValue, TdpMaxValue)]
        public int Tdp { get; set; }

        [Display(Name = "Cooler Width (in mm)")]
        [Range(WidthMinValue, WidthMaxValue)]
        public int Width { get; set; }

        [Display(Name = "Description")]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = DescriptionLengthErrorMessage)]
        public string Description { get; set; } = null!;
    }
}
