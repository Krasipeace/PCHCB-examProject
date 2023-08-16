namespace PCHCB.Web.ViewModels.PcConfiguration
{
    using PCHCB.Web.ViewModels.Case;
    using PCHCB.Web.ViewModels.Contracts;
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
    public class AssembleConfigurationFormModel : IProtectedUrlsModel
    {
        public int PcConfigurationId { get; set; }

        public string Name { get; set; } = null!;

        public int CaseId { get; set; }

        public int CoolerId { get; set; }

        public int CpuId { get; set; }

        public int GpuId { get; set; }

        public int MotherboardId { get; set; }

        public int PsuId { get; set; }

        public int RamId { get; set; }

        public int StorageId { get; set; }

        public List<CaseDetailsViewModel> Cases { get; set; } = new List<CaseDetailsViewModel>();

        public List<CpuDetailsViewModel> Cpus { get; set; } = new List<CpuDetailsViewModel>();

        public List<CoolerDetailsViewModel> Coolers { get; set; } = new List<CoolerDetailsViewModel>();

        public List<GpuDetailsViewModel> Gpus { get; set; } = new List<GpuDetailsViewModel>();

        public List<MotherboardDetailsViewModel> Motherboards { get; set; } = new List<MotherboardDetailsViewModel>();

        public List<PsuDetailsViewModel> Psus { get; set; } = new List<PsuDetailsViewModel>();

        public List<RamDetailsViewModel> Rams { get; set; } = new List<RamDetailsViewModel>();

        public List<StorageDetailsViewModel> Storages { get; set; } = new List<StorageDetailsViewModel>();
    }
}
