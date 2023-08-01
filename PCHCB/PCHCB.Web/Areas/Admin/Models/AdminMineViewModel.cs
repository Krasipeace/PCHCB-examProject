namespace PCHCB.Web.Areas.Admin.Models
{
    using PCHCB.Web.ViewModels.Home;

    public class AdminMineViewModel
    {
        public IEnumerable<AllViewModel> Cases { get; set; } = null!;

        public IEnumerable<AllViewModel> Coolers { get; set; } = null!;

        public IEnumerable<AllViewModel> Cpus { get; set; } = null!;

        public IEnumerable<AllViewModel> Gpus { get; set; } = null!;

        public IEnumerable<AllViewModel> Motherboards { get; set; } = null!;

        public IEnumerable<AllViewModel> Psus { get; set; } = null!;

        public IEnumerable<AllViewModel> Rams { get; set; } = null!;

        public IEnumerable<AllViewModel> Storages { get; set; } = null!;
    }
}
