namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Psu
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int Wattage { get; set; } // Configuration compatibility check

        [Required]
        public string Factor { get; set; } = null!; // Case compatibility check

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public bool NvidiaConnector { get; set; } // Gpu compatibility check

        public string Description { get; set; } = null!;
    }
}
