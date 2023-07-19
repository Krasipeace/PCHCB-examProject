namespace PCHCB.Web.ViewModels.Case
{
    using System.ComponentModel.DataAnnotations;

    using static PCHCB.Common.EntityValidationConstants.Component;
    using static PCHCB.Common.InputValidationDataMessages.General;
    using static PCHCB.Common.EntityValidationConstants.Case;

    public class CaseFormModel
    {
        [Required(ErrorMessage = RequiredFieldMessage)]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = NameLengthErrorMessage)]
        [Display(Name = "Case Name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(typeof(decimal), PriceMinValue, PriceMaxValue, ErrorMessage = PriceRangeErrorMessage)]
        [Display(Name = "Case Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Display(Name = "Case Size")]
        public int CaseSize { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Display(Name = "Motherboard Form Factor in Case")]
        [Range(FormFactorMinValue, FormFactorMaxValue)]
        public int FormFactor { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Display(Name = "Case Max Graphic Card Length(in mm)")]
        [Range(GpuLengthMinValue, GpuLengthMaxValue)]
        public int MaxGpuLength { get; set; }

        [Display(Name = "Case Max Air CPU Cooler Height(in mm)")]
        [Range(typeof(double), MinCpuCoolerHeight, MaxCpuCoolerHeight)]
        public double MaxAirCpuCoolerHeight { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Display(Name = "Case PSU Factor")]
        [Range(PsuFactorMinValue, PsuFactorMaxValue)]
        public int PsuFactor { get; set; } 

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Url]
        [Display(Name = "Case Image Link")]
        [StringLength(UrlMaxLength, MinimumLength = UrlMinLength, ErrorMessage = UrlLengthErrorMessage)]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Display(Name = "Max Storage Devices in Case")]
        [Range(StorageSlotsMinValue, StorageSlotsMaxValue)]
        public int MaxStorageDevices { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Display(Name = "Max Radiator Length(in mm) in Case")]
        [Range(RadiatorLengthMinValue, RadiatorLengthMaxValue)]
        public int MaxRadiatorLength { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Display(Name = "Description")]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = DescriptionLengthErrorMessage)]
        public string Description { get; set; } = null!;
    }
}
