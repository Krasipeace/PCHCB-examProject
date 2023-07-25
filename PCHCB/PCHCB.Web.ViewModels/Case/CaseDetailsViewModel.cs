namespace PCHCB.Web.ViewModels.Case
{
    using System.ComponentModel.DataAnnotations;

    public class CaseDetailsViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Case Name")]
        public string Name { get; set; } = null!;

        [Display(Name = "Case Price")]
        public decimal Price { get; set; }

        [Display(Name = "Select Case Size")]
        public int CaseSize { get; set; }

        [Display(Name = "Select MB Form Factor")]
        public int FormFactor { get; set; }

        [Display(Name = "Case Max Graphic Card Length(in mm)")]
        public int MaxGpuLength { get; set; }

        [Display(Name = "Case Max Air CPU Cooler Height(in mm)")]
        public double MaxAirCpuCoolerHeight { get; set; }

        [Display(Name = "Select PSU Factor")]
        public int PsuFactor { get; set; } 

        [Display(Name = "Max Storage Devices in Case")]
        public int MaxStorageDevices { get; set; }

        [Display(Name = "Max Radiator Length(in mm) in Case")]
        public int MaxRadiatorLength { get; set; }

        [Display(Name = "Case Image Link")]
        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ProviderId { get; set; } = null!;
    }
}
