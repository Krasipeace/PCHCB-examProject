namespace PCHCB.Web.ViewModels.PcConfiguration
{
    using PCHCB.Web.ViewModels.Contracts;

    /// <summary>
    /// Assemble Pc Configuration Form Model
    /// </summary>
    public class AssembleConfigurationFormModel : IProtectedUrlsModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int CaseId { get; set; }

        public int CoolerId { get; set; }

        public int CpuId { get; set; }

        public int GpuId { get; set; }

        public int MotherboardId { get; set; }

        public int PsuId { get; set; }

        public int RamId { get; set; }

        public int StorageId { get; set; }

        public Guid BuilderId { get; set; }
    }
}
