namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Cooler
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public CoolerType Type { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        public List<string> Compatibility { get; set; } = null!;

        public RadiatorSize RadiatorSize { get; set; }

        public int FanSize { get; set; }

        public int CoolerHeight { get; set; } // case check for cooler height

        [Required]
        public int Tdp { get; set; } // cpu check for tdp

        public int Width { get; set; } // check for ram clearance

        public string Description { get; set; } = null!;
    }

    public enum CoolerType
    {
        Air,
        Water
    }

    public enum RadiatorSize
    {
        _120 = 0,
        _240 = 1,
        _360 = 2
    }
}
