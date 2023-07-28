namespace PCHCB.Web.ViewModels.Cpu
{
    /// <summary>
    /// Short info about CPU
    /// </summary>
    public class CpuAllViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = null!;
    }
}
