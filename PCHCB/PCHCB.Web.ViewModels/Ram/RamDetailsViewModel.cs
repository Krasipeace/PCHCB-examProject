namespace PCHCB.Web.ViewModels.Ram
{
    using PCHCB.Web.ViewModels.Provider;

    /// <summary>
    /// Full info about RAM
    /// </summary>
    public class RamDetailsViewModel : RamAllViewModel
    {
        public int Type { get; set; }

        public int Frequency { get; set; }

        public int Capacity { get; set; }

        public double Height { get; set; }

        public string ModelNumber { get; set; } = null!;

        public ProviderInfoViewModel Provider { get; set; } = null!;
    }
}
