namespace PCHCB.Web.ViewModels.Motherboard
{
    using PCHCB.Web.ViewModels.Contracts;

    /// <summary>
    /// Short info about Motherboard
    /// </summary>
    public class MotherboardAllViewModel : IProtectedUrlsModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Parameter => Name;
    }
}
