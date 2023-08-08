namespace PCHCB.Data.Models
{
    /// <summary>
    /// Table for relations between PcConfiguration and Hardware
    /// </summary>
    public class ConfigurationHardware
    {
        public int Id { get; set; }

        public int PcConfigurationId { get; set; }

        public PcConfiguration PcConfiguration { get; set; } = null!;

        public int CaseId { get; set; }

        public Case Case { get; set; } = null!;

        public int CpuId { get; set; }

        public Cpu Cpu { get; set; } = null!;

        public int CoolerId { get; set; }

        public Cooler Cooler { get; set; } = null!;

        public int GpuId { get; set; }

        public Gpu Gpu { get; set; } = null!;

        public int MotherboardId { get; set; }

        public Motherboard Motherboard { get; set; } = null!;

        public int PsuId { get; set; }

        public Psu Psu { get; set; } = null!;

        public int RamId { get; set; }

        public Ram Ram { get; set; } = null!;

        public int StorageId { get; set; }

        public Storage Storage { get; set; } = null!;
    }
}
