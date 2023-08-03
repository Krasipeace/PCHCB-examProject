namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.Case;
    using PCHCB.Web.ViewModels.ConfigurationHardware;
    using PCHCB.Web.ViewModels.Cooler;
    using PCHCB.Web.ViewModels.Cpu;
    using PCHCB.Web.ViewModels.Gpu;
    using PCHCB.Web.ViewModels.Motherboard;
    using PCHCB.Web.ViewModels.Psu;
    using PCHCB.Web.ViewModels.Ram;
    using PCHCB.Web.ViewModels.Storage;

    public interface IConfigurationHardwareService
    {
        Task<CaseDetailsViewModel> SelectCaseForAssemble(int caseId, int motherboardId, int gpuId);

        Task<CpuDetailsViewModel> SelectCpuForAssemble(int cpuId);

        Task<CoolerDetailsViewModel> SelectCoolerForAssemble(int coolerId, int caseId, int cpuId);

        Task<MotherboardDetailsViewModel> SelectMotherboardForAssemble(int motherboardId, int cpuId);

        Task<RamDetailsViewModel> SelectRamForAssemble(int ramId, int motherboardId, int cpuId); 

        Task<StorageDetailsViewModel> SelectStorageForAssemble(int storageId, int motherboardId);

        Task<GpuDetailsViewModel> SelectGpuForAssemble(int gpuId);

        Task<PsuDetailsViewModel> SelectPsuForAssemble(int psuId, int caseId);

        Task<double> CalculateWattage(int cpuId, int gpuId, int motherboardId, int coolerId, int storageId);

        Task<IEnumerable<AssembleConfigurationFormModel>> AssemblePcConfiguration(int pcConfigurationId);
    }
}
