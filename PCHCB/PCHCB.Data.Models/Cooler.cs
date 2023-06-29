namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;

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
        public List<string> Compatibility { get; set; } = null!;

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
        [MaxLength(CpuMaxHeight)]
        public int CoolerHeight { get; set; } // case check for cooler height

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
        public DateTime AddedOn { get; set; }

        public int PcConfigurationId { get; set; }

        public virtual PcConfiguration PcConfiguration { get; set; } = null!;

        public Guid ProviderId { get; set; }

        public virtual Provider Provider { get; set; } = null!;
    }
}
