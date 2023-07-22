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
            public const string ExclusiveCpuMaxPrice = "9999";

            public const int SocketMinLength = 2;
            public const int SocketMaxLength = 20;

            public const int CoresMinValue = 2;
            public const int CoresMaxValue = 128;

            public const int ThreadsMinValue = 2;
            public const int ThreadsMaxValue = 256;

            public const int FrequencyMinValue = 1000;
            public const int FrequencyMaxValue = 7000;

            public const int TurboFrequencyMinValue = 1200;
            public const int TurboFrequencyMaxValue = 8000;

            public const int CacheMinValue = 4;
            public const int CacheMaxValue = 256;

            public const int TdpMinValue = 35;
            public const int TdpMaxValue = 500;

            public const int RamFrequencyMinValue = 1600;
            public const int RamFrequencyMaxValue = 7800;

            public const int RamTypeMinValue = 0;
            public const int RamTypeMaxValue = 2;
        }

        public static class Gpu
        {
            public const int InterfaceMinValue = 0;
            public const int InterfaceMaxValue = 3;

            public const int MemoryMinValue = 2;
            public const int MemoryMaxValue = 32;

            public const string LengthMinValue = "100";
            public const string LengthMaxValue = "700";

            public const string SlotsMinValue = "1";
            public const string SlotsMaxValue = "4";

            public const int PowerConsumptionMinValue = 50;
            public const int PowerConsumptionMaxValue = 1300;
        }

        public static class Motherboard
        {
            public const int FormFactorMinValue = 0;
            public const int FormFactorMaxValue = 3;

            public const int SocketMinValue = 1;
            public const int SocketMaxValue = 20;

            public const int ChipsetMinValue = 2;
            public const int ChipsetMaxValue = 10;

            public const int RamTypeMinValue = 0;
            public const int RamTypeMaxValue = 2;

            public const int RamSlotsMinValue = 1;
            public const int RamSlotsMaxValue = 8;

            public const int RamCapacityMinValue = 1;
            public const int RamCapacityMaxValue = 256;
            
            public const int SataSlotsMinValue = 2;
            public const int SataSlotsMaxValue = 20;

            public const int PcieTypeMinValue = 0;
            public const int PcieTypeMaxValue = 3;

            public const int PcieSlotsMinValue = 1;
            public const int PcieSlotsMaxValue = 8;

            public const int M2SlotsMinValue = 0;
            public const int M2SlotsMaxValue = 6;

            public const int SocketMaxLength = 20;
            
            public const int ChipsetMaxLength = 10;
        }

        public static class Psu
        {
            public const int WattsMinValue = 300;
            public const int WattsMaxValue = 2000;

            public const int FactorRangeMinValue = 0;
            public const int FactorRangeMaxValue = 5;
        }

        public static class Ram
        {
            public const int CapacityMinValue = 2;
            public const int CapacityMaxValue = 128;

            public const int FrequencyMinValue = 1600;
            public const int FrequencyMaxValue = 7800;

            public const int DDRRangeMinValue = 0;
            public const int DDRRangeMaxValue = 2;

            public const int HeightMinValue = 20;
            public const int HeightMaxValue = 60;

            public const int ModelNumberMaxLengthValue = 4;
            public const int ModelNumberMinLengthValue = 20;
        }

        public static class Storage
        {
            public const int CapacityMinValue = 128;
            public const int CapacityMaxValue = 22_000_000;

            public const int TypeMinValue = 0;
            public const int TypeMaxValue = 2;
        }
    }
}
