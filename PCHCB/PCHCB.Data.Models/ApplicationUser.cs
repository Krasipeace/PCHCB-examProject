namespace PCHCB.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    /// <summary>
    /// Custom User Class
    /// </summary>
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
            this.PcConfigurations = new HashSet<PcConfiguration>();
        }

        public virtual ICollection<PcConfiguration> PcConfigurations { get; set; }
    }
}
