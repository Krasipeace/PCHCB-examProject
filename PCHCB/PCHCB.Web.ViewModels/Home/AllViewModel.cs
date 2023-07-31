namespace PCHCB.Web.ViewModels.Home
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
    /// ViewModel for Home/All
    /// </summary>
    public class AllViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;

        public DateTime AddedOn { get; set; }

        public string ProviderId { get; set; } = null!;

        public List<CaseAllViewModel> Cases { get; set; } = new List<CaseAllViewModel>();

        public List<CpuAllViewModel> Cpus { get; set; } = new List<CpuAllViewModel>();

        public List<CoolerAllViewModel> Coolers { get; set; } = new List<CoolerAllViewModel>();

        public List<GpuAllViewModel> Gpus { get; set; } = new List<GpuAllViewModel>();

        public List<MotherboardAllViewModel> Motherboards { get; set; } = new List<MotherboardAllViewModel>();

        public List<PsuAllViewModel> Psus { get; set; } = new List<PsuAllViewModel>();

        public List<RamAllViewModel> Rams { get; set; } = new List<RamAllViewModel>();

        public List<StorageAllViewModel> Storages { get; set; } = new List<StorageAllViewModel>();
    }
}
