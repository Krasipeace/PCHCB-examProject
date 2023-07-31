namespace PCHCB.Web.ViewModels.Psu
{
    /// <summary>
    /// Short info about PSU
    /// </summary>
    public class PsuAllViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
