namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using PCHCB.Data.Models.Enums;

    using static PCHCB.Common.EntityValidationConstants.Component;

    /// <summary>
    /// Memory Stick
    /// </summary>
    public class Ram
    {
        /// <summary>
        /// Memory Stick Id in app's database
        /// </summary>
        [Key]
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
        public string Height { get; set; } = null!;

        /// <summary>
        /// Production Unique Model Number (MB Compatibility)
        /// </summary>
        [Required]
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
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// RAM Added On Date 
        /// </summary>
        public DateTime AddedOn { get; set; }

        public int PcConfigurationId { get; set; }

        public virtual PcConfiguration PcConfiguration { get; set; } = null!;

        public Guid ProviderId { get; set; }

        public virtual Provider Provider { get; set; } = null!;
    }
}
