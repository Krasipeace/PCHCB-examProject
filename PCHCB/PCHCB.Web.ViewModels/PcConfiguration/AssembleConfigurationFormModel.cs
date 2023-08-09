namespace PCHCB.Web.ViewModels.PcConfiguration
{
    /// <summary>
    /// Assemble Pc Configuration Form Model
    /// </summary>
    public class AssembleConfigurationFormModel
    {
        public int PcConfigurationId { get; set; }

        public int CaseId { get; set; }

        public int CoolerId { get; set; }

        public int CpuId { get; set; }

        public int GpuId { get; set; }

        public int MotherboardId { get; set; }

        public int PsuId { get; set; }

        public int RamId { get; set; }

        public int StorageId { get; set; }
    }
}
