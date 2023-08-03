namespace PCHCB.Web.ViewModels.PcConfiguration
{
    public class SaveConfigurationFormModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
