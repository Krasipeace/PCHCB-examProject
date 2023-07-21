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

            public const string ProviderCannotAddCasesErrorMessage = "You must be a provider to be able to add new Cases!";
        }
    }
}
