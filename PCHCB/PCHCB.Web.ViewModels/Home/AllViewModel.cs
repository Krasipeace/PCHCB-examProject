namespace PCHCB.Web.ViewModels.Home
{
    using System.Collections.Generic;

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

        public IEnumerable<CaseAllViewModel> Cases { get; set; } = null!;
        public IEnumerable<CoolerAllViewModel> Coolers { get; set; } = null!;
        public IEnumerable<CpuAllViewModel> Cpus { get; set; } = null!;
        public IEnumerable<GpuAllViewModel> Gpus { get; set; } = null!;
        public IEnumerable<MotherboardAllViewModel> Motherboards { get; set; } = null!;
        public IEnumerable<PsuAllViewModel> Psus { get; set; } = null!;
        public IEnumerable<RamAllViewModel> Rams { get; set; } = null!;
        public IEnumerable<StorageAllViewModel> Storages { get; set; } = null!;
    }
}
