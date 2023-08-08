﻿namespace PCHCB.Services.Data.Contracts
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
        Task<CaseDetailsViewModel> SelectCaseForAssemble(int caseId);

        Task<CpuDetailsViewModel> SelectCpuForAssemble(int cpuId);

        Task<CoolerDetailsViewModel> SelectCoolerForAssemble(int coolerId);

        Task<MotherboardDetailsViewModel> SelectMotherboardForAssemble(int motherboardId);

        Task<RamDetailsViewModel> SelectRamForAssemble(int ramId, int coolerId, int motherboardId); 

        Task<StorageDetailsViewModel> SelectStorageForAssemble(int storageId);

        Task<GpuDetailsViewModel> SelectGpuForAssemble(int gpuId);

        Task<PsuDetailsViewModel> SelectPsuForAssemble(int psuId, int cpuId, int gpuId, int motherboardId, int coolerId, int storageId, int ramId);

        Task<double> CalculateWattage(int cpuId, int gpuId, int motherboardId, int coolerId, int storageId, int ramId);

        Task<int> AssemblePcConfiguration(AssembleConfigurationFormModel buildConfiguration);
    }
}
