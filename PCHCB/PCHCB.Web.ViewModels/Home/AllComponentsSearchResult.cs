namespace PCHCB.Web.ViewModels.Home
{
    public class AllComponentsSearchResult
    {
        public AllComponentsSearchResult()
        {
            AllComponents = new HashSet<AllViewModel>();
            Cases = new HashSet<AllViewModel>();
            Cpus = new HashSet<AllViewModel>();
            Gpus = new HashSet<AllViewModel>();
            Coolers = new HashSet<AllViewModel>();
            Motherboards = new HashSet<AllViewModel>();
            Rams = new HashSet<AllViewModel>();
            Storages = new HashSet<AllViewModel>();
            Psus = new HashSet<AllViewModel>();
        }

        public int TotalComponents { get; set; }

        public IEnumerable<AllViewModel> AllComponents { get; set; }

        public IEnumerable<AllViewModel> Cases { get; set; }

        public IEnumerable<AllViewModel> Cpus { get; set; }

        public IEnumerable<AllViewModel> Gpus { get; set; }

        public IEnumerable<AllViewModel> Coolers { get; set; }

        public IEnumerable<AllViewModel> Motherboards { get; set; }

        public IEnumerable<AllViewModel> Rams { get; set; }

        public IEnumerable<AllViewModel> Storages { get; set; }

        public IEnumerable<AllViewModel> Psus { get; set; }
    }
}
