namespace PCHCB.Web.ViewModels.Provider
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
    /// Provider's view model about his components
    /// </summary>
    public class MineViewModel
    {
        public List<CaseAllViewModel> Cases { get; set; } = new List<CaseAllViewModel>();

        public List<CpuAllViewModel> Cpus { get; set; } = new List<CpuAllViewModel>();

        public List<CoolerAllViewModel> Coolers { get; set; } = new List<CoolerAllViewModel>();

        public List<GpuAllViewModel> Gpus { get; set; } = new List<GpuAllViewModel>();

        public List<MotherboardAllViewModel> Motherboards { get; set; } = new List<MotherboardAllViewModel>();

        public List<PsuAllViewModel> Psus { get; set; } = new List<PsuAllViewModel>();

        public List<RamAllViewModel> Rams { get; set; } = new List<RamAllViewModel>();

        public List<StorageAllViewModel> Storages { get; set; } = new List<StorageAllViewModel>();

        public CaseDetailsViewModel CaseDetails { get; set; } = new CaseDetailsViewModel();

    }
}
