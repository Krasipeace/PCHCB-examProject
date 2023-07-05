namespace PCHCB.Common
{
    public static class EntityValidationConstants
    {
        public static class PcConfiguration
        {
            public const string PcPriceMinValue = "500";
            public const string PcPriceMaxValue = "30000";
        }

        public static class Component
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 1000;

            public const int UrlMinLength = 7;
            public const int UrlMaxLength = 2048;

            public const int GpuMinLength = 7;
            public const int GpuMaxLength = 600;

            public const int CpuMaxHeight = 200;

            public const string PriceMinValue = "1";
            public const string PriceMaxValue = "5000";

            public const int CompatibilityMinLength = 3;
            public const int CompatibilityMaxLength = 200;
        }
    }
}
