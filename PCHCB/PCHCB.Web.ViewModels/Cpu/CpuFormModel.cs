namespace PCHCB.Web.ViewModels.Cpu
{
    using System.ComponentModel.DataAnnotations;

    using static PCHCB.Common.EntityValidationConstants.Component;
    using static PCHCB.Common.EntityValidationConstants.Cpu;
    using static PCHCB.Common.InputValidationDataMessages.General;
    using static PCHCB.Common.InputValidationDataMessages.Cpu;

    /// <summary>
    /// Create/Edit CPU 
    /// </summary>
    public class CpuFormModel
    {
        [Required(ErrorMessage = RequiredFieldMessage)]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = NameLengthErrorMessage)]
        [Display(Name = "Processor Name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(typeof(decimal), PriceMinValue, ExclusiveCpuMaxPrice, ErrorMessage = PriceRangeErrorMessage)]
        [Display(Name = "CPU Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [StringLength(SocketMaxLength, MinimumLength = SocketMinLength, ErrorMessage = CpuSocketLengthErrorMessage)]
        [Display(Name = "Socket Type")]
        public string Socket { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(CoresMinValue, CoresMaxValue, ErrorMessage = CoresRangeErrorMessage)]
        [Display(Name = "Physical Cores")]
        public int Cores { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(ThreadsMinValue, ThreadsMaxValue, ErrorMessage = ThreadsRangeErrorMessage)]
        [Display(Name = "Logical Cores")]
        public int Threads { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(FrequencyMinValue, FrequencyMaxValue, ErrorMessage = FrequencyRangeErrorMessage)]
        [Display(Name = "Base Frequency (in MHz")]
        public int Frequency { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(TurboFrequencyMinValue, TurboFrequencyMaxValue, ErrorMessage = TurboFrequencyRangeErrorMessage)]
        [Display(Name = "Turbo Frequency (in MHz)")]
        public int TurboFrequency { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(CacheMinValue, CacheMaxValue, ErrorMessage = CacheRangeErrorMessage)]
        [Display(Name = "Cache (in MB)")]
        public int Cache { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(TdpMinValue, TdpMaxValue, ErrorMessage = TdpRangeErrorMessage)]
        [Display(Name = "Thermal Design Point (in Watts)")]
        public int Tdp { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(RamFrequencyMinValue, RamFrequencyMaxValue, ErrorMessage = RamFrequencyRangeErrorMessage)]
        [Display(Name = "CPU Compatible RAM Frequency (in MHz)")]
        public int RamFrequency { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(RamTypeMinValue, RamTypeMaxValue, ErrorMessage = RamTypeRangeErrorMessage)]
        [Display(Name = "CPU Compatible RAM Type")]
        public int RamType { get; set; }

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
