namespace PCHCB.Web.ViewModels.PcConfiguration
{
    using System.ComponentModel.DataAnnotations;

    using static PCHCB.Common.EntityValidationConstants.PcConfiguration;
    using static PCHCB.Common.InputValidationDataMessages.General;

    /// <summary>
    /// Pc Configuration Short Info Model
    /// </summary>
    public class PcConfigurationViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(PcNameMaxLength, MinimumLength = PcNameMinLength, ErrorMessage = NameLengthErrorMessage)]
        [Display(Name = "Configuration Name")]
        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
