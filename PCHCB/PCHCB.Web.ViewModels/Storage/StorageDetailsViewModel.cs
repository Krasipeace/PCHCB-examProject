namespace PCHCB.Web.ViewModels.Storage
{
    using PCHCB.Web.ViewModels.Provider;

    /// <summary>
    /// Full info about Storage
    /// </summary>
    public class StorageDetailsViewModel : StorageAllViewModel
    {
        public int Capacity { get; set; }

        public int Type { get; set; }

        public string Description { get; set; } = null!;

        public ProviderInfoViewModel Provider { get; set; } = null!;
    }
}
