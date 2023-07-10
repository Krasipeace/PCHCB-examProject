namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

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
        [Column(TypeName = "decimal(18,2)")]
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
        public bool NvidiaConnector { get; set; }

        /// <summary>
        /// PSU Additional Description/Notes
        /// </summary>
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// PSU Added On Date 
        /// </summary>
        public DateTime AddedOn { get; set; } = DateTime.UtcNow;

        public Guid ProviderId { get; set; }

        public virtual Provider Provider { get; set; } = null!;

        public virtual ICollection<ConfigurationHardware> ConfigurationHardwares { get; set; } = new HashSet<ConfigurationHardware>();
    }
}
