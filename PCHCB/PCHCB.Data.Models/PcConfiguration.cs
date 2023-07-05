namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static PCHCB.Common.EntityValidationConstants.Component;
    using static PCHCB.Common.EntityValidationConstants.PcConfiguration;

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

        public int CaseId { get; set; }
        public Case Case { get; set; } = null!;

        public int CoolerId { get; set; }
        public Cooler Cooler { get; set; } = null!;

        public int CpuId { get; set; }
        public Cpu Cpu { get; set; } = null!;

        public int StorageId { get; set; }
        public Storage Storage { get; set; } = null!;

        public int RamId { get; set; }
        public Ram Ram { get; set; } = null!;

        public int MotherboardId { get; set; }
        public Motherboard Motherboard { get; set; } = null!;

        public int GpuId { get; set; }
        public Gpu Gpu { get; set; } = null!;

        public int PsuId { get; set; }
        public Psu Psu { get; set; } = null!;
    }
}
