namespace PCHCB.Web.ViewModels.Case
{
    /// <summary>
    /// Short info about Case
    /// </summary>
    public class CaseAllViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
