namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static PCHCB.Common.EntityValidationConstants.Component;

    /// <summary>
    /// Pc Configuration
    /// </summary>
    public class PcConfiguration
    {
        /// <summary>
        /// PC Configuration Id in app's database
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Saved PC Configuration Name
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// PC Configuration Price
        /// </summary>
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        /// <summary>
        /// PC Configuration Date of Creation
        /// </summary>
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public Guid? BuilderId { get; set; }

        public virtual ApplicationUser? Builder { get; set; } 

        public ICollection<ConfigurationHardware> ConfigurationHardwares { get; set; } = new HashSet<ConfigurationHardware>();
    }
}
