namespace PCHCB.Web.ViewModels.Psu
{
    using PCHCB.Web.ViewModels.Provider;

    /// <summary>
    /// Full info about PSU
    /// </summary>
    public class PsuDetailsViewModel : PsuAllViewModel
    {
        public int Wattage { get; set; }

        public int Factor { get; set; }

        public bool NvidiaConnector { get; set; }

        public string Description { get; set; } = null!;

        public ProviderInfoViewModel Provider { get; set; } = null!;
    }
}
