﻿namespace PCHCB.Data.Models
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
            this.SavedConfigurations = new HashSet<PcConfiguration>();
        }

        /// <summary>
        /// User's Saved PC Configurations
        /// </summary>
        public virtual ICollection<PcConfiguration> SavedConfigurations { get; set; }
    }
}
