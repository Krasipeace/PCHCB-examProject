namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using PCHCB.Data.Models.Enums;

    using static PCHCB.Common.EntityValidationConstants.Component;

    /// <summary>
    /// CPU Cooler Component
    /// </summary>
    public class Cooler
    {
        /// <summary>
        /// Cooler Id in app's database
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Cooler Name
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Cooler Price
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        /// <summary>
        /// Cooler Type (Air, Water)
        /// </summary>
        [Required]
        public CoolerType Type { get; set; }

        /// <summary>
        /// Cooler Image Url
        /// </summary>
        [Required]
        [MaxLength(UrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        /// <summary>
        /// Cooler Compatibility List (CPU Sockets)
        /// </summary>
        [Required]
        [MaxLength(CompatibilityMaxLength)]
        public string Compatibility { get; set; } = null!;

        /// <summary>
        /// Cooler Radiator Size (Water Cooler)
        /// </summary>
        public RadiatorSize RadiatorSize { get; set; }

        /// <summary>
        /// Cooler Fan Size (Air Cooler)
        /// </summary>
        public int FanSize { get; set; }

        /// <summary>
        /// Cooler Height in mm
        /// </summary>
        public double CoolerHeight { get; set; } // case check for cooler height

        /// <summary>
        /// Cooler Thermal Design Power (TDP)
        /// </summary>
        [Required]
        public int Tdp { get; set; } // cpu check for tdp

        /// <summary>
        /// Cooler Width in mm (Air Cooler, RAM Clearance)
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Cooler Additional Description/Notes
        /// </summary>
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// Cooler Added On Date 
        /// </summary>
        public DateTime AddedOn { get; set; } = DateTime.UtcNow;

        public Guid ProviderId { get; set; }

        public virtual Provider Provider { get; set; } = null!;

        public virtual ICollection<ConfigurationHardware> ConfigurationHardwares { get; set; } = new HashSet<ConfigurationHardware>();
    }
}
