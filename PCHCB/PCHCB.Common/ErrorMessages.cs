namespace PCHCB.Common
{
    public static class ErrorMessages
    {
        public static class General
        {
            public const string SomethingWentWrong = "Oops, something went wrong! Try again later or contact administrator!";

            public const string AreaUnderConstruction = "Unfortunately this area is still under construction!";
        }

        public static class Provider
        {
            public const string ProviderAlreadyExists = "You are already a provider!";

            public const string ProviderWithPhoneNumberAlreadyExists = "Provider with such Phone Number already exists!";

            public const string ProviderWithSuchLogoUrlAlreadyExists = "Provider with such Logo Image already exists!";

            public const string ProviderWithSuchWebPageAlreadyExists = "Provider with such Web Page already exists!";

            public const string UserCannotAddCasesErrorMessage = "You must be a provider to be able to add new Cases!";
            public const string UserCannotEditCasesErrorMessage = "You must be a provider to be able to edit Cases!";
            public const string UserCannotDeleteCasesErrorMessage = "You must be a provider to be able to delete Cases!";
            public const string ProviderCannotEditCaseHeDoesNotOwnErrorMessage = "You cannot edit a Case you do not own!";
            public const string ProviderCannotDeleteCaseHeDoesNotOwnErrorMessage = "You cannot delete a Case you do not own!";

            public const string UserCannotAddCoolersErrorMessage = "You must be a provider to be able to add new Coolers!";
            public const string UserCannotEditCoolersErrorMessage = "You must be a provider to be able to edit Coolers!";
            public const string UserCannotDeleteCoolersErrorMessage = "You must be a provider to be able to delete Coolers!";
            public const string ProviderCannotEditCoolerHeDoesNotOwnErrorMessage = "You cannot edit a Cooler you do not own!";
            public const string ProviderCannotDeleteCoolerHeDoesNotOwnErrorMessage = "You cannot delete a Cooler you do not own!";

            public const string UserCannotAddCpusErrorMessage = "You must be a provider to be able to add new CPUs!";
            public const string UserCannotEditCpusErrorMessage = "You must be a provider to be able to edit CPUs!";
            public const string UserCannotDeleteCpusErrorMessage = "You must be a provider to be able to delete CPUs!";
            public const string ProviderCannotEditCpuHeDoesNotOwnErrorMessage = "You cannot edit a CPU you do not own!";
            public const string ProviderCannotDeleteCpuHeDoesNotOwnErrorMessage = "You cannot delete a CPU you do not own!";

            public const string UserCannotAddGpusErrorMessage = "You must be a provider to be able to add new GPUs!";
            public const string UserCannotEditGpusErrorMessage = "You must be a provider to be able to edit GPUs!";
            public const string UserCannotDeleteGpusErrorMessage = "You must be a provider to be able to delete GPUs!";
            public const string ProviderCannotEditGpuHeDoesNotOwnErrorMessage = "You cannot edit a GPU you do not own!";
            public const string ProviderCannotDeleteGpuHeDoesNotOwnErrorMessage = "You cannot delete a GPU you do not own!";

            public const string UserCannotAddMotherboardsErrorMessage = "You must be a provider to be able to add new Motherboards!";
            public const string UserCannotEditMotherboardsErrorMessage = "You must be a provider to be able to edit Motherboards!";
            public const string UserCannotDeleteMotherboardsErrorMessage = "You must be a provider to be able to delete Motherboards!";
            public const string ProviderCannotEditMotherboardHeDoesNotOwnErrorMessage = "You cannot edit a Motherboard you do not own!";
            public const string ProviderCannotDeleteMotherboardHeDoesNotOwnErrorMessage = "You cannot delete a Motherboard you do not own!";

            public const string UserCannotAddPowerSuppliesErrorMessage = "You must be a provider to be able to add new Power Supplies!";
            public const string UserCannotEditPowerSuppliesErrorMessage = "You must be a provider to be able to edit Power Supplies!";
            public const string UserCannotDeletePowerSuppliesErrorMessage = "You must be a provider to be able to delete Power Supplies!";
            public const string ProviderCannotEditPowerSupplyHeDoesNotOwnErrorMessage = "You cannot edit a Power Supply you do not own!";
            public const string ProviderCannotDeletePowerSupplyHeDoesNotOwnErrorMessage = "You cannot delete a Power Supply you do not own!";

            public const string UserCannotAddRamsErrorMessage = "You must be a provider to be able to add new RAMs!";
            public const string UserCannotEditRamsErrorMessage = "You must be a provider to be able to edit RAMs!";
            public const string UserCannotDeleteRamsErrorMessage = "You must be a provider to be able to delete RAMs!";
            public const string ProviderCannotEditRamHeDoesNotOwnErrorMessage = "You cannot edit a RAM you do not own!";
            public const string ProviderCannotDeleteRamHeDoesNotOwnErrorMessage = "You cannot delete a RAM you do not own!";

            public const string UserCannotAddStorageDevicesErrorMessage = "You must be a provider to be able to add new Storage Devices!";
            public const string UserCannotEditStorageDevicesErrorMessage = "You must be a provider to be able to edit Storage Devices!";
            public const string UserCannotDeleteStorageDevicesErrorMessage = "You must be a provider to be able to delete Storage Devices!";
            public const string ProviderCannotEditStorageDeviceHeDoesNotOwnErrorMessage = "You cannot edit a Storage Device you do not own!";
            public const string ProviderCannotDeleteStorageDeviceHeDoesNotOwnErrorMessage = "You cannot delete a Storage Device you do not own!";

            public const string OnlyProviderCanViewHisHardwareErrorMessage = "Only a provider can view his hardware!";
        }

        public static class Case
        {
            public const string CaseWithIdDoesNotExist = "Case with such Id does not exist!";
        }

        public static class Cooler
        {
            public const string CoolerWithIdDoesNotExist = "Cooler with such Id does not exist!";
        }

        public static class Cpu
        {
            public const string CpuWithIdDoesNotExist = "CPU with such Id does not exist!";
        }

        public static class Gpu
        {
            public const string GpuWithIdDoesNotExist = "GPU with such Id does not exist!";
        }

        public static class Motherboard
        {
            public const string MotherboardWithIdDoesNotExist = "Motherboard with such Id does not exist!";
        }

        public static class Psu
        {
            public const string PsuWithIdDoesNotExist = "Power Supply with such Id does not exist!";
        }

        public static class Ram
        {
            public const string RamWithIdDoesNotExist = "RAM with such Id does not exist!";
        }

        public static class Storage
        {
            public const string StorageWithIdDoesNotExist = "Storage Device with such Id does not exist!";
        }

        public static class User
        {
            public const string PasswordErrorMessage = "The {0} must be at least {2} and at max {1} characters long.";
            public const string PasswordsDoNotMatchErrorMessage = "The password and confirmation password do not match.";

            public const string FirstNameErrorMessage = "The {0} must be at least {2} and at max {1} characters long.";
            public const string LastNameErrorMessage = "The {0} must be at least {2} and at max {1} characters long.";

            public const string BuilderErrorMessage = "Only user of his/her own configuration can view it!";
        }
    }
}
