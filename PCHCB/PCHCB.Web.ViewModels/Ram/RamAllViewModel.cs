namespace PCHCB.Web.ViewModels.Ram
{
    /// <summary>
    /// Short info about RAM
    /// </summary>
    public class RamAllViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
