namespace PCHCB.Common
{
    public static class InputValidationDataMessages
    {
        public static class General
        {
            public const string RequiredFieldMessage = "The {0} is required.";
        }

        public static class Provider
        {
            public const string PhoneNumberLengthErrorMessage = "Phone Number must be at least {2} and at max {1} characters long.";

            public const string WebPageLengthErrorMessage = "Web Page must be at least {2} and at max {1} characters long.";

            public const string LogoUrlLengthErrorMessage = "Image Link for Logo must be at least {2} and at max {1} characters long.";

            public const string DescriptionLengthErrorMessage = "Description must be at least {2} and at max {1} characters long.";
        }
    }
}
