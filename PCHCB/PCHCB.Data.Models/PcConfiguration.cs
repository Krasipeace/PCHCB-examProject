namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static PCHCB.Common.EntityValidationConstants.Component;

    // applicationUser's PC build configuration
    public class PcConfiguration
    {
        public PcConfiguration()
        {
            this.Storages = new HashSet<Storage>();
            this.Rams = new HashSet<Ram>();
            this.Motherboards = new HashSet<Motherboard>();
            this.Gpus = new HashSet<Gpu>();
            this.Cpus = new HashSet<Cpu>();
            this.Psus = new HashSet<Psu>();
            this.Cases = new HashSet<Case>();
            this.Coolers = new HashSet<Cooler>();
        }

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
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// PC Configuration Date of Creation
        /// </summary>
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<Cpu> Cpus { get; set; }

        public virtual ICollection<Motherboard> Motherboards { get; set; }

        public virtual ICollection<Ram> Rams { get; set; }

        public virtual ICollection<Storage> Storages { get; set; }

        public virtual ICollection<Gpu> Gpus { get; set; }

        public virtual ICollection<Psu> Psus { get; set; }

        public virtual ICollection<Case> Cases { get; set; }

        public virtual ICollection<Cooler> Coolers { get; set; }
    }
}
