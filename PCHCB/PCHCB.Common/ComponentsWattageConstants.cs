namespace PCHCB.Common
{
    /// <summary>
    /// Max Possible Wattage for Components
    /// </summary>
    public static class ComponentsWattageConstants
    {
        /// <summary>
        /// based on wikipedia
        /// </summary>
        public static class Motherboard
        {
            public const double AtxWattage = 80;
            public const double MicroAtxWattage = 70;
            public const double MiniItxWattage = 60;
            public const double ExtendedAtxWattage = 120;
        }

        /// <summary>
        /// based on enthusiast level
        /// </summary>
        public static class Storage
        {
            public const double SsdWattage = 8;
            public const double HddWattage = 12;
            public const double M2Wattage = 0.08;
        }

        /// <summary>
        /// wattage based on 32GB of ram
        /// </summary>
        public static class Ram
        {
            public const double Ddr3Wattage = 12;
            public const double Ddr4Wattage = 11.85;
            public const double Ddr5Wattage = 10.665;
        }

        /// <summary>
        /// based on coolers with 3 fans 
        /// </summary>
        public static class Cooler
        {
            public const double AirWattage = 12;
            public const double WaterWattage = 13.56;

            public const int CoolerSecureTDPMultiplierValue = 2;
        }
    }
}
