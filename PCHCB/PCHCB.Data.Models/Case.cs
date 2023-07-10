namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using PCHCB.Data.Models.Enums;

    using static PCHCB.Common.EntityValidationConstants.Component;

    /// <summary>
    /// PC Case Component
    /// </summary>
    public class Case
    {
        /// <summary>
        /// PC Case Id in app's database
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Case Name
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Case Price 
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        /// <summary>
        /// Case Size (Mini, Mid, Full)
        /// </summary>
        [Required]
        public CaseSize CaseSize { get; set; }

        /// <summary>
        /// Case Form Factor (ATX, mATX, etc.)
        /// </summary>
        [Required]
        public MbFormFactor FormFactor { get; set; }

        /// <summary>
        /// Case Max GPU Length (in mm)
        /// </summary>
        [Required]
        [MaxLength(GpuMaxLength)]
        public int MaxGpuLength { get; set; }

        /// <summary>
        /// Case Max Air CPU Cooler Height (in mm)
        /// </summary>
        [Required]
        [MaxLength(CpuMaxHeight)]
        public int MaxAirCpuCoolerHeight { get; set; }

        /// <summary>
        /// PSU Factor (ATX, SFX, etc.)
        /// </summary>
        [Required]
        public PsuFactor PsuFactor { get; set; }

        /// <summary>
        /// Case Image Url
        /// </summary>
        [Required]
        [MaxLength(UrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        /// <summary>
        /// Case Max Storage Device Slots (HDD, SSD, etc.)
        /// </summary>
        [Required]
        public int MaxStorageDevices { get; set; }

        /// <summary>
        /// Case Max Radiator Length for Water Cooling Solution (in mm)
        /// </summary>
        public int MaxRadiatorLength { get; set; }

        /// <summary>
        /// Case Additional Description/Notes
        /// </summary>
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// Case Added On Date 
        /// </summary>
        public DateTime AddedOn { get; set; } = DateTime.UtcNow;

        public Guid ProviderId { get; set; }

        public virtual Provider Provider { get; set; } = null!;

        public virtual ICollection<ConfigurationHardware> ConfigurationHardwares { get; set; } = new HashSet<ConfigurationHardware>();
    }
}
