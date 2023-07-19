namespace PCHCB.Web.ViewModels.Gpu
{
    using System.ComponentModel.DataAnnotations;

    using static PCHCB.Common.EntityValidationConstants.Component;
    using static PCHCB.Common.EntityValidationConstants.Gpu;
    using static PCHCB.Common.InputValidationDataMessages.General;
    using static PCHCB.Common.InputValidationDataMessages.Gpu;

    public class GpuFormModel
    {
        [Required(ErrorMessage = RequiredFieldMessage)]
        [Display(Name = "Graphic Card Name")]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = NameLengthErrorMessage)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(typeof(decimal), PriceMinValue, PriceMaxValue, ErrorMessage = PriceRangeErrorMessage)]
        [Display(Name = "GPU Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(MemoryMinValue, MemoryMaxValue, ErrorMessage = MemoryRangeErrorMessage)]
        [Display(Name = "GPU Memory (in GB)")]
        public int Memory { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(InterfaceMinValue, InterfaceMaxValue, ErrorMessage = InterfaceRangeErrorMessage)]
        [Display(Name = "PCI-e Type")]
        public int Interface { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(typeof(double), LengthMinValue, LengthMaxValue, ErrorMessage = LengthRangeErrorMessage)]
        [Display(Name = "GPU Length (in mm)")]
        public double Length { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(typeof(double), SlotsMinValue, SlotsMaxValue, ErrorMessage = SlotsRangeErrorMessage)]
        [Display(Name = "GPU Width (Slots Required)")]
        public double SlotsRequired { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(PowerConsumptionMinValue, PowerConsumptionMaxValue, ErrorMessage = PowerConsumptionRangeErrorMessage)]
        [Display(Name = "Power Consumption (in Watts)")]
        public int PowerConsumption { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Url]
        [Display(Name = "Image Link")]
        [StringLength(UrlMaxLength, MinimumLength = UrlMinLength, ErrorMessage = UrlLengthErrorMessage)]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Display(Name = "New Generation PSU Nvidia Connector")]
        public bool NvidiaConnector { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Display(Name = "Description")]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = DescriptionLengthErrorMessage)]
        public string Description { get; set; } = null!;
    }
}
