namespace PCHCB.Web.ViewModels.PcConfiguration
{
    using PCHCB.Web.ViewModels.Case;
    using PCHCB.Web.ViewModels.Cooler;
    using PCHCB.Web.ViewModels.Cpu;
    using PCHCB.Web.ViewModels.Gpu;
    using PCHCB.Web.ViewModels.Motherboard;
    using PCHCB.Web.ViewModels.Psu;
    using PCHCB.Web.ViewModels.Ram;
    using PCHCB.Web.ViewModels.Storage;

    /// <summary>
    /// Assemble Pc Configuration Form Model
    /// </summary>
    public class AssembleConfigurationFormModel
    {
        public int PcConfigurationId { get; set; }

        public int CaseId { get; set; }

        public int CoolerId { get; set; }

        public int CpuId { get; set; }

        public int GpuId { get; set; }

        public int MotherboardId { get; set; }

        public int PsuId { get; set; }

        public int RamId { get; set; }

        public int StorageId { get; set; }

        public CaseDetailsViewModel Case { get; set; } = null!;

        public CoolerDetailsViewModel Cooler { get; set; } = null!;

        public CpuDetailsViewModel Cpu { get; set; } = null!;

        public GpuDetailsViewModel Gpu { get; set; } = null!;

        public MotherboardDetailsViewModel Motherboard { get; set; } = null!;

        public PsuDetailsViewModel Psu { get; set; } = null!;

        public RamDetailsViewModel Ram { get; set; } = null!;

        public StorageDetailsViewModel Storage { get; set; } = null!;

        public SaveConfigurationFormModel SaveBuild { get; set; } = null!;
    }
}
