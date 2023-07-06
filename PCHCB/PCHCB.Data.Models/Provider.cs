namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static PCHCB.Common.EntityValidationConstants.Component;
    using static PCHCB.Common.EntityValidationConstants.Provider;

    /// <summary>
    /// Hardware Provider User
    /// </summary>
    public class Provider
    {
        public Provider()
        {
            this.Id = Guid.NewGuid();
            this.ProviderCases = new HashSet<Case>();
            this.ProviderCoolers = new HashSet<Cooler>();
            this.ProviderCpus = new HashSet<Cpu>();
            this.ProviderGpus = new HashSet<Gpu>();
            this.ProviderMotherboards = new HashSet<Motherboard>();
            this.ProviderPsus = new HashSet<Psu>();
            this.ProviderRams = new HashSet<Ram>();
            this.ProviderStorages = new HashSet<Storage>();
        }

        [Key]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public virtual ApplicationUser User { get; set; } = null!;

        /// <summary>
        /// Provider's Web Page
        /// </summary>
        [Required]
        [MaxLength(UrlMaxLength)]
        public string WebPage { get; set; } = null!;

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        /// <summary>
        /// Provider's Logo
        /// </summary>
        [MaxLength(UrlMaxLength)]
        public string LogoUrl { get; set; } = null!;

        /// <summary>
        /// Provider's Description
        /// </summary>
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// Providers's Collection of Cpus
        /// </summary>
        public virtual ICollection<Cpu> ProviderCpus { get; set; } = null!;

        /// <summary>
        /// Providers's Collection of Gpus
        /// </summary>
        public virtual ICollection<Gpu> ProviderGpus { get; set; } = null!;

        /// <summary>
        /// Providers's Collection of Motherboards
        /// </summary>
        public virtual ICollection<Motherboard> ProviderMotherboards { get; set; } = null!;

        /// <summary>
        /// Provider's Collection of Memory Sticks
        /// </summary>
        public virtual ICollection<Ram> ProviderRams { get; set; } = null!;

        /// <summary>
        /// Provider's Collection of Storage Devices
        /// </summary>
        public virtual ICollection<Storage> ProviderStorages { get; set; } = null!;

        /// <summary>
        /// Provider's Collection of Power Supplies
        /// </summary>
        public virtual ICollection<Psu> ProviderPsus { get; set; } = null!;

        /// <summary>
        /// Provider's Collection of Pc Cases
        /// </summary>
        public virtual ICollection<Case> ProviderCases { get; set; } = null!;

        /// <summary>
        /// Provider's Collection of Coolers
        /// </summary>
        public virtual ICollection<Cooler> ProviderCoolers { get; set; } = null!;
    }
}
