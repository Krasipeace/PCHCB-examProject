namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using PCHCB.Data.Models.Enums;

    using static PCHCB.Common.EntityValidationConstants.Component;

    /// <summary>
    /// CPU Component
    /// </summary>
    public class Cpu
    {
        /// <summary>
        /// CPU Id in app's database
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// CPU Name
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// CPU Price
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        /// <summary>
        /// CPU Socket Type (AM4, LGA1200, etc.)
        /// </summary>
        [Required]
        public string Socket { get; set; } = null!;

        /// <summary>
        /// CPU Physical Cores
        /// </summary>
        [Required]
        public int Cores { get; set; }

        /// <summary>
        /// CPU Logical Cores
        /// </summary>
        [Required]
        public int Threads { get; set; }

        /// <summary>
        /// CPU Base Frequency
        /// </summary>
        [Required]
        public int Frequency { get; set; }

        /// <summary>
        /// CPU Turbo Frequency
        /// </summary>
        [Required]
        public int TurboFrequency { get; set; }

        /// <summary>
        /// CPU Cache Size
        /// </summary>
        [Required]
        public int Cache { get; set; }

        /// <summary>
        /// CPU Thermal Design Power
        /// </summary>
        [Required]
        public int Tdp { get; set; }

        /// <summary>
        /// CPU RAM Frequency
        /// </summary>
        [Required]
        public int RamFrequency { get; set; }

        /// <summary>
        /// CPU RAM Type (DDR4, DDR5, etc.)
        /// </summary>
        [Required]
        public RamType RamType { get; set; }

        /// <summary>
        /// CPU Image URL
        /// </summary>
        [Required]
        [MaxLength(UrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        /// <summary>
        /// CPU Additional Description/Notes
        /// </summary>
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// CPU Added On Date 
        /// </summary>
        public DateTime AddedOn { get; set; } = DateTime.UtcNow;

        public Guid ProviderId { get; set; }

        public virtual Provider Provider { get; set; } = null!;

        public virtual PcConfiguration PcConfiguration { get; set; } = null!;
    }
}
