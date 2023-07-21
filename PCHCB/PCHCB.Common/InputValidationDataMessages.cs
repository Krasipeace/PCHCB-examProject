namespace PCHCB.Common
{
    public static class InputValidationDataMessages
    {
        public static class General
        {
            public const string RequiredFieldMessage = "The {0} is required.";

            public const string UrlLengthErrorMessage = "The Web Link must be at least {2} and at max {1} characters long.";

            public const string DescriptionLengthErrorMessage = "The Description must be at least {2} and at max {1} characters long.";

            public const string NameLengthErrorMessage = "The Name must be at least {2} and at max {1} characters long.";

            public const string PriceRangeErrorMessage = "The Price must be between ${1} and ${2}";
        }

        public static class Provider
        {
            public const string PhoneNumberLengthErrorMessage = "Phone Number must be at least {2} and at max {1} characters long.";

            public const string WebPageLengthErrorMessage = "Web Page must be at least {2} and at max {1} characters long.";

            public const string LogoUrlLengthErrorMessage = "Image Link for Logo must be at least {2} and at max {1} characters long.";
        }

        public static class Cooler
        {
            public const string CoolerTypeErrorMessage = "Cooler Type must be either Air or Water!";

            public const string CoolerCompatibilityLengthMessage = "Available CPU Sockets for the cooler must be at least {2} and at max {1} characters long.";
        }

        public static class Cpu
        {
            public const string CpuSocketLengthErrorMessage = "Cpu Socket can be maximum 20 characters long.";

            public const string CoresRangeErrorMessage = "Cpu Cores must be between {1} and {2}.";

            public const string ThreadsRangeErrorMessage = "Cpu Threads must be between {1} and {2}.";

            public const string FrequencyRangeErrorMessage = "Cpu Frequency must be between {1} and {2}.";

            public const string TurboFrequencyRangeErrorMessage = "Cpu Turbo Frequency must be between {1} and {2}.";

            public const string CacheRangeErrorMessage = "Cpu Cache must be between {1} and {2}.";

            public const string TdpRangeErrorMessage = "Cpu TDP must be between {1} and {2}.";

            public const string RamFrequencyRangeErrorMessage = "Cpu Ram Frequency must be between {1} and {2}.";

            public const string RamTypeRangeErrorMessage = "Cpu Ram Type must be either DDR3/DDR4/DDR5!";
        }

        public static class Gpu
        {
            public const string InterfaceRangeErrorMessage = "Gpu Interface must be either PCI-e 3.0/PCI-e 4.0/PCI-e 5.0!";

            public const string MemoryRangeErrorMessage = "Gpu Memory must be between {1} and {2}.";

            public const string LengthRangeErrorMessage = "Gpu Length must be between {1} and {2}.";

            public const string SlotsRangeErrorMessage = "Gpu Slots must be between {1} and {2}.";

            public const string PowerConsumptionRangeErrorMessage = "Graphic Card Power Consumption must be between {1} and {2}.";
        }

        public static class Motherboard
        {
            public const string FormFactorRangeErrorMessage = "Motherboard Form Factor must be either ATX/mATX/mITX/EATX!";

            public const string SocketRangeErrorMessage = "Motherboard Socket Type must be between {1} and {2} characters long!";

            public const string ChipsetRangeErrorMessage = "Motherboard Chipset must be between {1} and {2} characters long!";

            public const string RamTypeRangeErrorMessage = "Motherboard Ram Type must be either DDR3/DDR4/DDR5!";

            public const string RamSlotsRangeErrorMessage = "Motherboard Available Ram Slots must be between {1} and {2}.";

            public const string RamCapacityRangeErrorMessage = "Motherboard Max Ram Capacity must be below {2} (Min. value - {1}).";

            public const string SataSlotsRangeErrorMessage = "Motherboard Available SATA Slots must be between {1} and {2}.";

            public const string PcieTypeRangeErrorMessage = "Motherboard PCI-e Type must be either PCI-e 3.0/PCI-e 4.0/PCI-e 5.0/PCI-e 6.0!";

            public const string PcieSlotsRangeErrorMessage = "Motherboard Available PCI-e Slots must be between {1} and {2}.";

            public const string M2SlotsRangeErrorMessage = "Motherboard Available M.2 Slots must be between {1} and {2}.";
        }

        public static class Psu
        {
            public const string WattsRangeErrorMessage = "Power Supply Watts must be between {1} and {2}.";

            public const string FactorRangeErrorMessage = "PSU Factor must be either ATX/LFX/SFX/CFX/TFX/flexATX!";
        }

        public static class Ram
        {
            public const string DDRTypeRangeErrorMessage = "RAM Type must be either DDR3/DDR4/DDR5!";

            public const string FrequencyRangeErrorMessage = "RAM Frequency must be between {1} and {2}.";

            public const string CapacityRangeErrorMessage = "RAM Capacity must be between {1} and {2}.";

            public const string HeightRangeErrorMessage = "RAM Height must be between {1} and {2}.";

            public const string ModelNumberLengthErrorMessage = "RAM Model Number must be at least {2} and at max {1} characters long.";
        }

        public static class Storage
        {
            public const string CapacityRangeErrorMessage = "Storage Capacity must be between {1} and {2}.";

            public const string TypeRangeErrorMessage = "Storage Type must be either HDD/SSD/M.2(NVMe)!";
        }
    }
}
