namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Motherboard
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public FactorType FormFactor { get; set; } // Case Compatibility check

        [Required]
        public string Socket { get; set; } = null!; // Cpu compatibility check

        [Required]
        public string Chipset { get; set; } = null!; // Cpu compatibility check

        [Required]
        public string RamType { get; set; } = null!; // Ram compatibility check

        [Required]
        public int RamSlots { get; set; } // Ram compatibility check

        [Required]
        public int RamCapacity { get; set; } // Ram compatibility check

        [Required]
        public int SataSlots { get; set; } // Storage compatibility check    

        [Required]
        public string PcieType { get; set; } = null!; // Gpu compatibility check

        [Required]
        public int PcieSlots { get; set; } // Gpu compatibility check

        [Required]
        public int M2Slots { get; set; } // m.2/nvme compatibility check

        [Required]
        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;
    }

    public enum FactorType
    {
        mITX = 0,
        mATX = 1,
        ATX = 2,
        eATX = 3
    }
}
