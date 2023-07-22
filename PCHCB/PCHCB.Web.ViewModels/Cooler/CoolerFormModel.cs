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
        [Range(CoolerTypeMinValue, CoolerTypeMaxValue, ErrorMessage = CoolerTypeErrorMessage)]
        [Display(Name = "Cooler Type")]
        public int Type { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [StringLength(CompatibilityMaxLength, MinimumLength = CompatibilityMinLength, ErrorMessage = CoolerCompatibilityLengthMessage)]
        [Display(Name = "Cooler's Cpu Socket Compatibility")]
        public string Compatibility { get; set; } = null!;

        [Range(RadiatorSizeMinValue, RadiatorSizeMaxValue)]
        [Display(Name = "Water Cooler Radiator Length Size (in mm)")]
        public int RadiatorSize { get; set; }

        [Range(FanSizeMinValue, FanSizeMaxValue)]
        [Display(Name = "Fan Size (in mm)")]
        public int FanSize { get; set; }

        [Range(CoolerHeightMinValue, CoolerHeightMaxValue)]
        [Display(Name = "Cooler Height (in mm)")]
        public double CoolerHeight { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(TdpMinValue, TdpMaxValue)]
        [Display(Name = "Max Cooler Thermal Design Point(TDP)")]
        public int Tdp { get; set; }

        [Range(WidthMinValue, WidthMaxValue)]
        [Display(Name = "Cooler Width (in mm)")]
        public int Width { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Url]
        [StringLength(UrlMaxLength, MinimumLength = UrlMinLength, ErrorMessage = UrlLengthErrorMessage)]
        [Display(Name = "Image Link")]
        public string ImageUrl { get; set; } = null!;

        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = DescriptionLengthErrorMessage)]
        [Display(Name = "Description")]
        public string Description { get; set; } = null!;
    }
}
