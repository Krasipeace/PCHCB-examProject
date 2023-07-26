﻿namespace PCHCB.Web.ViewModels.Case
{
    public class CaseDetailsViewModel : CaseAllViewModel
    {
        public int FormFactor { get; set; } 

        public int CaseSize { get; set; } 

        public int PsuFactor { get; set; }

        public int MaxGpuLength { get; set; }

        public double MaxAirCpuCoolerHeight { get; set; }

        public int MaxStorageDevices { get; set; }

        public int MaxRadiatorLength { get; set; }

        public string Description { get; set; } = null!;
    }
}