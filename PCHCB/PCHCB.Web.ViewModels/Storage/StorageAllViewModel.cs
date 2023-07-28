namespace PCHCB.Web.ViewModels.Storage
{
    /// <summary>
    /// Short info about Storage
    /// </summary>
    public class StorageAllViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = null!;
    }
}
