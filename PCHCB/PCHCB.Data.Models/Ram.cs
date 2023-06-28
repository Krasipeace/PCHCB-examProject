namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Ram
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public RamType Type { get; set; } // mb compatibility check

        [Required]
        public int Frequency { get; set; } // cpu compatibility check

        [Required]
        public int Capacity { get; set; }

        [Required]
        public string Height { get; set; } = null!; // air cooler compatibility check 

        [Required]
        public string ModelNumber { get; set; } = null!; // mb compatibility check

        [Required]
        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;

        // public virtual Ram Rams { get; set; } = null!;
    }

    public enum RamType
    {
        DDR3 = 0,
        DDR4 = 1,
        DDR5 = 2
    }
}
