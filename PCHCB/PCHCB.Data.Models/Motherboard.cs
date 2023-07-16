namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using PCHCB.Data.Models.Enums;

    using static PCHCB.Common.EntityValidationConstants.Component;

    /// <summary>
    /// Motherboard Component
    /// </summary>
    public class Motherboard
    {
        /// <summary>
        /// Motherboard Id in app's database
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Motherboard Name
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Motherboard Price
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        /// <summary>
        /// Motherboard Form Factor Type (mITX, mATX, ATX, eATX)
        /// </summary>
        [Required]
        public MbFormFactor FormFactor { get; set; }

        /// <summary>
        /// Motherboard CPU Socket Type (AM4, LGA1200, etc.)
        /// </summary>
        [Required]
        public string Socket { get; set; } = null!;

        /// <summary>
        /// Motherboard Chipset Type (B450, Z490, etc.)
        /// </summary>
        [Required]
        public string Chipset { get; set; } = null!;

        /// <summary>
        /// Motherboard Memory Type (DDR4, etc.)
        /// </summary>
        [Required]
        public RamType RamType { get; set; }

        /// <summary>
        /// Motherboard Memory Slots (2, 4, etc.)
        /// </summary>
        [Required]
        public int RamSlots { get; set; }

        /// <summary>
        /// Motherboard Maximum Memory Capacity (in GB)
        /// </summary>
        [Required]
        public int RamCapacity { get; set; }

        /// <summary>
        /// Motherboard Sata Slots (2, 4, etc.)
        /// </summary>
        [Required]
        public int SataSlots { get; set; }

        /// <summary>
        /// Motherboard PCIE Type (3.0, 4.0, etc.)
        /// </summary>
        [Required]
        public InterfaceType PcieType { get; set; }

        /// <summary>
        /// Motherboard PCIE Slots (2, 4, etc.)
        /// </summary>
        [Required]
        public int PcieSlots { get; set; }

        /// <summary>
        /// Motherboard M.2/NVME Slots (0, 1, 2, etc.)
        /// </summary>
        [Required]
        public int M2Slots { get; set; }

        /// <summary>
        /// Motherboard Image Url
        /// </summary>
        [Required]
        [MaxLength(UrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        /// <summary>
        /// Motherboard Additional Description/Notes
        /// </summary>
        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// Motherboard Added On Date 
        /// </summary>
        public DateTime AddedOn { get; set; } = DateTime.UtcNow;

        public Guid ProviderId { get; set; }

        public virtual Provider Provider { get; set; } = null!;

        public virtual ICollection<ConfigurationHardware> ConfigurationHardwares { get; set; } = new HashSet<ConfigurationHardware>();
    }
}
