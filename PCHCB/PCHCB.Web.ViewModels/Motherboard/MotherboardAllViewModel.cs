namespace PCHCB.Web.ViewModels.Motherboard
{
    /// <summary>
    /// Short info about Motherboard
    /// </summary>
    public class MotherboardAllViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
