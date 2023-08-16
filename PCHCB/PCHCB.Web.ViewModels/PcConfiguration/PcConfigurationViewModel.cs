namespace PCHCB.Web.ViewModels.PcConfiguration
{
    using PCHCB.Web.ViewModels.Contracts;

    using System.ComponentModel.DataAnnotations;

    using static PCHCB.Common.EntityValidationConstants.PcConfiguration;
    using static PCHCB.Common.InputValidationDataMessages.General;

    /// <summary>
    /// Pc Configuration Short Info Model
    /// </summary>
    public class PcConfigurationViewModel : IProtectedUrlsModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(PcNameMaxLength, MinimumLength = PcNameMinLength, ErrorMessage = NameLengthErrorMessage)]
        [Display(Name = "Name")]
        public string Name { get; set; } = null!;

        [Display(Name = "Price")]
        public decimal Price { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
