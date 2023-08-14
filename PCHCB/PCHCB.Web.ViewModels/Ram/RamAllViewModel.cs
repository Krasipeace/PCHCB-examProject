namespace PCHCB.Web.ViewModels.Ram
{
    using PCHCB.Web.ViewModels.Contracts;

    /// <summary>
    /// Short info about RAM
    /// </summary>
    public class RamAllViewModel : IProtectedUrlsModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Parameter => Name;
    }
}
