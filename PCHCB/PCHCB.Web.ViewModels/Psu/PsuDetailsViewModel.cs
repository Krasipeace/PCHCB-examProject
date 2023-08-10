namespace PCHCB.Web.ViewModels.Psu
{
    using PCHCB.Web.ViewModels.PcConfiguration;
    using PCHCB.Web.ViewModels.Provider;

    /// <summary>
    /// Full info about PSU
    /// </summary>
    public class PsuDetailsViewModel : PsuAllViewModel
    {
        public int Wattage { get; set; }

        public int Factor { get; set; }

        public bool NvidiaConnector { get; set; }

        public ProviderInfoViewModel Provider { get; set; } = null!;

        public AssembleConfigurationFormModel Assemble { get; set; } = null!;
    }
}
