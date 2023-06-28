namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Cpu
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Socket { get; set; } = null!; // compatibility check with mb

        [Required]
        public int Cores { get; set; }

        [Required]
        public int Threads { get; set; }

        [Required]
        public int Frequency { get; set; }

        [Required]
        public int TurboFrequency { get; set; }

        [Required]
        public int Cache { get; set; }

        [Required]
        public int Tdp { get; set; } // compatibility check with cooler's rating(TDP)

        [Required]
        public int RamFrequency { get; set; } // compatibility check with ram

        [Required]
        public string RamType { get; set; } = null!; // compatibility check with ram

        [Required]
        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;

        //public virtual Cpu Cpus { get; set; } = null!;
    }
}
