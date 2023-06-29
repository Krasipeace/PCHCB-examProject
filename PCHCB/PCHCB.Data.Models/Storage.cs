namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using PCHCB.Data.Models.Enums;

    using static PCHCB.Common.EntityValidationConstants.Component;

    /// <summary>
    /// Storage Device
    /// </summary>
    public class Storage
    {
        /// <summary>
        /// Storage Device Id in app's database
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Storage Device Name
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Storage Device Price
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Storage Device Capacity in MB
        /// </summary>
        [Required]
        public int Capacity { get; set; }

        /// <summary>
        /// Storage Device Type
        /// </summary>
        [Required]
        public StorageType Type { get; set; }

        /// <summary>
        /// Storage Device Image Url
        /// </summary>
        [Required]
        [MaxLength(UrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        /// <summary>
        /// Storage Device Additional Description/Notes
        /// </summary>
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// Storage Added On Date 
        /// </summary>
        public DateTime AddedOn { get; set; }

        public int PcConfigurationId { get; set; }

        public virtual PcConfiguration PcConfiguration { get; set; } = null!;

        public Guid ProviderId { get; set; }

        public virtual Provider Provider { get; set; } = null!;
    }
}
