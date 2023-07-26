namespace PCHCB.Web.ViewModels.Gpu
{
    public class GpuDetailsViewModel : GpuAllViewModel
    {
        public int Memory { get; set; }

        public int Interface { get; set; }

        public double Length { get; set; }

        public double SlotsRequired { get; set; }

        public int PowerConsumption { get; set; }

        public bool NvidiaConnector { get; set; }

        public string Description { get; set; } = null!;
    }
}
