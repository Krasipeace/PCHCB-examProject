namespace PCHCB.Common
{
    public static class ErrorMessages
    {
        public static class General
        {
            public const string SomethingWentWrong = "Oops, something went wrong! Try again later or contact administrator!";
        }

        public static class Provider
        {
            public const string ProviderAlreadyExists = "You are already a provider!";

            public const string ProviderWithPhoneNumberAlreadyExists = "Provider with such Phone Number already exists!";

            public const string ProviderWithSuchLogoUrlAlreadyExists = "Provider with such Logo Image already exists!";

            public const string ProviderWithSuchWebPageAlreadyExists = "Provider with such Web Page already exists!";

            public const string UserCannotAddCasesErrorMessage = "You must be a provider to be able to add new Cases!";

            public const string UserCannotAddCoolersErrorMessage = "You must be a provider to be able to add new Coolers!";

            public const string UserCannotAddCpusErrorMessage = "You must be a provider to be able to add new CPUs!";

            public const string UserCannotAddGpusErrorMessage = "You must be a provider to be able to add new GPUs!";

            public const string UserCannotAddMotherboardsErrorMessage = "You must be a provider to be able to add new Motherboards!";

            public const string UserCannotAddPowerSuppliesErrorMessage = "You must be a provider to be able to add new Power Supplies!";

            public const string UserCannotAddRamsErrorMessage = "You must be a provider to be able to add new RAMs!";

            public const string UserCannotAddStorageDevicesErrorMessage = "You must be a provider to be able to add new Storage Devices!";
        }
    }
}
