namespace PCHCB.Web.ViewModels.Ram
{
    public class RamDetailsViewModel : RamAllViewModel
    {
        public int Type { get; set; }

        public int Frequency { get; set; }

        public int Capacity { get; set; }

        public double Height { get; set; }

        public string ModelNumber { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
