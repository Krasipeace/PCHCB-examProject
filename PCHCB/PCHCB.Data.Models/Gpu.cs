namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using PCHCB.Data.Models.Enums;

    using static PCHCB.Common.EntityValidationConstants.Component;

    /// <summary>
    /// Graphical Processing Unit/Card
    /// </summary>
    public class Gpu
    {
        /// <summary>
        /// GPU Id in app's database
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// GPU name
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// GPU Price
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// GPU Memory in GB
        /// </summary>
        [Required]
        public int Memory { get; set; }

        /// <summary>
        /// GPU Interface Type (PCIe 3.0/4.0/5.0)
        /// </summary>
        [Required]
        public InterfaceType Interface { get; set; }

        /// <summary>
        /// GPU Length in mm
        /// </summary>
        [Required]
        public double Length { get; set; }

        /// <summary>
        /// GPU Width in taken Slots
        /// </summary>
        [Required]
        public double SlotsRequired { get; set; }

        /// <summary>
        /// GPU Power Consumption in Watts
        /// </summary>
        [Required]
        public int PowerConsumption { get; set; }

        /// <summary>
        /// GPU Image Url
        /// </summary>
        [Required]
        [MaxLength(UrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        /// <summary>
        /// Gpu New Gen Nvidia Connection Requirement
        /// </summary>
        [Required]
        public NvidiaConnector NvidiaConnector { get; set; }

        /// <summary>
        /// GPU Additional Description/Notes
        /// </summary>
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// GPU Added On Date 
        /// </summary>
        public DateTime AddedOn { get; set; }

        public int PcConfigurationId { get; set; }

        public virtual PcConfiguration PcConfiguration { get; set; } = null!;

        public Guid ProviderId { get; set; }

        public virtual Provider Provider { get; set; } = null!;
    }
}
