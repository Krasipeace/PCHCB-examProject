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

        public ICollection<Case> Cases { get; set; } = new HashSet<Case>();

        public ICollection<Cpu> Cpus { get; set; } = new HashSet<Cpu>();

        public ICollection<Cooler> Coolers { get; set; } = new HashSet<Cooler>();

        public ICollection<Motherboard> Motherboards { get; set; } = new HashSet<Motherboard>();

        public ICollection<Ram> Rams { get; set; } = new HashSet<Ram>();

        public ICollection<Storage> Storages { get; set; } = new HashSet<Storage>();

        public ICollection<Gpu> Gpus { get; set; } = new HashSet<Gpu>();

        public ICollection<Psu> Psus { get; set; } = new HashSet<Psu>();

        public ICollection<ConfigurationHardware> ConfigurationHardwares { get; set; } = new HashSet<ConfigurationHardware>();
    }
}
