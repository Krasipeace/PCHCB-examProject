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
        [Range(FormFactorMinValue, FormFactorMaxValue)]
        [Display(Name = "Motherboard Form Factor in Case")]
        public int FormFactor { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(GpuLengthMinValue, GpuLengthMaxValue)]
        [Display(Name = "Case Max Graphic Card Length(in mm)")]
        public int MaxGpuLength { get; set; }

        [Range(typeof(double), MinCpuCoolerHeight, MaxCpuCoolerHeight)]
        [Display(Name = "Case Max Air CPU Cooler Height(in mm)")]
        public double MaxAirCpuCoolerHeight { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(PsuFactorMinValue, PsuFactorMaxValue)]
        [Display(Name = "Case PSU Factor")]
        public int PsuFactor { get; set; } 

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Url]
        [StringLength(UrlMaxLength, MinimumLength = UrlMinLength, ErrorMessage = UrlLengthErrorMessage)]
        [Display(Name = "Case Image Link")]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(StorageSlotsMinValue, StorageSlotsMaxValue)]
        [Display(Name = "Max Storage Devices in Case")]
        public int MaxStorageDevices { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(RadiatorLengthMinValue, RadiatorLengthMaxValue)]
        [Display(Name = "Max Radiator Length(in mm) in Case")]
        public int MaxRadiatorLength { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = DescriptionLengthErrorMessage)]
        [Display(Name = "Description")]
        public string Description { get; set; } = null!;
    }
}
