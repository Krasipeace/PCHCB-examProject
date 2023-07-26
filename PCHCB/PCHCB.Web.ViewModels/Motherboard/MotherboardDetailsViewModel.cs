﻿namespace PCHCB.Web.ViewModels.Motherboard
{
    public class MotherboardDetailsViewModel : MotherboardAllViewModel
    {
        public string Socket { get; set; } = null!;

        public string Chipset { get; set; } = null!;

        public int FormFactor { get; set; }

        public int RamType { get; set; }

        public int PcieType { get; set; }

        public int RamSlots { get; set; }

        public int RamCapacity { get; set; }

        public int SataSlots { get; set; }

        public int PcieSlots { get; set; }

        public int M2Slots { get; set; }

        public string Description { get; set; } = null!;
    }
}