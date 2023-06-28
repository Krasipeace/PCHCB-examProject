namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Case
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public CaseSize CaseSize { get; set; } // Case compatibility check

        [Required]
        public string FormFactor { get; set; } = null!; // Motherboard compatibility check

        [Required]
        public int MaxGpuLength { get; set; } // Gpu compatibility check

        [Required]
        public int MaxAirCpuCoolerHeight { get; set; } // Air cooler compatibility check

        [Required]
        public int FansDimensions { get; set; } // Fans compatibility check

        [Required]
        public int PsuFactor { get; set; } // Psu compatibility check

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public int MaxStorageDevices { get; set; } // Storage compatibility check

        public int MaxRadiatorLength { get; set; } // Cpu Water cooler Radiator compatibility check

        public string Description { get; set; } = null!;
    }
    
    public enum CaseSize
    {
        MiniTower = 0,
        MidTower = 1,
        FullTower = 2
    }
}
