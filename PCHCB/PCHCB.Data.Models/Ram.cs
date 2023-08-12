namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using PCHCB.Data.Models.Enums;

    using static PCHCB.Common.EntityValidationConstants.Component;
    using static PCHCB.Common.EntityValidationConstants.Ram;

    /// <summary>
    /// Memory Stick
    /// </summary>
    public class Ram
    {
        /// <summary>
        /// Memory Stick Id in app's database
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Memory Stick Name
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// RAM Price
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        /// <summary>
        /// RAM Type
        /// </summary>
        [Required]
        public RamType Type { get; set; }

        /// <summary>
        /// RAM Frequency
        /// </summary>
        [Required]
        public int Frequency { get; set; }

        /// <summary>
        /// RAM Capacity
        /// </summary>
        [Required]
        public int Capacity { get; set; }

        /// <summary>
        /// Ram Height in mm (Air Cooler Compatibility)
        /// </summary>
        [Required]
        public double Height { get; set; }

        /// <summary>
        /// Production Unique Model Number (MB Compatibility)
        /// </summary>
        [Required]
        [MaxLength(ModelNumberMaxLengthValue)]
        public string ModelNumber { get; set; } = null!;

        /// <summary>
        /// Image Url of Memory Stick(s)
        /// </summary>
        [Required]
        [MaxLength(UrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        /// <summary>
        /// Memory Stick Additional Description/Notes
        /// </summary>
        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// RAM Added On Date 
        /// </summary>
        public DateTime AddedOn { get; set; } = DateTime.UtcNow;

        public Guid ProviderId { get; set; }

        public virtual Provider Provider { get; set; } = null!;

        public virtual ICollection<ConfigurationHardware> ConfigurationHardwares { get; set; } = new HashSet<ConfigurationHardware>();
    }
}
