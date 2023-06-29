namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using PCHCB.Data.Models.Enums;

    using static PCHCB.Common.EntityValidationConstants.Component;

    /// <summary>
    /// Power Supply Unit 
    /// </summary>
    public class Psu
    {
        /// <summary>
        /// Power Supply Unit Id in app's database
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// PSU name
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// PSU Price
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Psu Power Wattage
        /// </summary>
        [Required]
        public int Wattage { get; set; }

        /// <summary>
        /// PSU Factor Type
        /// </summary>
        [Required]
        public PsuFactor Factor { get; set; }

        /// <summary>
        /// PSU Image Url
        /// </summary>
        [Required]
        [MaxLength(UrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        /// <summary>
        /// New Gen Nvidia Connection Possibility (No/Yes)
        /// </summary>
        [Required]
        public NvidiaConnector NvidiaConnector { get; set; }

        /// <summary>
        /// PSU Additional Description/Notes
        /// </summary>
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// PSU Added On Date 
        /// </summary>
        public DateTime AddedOn { get; set; }

        public int PcConfigurationId { get; set; }

        public virtual PcConfiguration PcConfiguration { get; set; } = null!;

        public Guid ProviderId { get; set; }

        public virtual Provider Provider { get; set; } = null!;
    }
}
