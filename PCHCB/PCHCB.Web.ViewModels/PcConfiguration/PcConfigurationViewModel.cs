namespace PCHCB.Web.ViewModels.PcConfiguration
{
    using PCHCB.Web.ViewModels.Home;

    /// <summary>
    /// Pc Configuration Short Info Model
    /// </summary>
    public class PcConfigurationViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
