namespace PCHCB.Web.ViewModels.Storage
{
    using PCHCB.Web.ViewModels.PcConfiguration;
    using PCHCB.Web.ViewModels.Provider;

    /// <summary>
    /// Full info about Storage
    /// </summary>
    public class StorageDetailsViewModel : StorageAllViewModel
    {
        public int Capacity { get; set; }

        public int Type { get; set; }

        public ProviderInfoViewModel Provider { get; set; } = null!;

        public AssembleConfigurationFormModel Assemble { get; set; } = null!;
    }
}
