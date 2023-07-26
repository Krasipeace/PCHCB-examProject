namespace PCHCB.Web.ViewModels.Psu
{
    public class PsuDetailsViewModel : PsuAllViewModel
    {
        public int Wattage { get; set; }

        public int Factor { get; set; }

        public bool NvidiaConnector { get; set; }

        public string Description { get; set; } = null!;
    }
}
