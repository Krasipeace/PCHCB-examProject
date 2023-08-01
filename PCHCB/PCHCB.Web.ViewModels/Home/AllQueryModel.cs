namespace PCHCB.Web.ViewModels.Home
{
    using PCHCB.Web.ViewModels.Enums;

    using System.ComponentModel.DataAnnotations;

    using static PCHCB.Common.SearchEngine;

    public class AllQueryModel
    {
        public AllQueryModel()
        {
            CurrentPage = DefaultPage;
            ComponentsPerPage = DefaultPerPage;

            Cases = new List<AllViewModel>();
            Coolers = new List<AllViewModel>();
            Cpus = new List<AllViewModel>();
            Gpus = new List<AllViewModel>();
            Motherboards = new List<AllViewModel>();
            Psus = new List<AllViewModel>();
            Rams = new List<AllViewModel>();
            Storages = new List<AllViewModel>();
        }

        [Display(Name = "Search")]
        public string SearchTerm { get; set; } = null!;

        public int CurrentPage { get; set; }

        [Display(Name = "Components per page")]
        public int ComponentsPerPage { get; set; }

        public int TotalComponents { get; set; }

        [Display(Name = "Sort by")]
        public GeneralSorting Sorting { get; set; }

        public IEnumerable<AllViewModel> Cases { get; set; } 

        public IEnumerable<AllViewModel> Coolers { get; set; }

        public IEnumerable<AllViewModel> Cpus { get; set; }

        public IEnumerable<AllViewModel> Gpus { get; set; }

        public IEnumerable<AllViewModel> Motherboards { get; set; }

        public IEnumerable<AllViewModel> Psus { get; set; } 

        public IEnumerable<AllViewModel> Rams { get; set; }

        public IEnumerable<AllViewModel> Storages { get; set; }
    }
}
