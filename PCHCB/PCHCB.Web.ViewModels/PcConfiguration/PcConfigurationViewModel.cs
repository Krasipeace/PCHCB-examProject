namespace PCHCB.Web.ViewModels.PcConfiguration
{
    public class PcConfigurationViewModel
    {
        public PcConfigurationViewModel()
        {
            //this.Case = new CaseViewModel();
            //this.Cooler = new CoolerViewModel();
            //this.Cpu = new CpuViewModel();
            //this.Gpu = new GpuViewModel();
            //this.Motherboard = new MotherboardViewModel();
            //this.PowerSupply = new PowerSupplyViewModel();
            //this.Ram = new RamViewModel();
            //this.Storage = new StorageViewModel();
        }

        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public DateTime CreatedOn { get; set; }

        //public CaseViewModel Case { get; set; }

        //public CoolerViewModel Cooler { get; set; }

        //public CpuViewModel Cpu { get; set; }

        //public GpuViewModel Gpu { get; set; }

        //public MotherboardViewModel Motherboard { get; set; }

        //public PowerSupplyViewModel PowerSupply { get; set; }

        //public RamViewModel Ram { get; set; }

        //public StorageViewModel Storage { get; set; }
    }
}
