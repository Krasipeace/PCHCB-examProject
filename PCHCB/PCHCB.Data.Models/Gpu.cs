namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Gpu
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int Memory { get; set; }

        [Required]
        public InterfaceType Interface { get; set; } // cpu/mb compatibility check

        [Required]
        public double Length { get; set; } // Case compatibility check

        [Required] 
        public double SlotsRequired { get; set; } 

        [Required]
        public int PowerConsumption { get; set; } // Psu compatibility check

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public bool IsNvidiaConnectorReq { get; set; } // Psu compatibility check

        public string Description { get; set; } = null!;
    }

    public enum InterfaceType
    {
        PCIExpress3 = 0,
        PCIExpress4 = 1,
        PCIExpress5 = 2
    }
}
