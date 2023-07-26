namespace PCHCB.Web.ViewModels.Storage
{
    public class StorageDetailsViewModel :StorageAllViewModel
    {
        public int Capacity { get; set; }

        public int Type { get; set; }

        public string Description { get; set; } = null!;
    }
}
