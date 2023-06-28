namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Hardware Provider
    /// </summary>
    public class Provider
    {
        public Provider()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public virtual ApplicationUser User { get; set; } = null!;

        public virtual ICollection<Cpu> Cpus { get; set; } = null!;

        public virtual ICollection<Gpu> Gpus { get; set; } = null!;

        public virtual ICollection<Motherboard> Motherboards { get; set; } = null!;

        public virtual ICollection<Ram> Rams { get; set; } = null!;

        public virtual ICollection<Storage> Storages { get; set; } = null!;

        public virtual ICollection<Psu> Psus { get; set; } = null!;

        public virtual ICollection<Case> Cases { get; set; } = null!;

        public virtual ICollection<Cooler> Coolers { get; set; } = null!;
    }
}
