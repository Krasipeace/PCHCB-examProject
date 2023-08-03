namespace PCHCB.Web.ViewModels.ConfigurationHardware
{
    using PCHCB.Web.ViewModels.PcConfiguration;

    public class AssembleConfigurationFormModel
    {
        public int CaseId { get; set; }

        public int CoolerId { get; set; }

        public int CpuId { get; set; }

        public int GpuId { get; set; }

        public int MotherboardId { get; set; }

        public int PowerSupplyId { get; set; }

        public int RamId { get; set; }

        public int StorageId { get; set;}

        public SaveConfigurationFormModel SaveConfigurationFormModel { get; set; } = null!;
    }
}
