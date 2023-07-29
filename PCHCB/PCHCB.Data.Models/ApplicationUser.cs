namespace PCHCB.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    using System.ComponentModel.DataAnnotations;

    using static PCHCB.Common.EntityValidationConstants.User;

    /// <summary>
    /// Custom User Class
    /// </summary>
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
            this.SavedConfigurations = new HashSet<PcConfiguration>();
        }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        /// <summary>
        /// User's Saved PC Configurations
        /// </summary>
        public virtual ICollection<PcConfiguration> SavedConfigurations { get; set; }
    }
}
