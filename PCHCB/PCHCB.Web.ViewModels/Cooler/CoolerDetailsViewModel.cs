namespace PCHCB.Web.ViewModels.Cooler
{
    using PCHCB.Web.ViewModels.Provider;

    /// <summary>
    /// Full info about Cooler
    /// </summary>
    public class CoolerDetailsViewModel : CoolerAllViewModel
    {
        public int Type { get; set; }

        public string Compatibility { get; set; } = null!;

        public int RadiatorSize { get; set; }

        public int FanSize { get; set; }

        public double CoolerHeight { get; set; }

        public int Tdp { get; set; }

        public int Width { get; set; }

        public string Description { get; set; } = null!;

        public ProviderInfoViewModel Provider { get; set; } = null!;
    }
}
