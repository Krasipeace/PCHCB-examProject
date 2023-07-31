namespace PCHCB.Web.ViewModels.Gpu
{
    /// <summary>
    /// Short info about GPU
    /// </summary>
    public class GpuAllViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
