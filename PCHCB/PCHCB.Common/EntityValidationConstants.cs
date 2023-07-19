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

            public const string PriceMinValue = "1";
            public const string PriceMaxValue = "5000";

            public const int CompatibilityMinLength = 3;
            public const int CompatibilityMaxLength = 200;
        }

        public static class Provider
        {
            public const int PhoneNumberMinLength = 7;
            public const int PhoneNumberMaxLength = 20;

            public const int UrlMinLength = 7;
            public const int UrlMaxLength = 2048;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 500;
        }

        public static class Case
        {
            public const string MaxCpuCoolerHeight = "200";
            public const string MinCpuCoolerHeight = "50";

            public const int StorageSlotsMinValue = 0;
            public const int StorageSlotsMaxValue = 20;

            public const int GpuLengthMinValue = 100;
            public const int GpuLengthMaxValue = 1000;

            public const int PsuFactorMinValue = 0;
            public const int PsuFactorMaxValue = 5;

            public const int RadiatorLengthMinValue = 120;
            public const int RadiatorLengthMaxValue = 960;

            public const int FormFactorMinValue = 0;
            public const int FormFactorMaxValue = 3;
        }

        public static class Cooler
        {
            public const int CoolerTypeMinValue = 0;
            public const int CoolerTypeMaxValue = 1;

            public const int RadiatorSizeMinValue = 0;
            public const int RadiatorSizeMaxValue = 4;

            public const int FanSizeMinValue = 80;
            public const int FanSizeMaxValue = 200;

            public const int CoolerHeightMinValue = 30;
            public const int CoolerHeightMaxValue = 200;

            public const int TdpMinValue = 35;
            public const int TdpMaxValue = 500;

            public const int WidthMinValue = 30;
            public const int WidthMaxValue = 200;
        }

        public static class Cpu
        {
            public const int SocketMaxLength = 20;

            public const string ExclusiveCpuMaxPrice = "9999";
        }
    }
}
