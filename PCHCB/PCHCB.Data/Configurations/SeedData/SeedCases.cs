namespace PCHCB.Data.Configurations.SeedData
{
    using System;
    using System.Collections.Generic;

    using PCHCB.Data.Models.Enums;
    using PCHCB.Data.Models;

    public class SeedCases
    {
        public static List<Case> GenerateCases()
        {
            var cases = new List<Case>
            {
                new Case
                {
                    Name = "Corsair Carbide Series 175R RGB",
                    Price = 69.99m,
                    CaseSize = CaseSize.MidTower,
                    FormFactor = MbFormFactor.ATX,
                    MaxGpuLength = 330,
                    MaxAirCpuCoolerHeight = 160,
                    PsuFactor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/corsair-carbide-series-175r-rgb.jpg",
                    MaxStorageDevices = 4,
                    MaxRadiatorLength = 280,
                    Description = "The Corsair Carbide Series 175R RGB is a mid-tower ATX case with clean lines and a minimalist design.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Case
                {
                    Name = "Fractal Design Meshify C",
                    Price = 89.99m,
                    CaseSize = CaseSize.MidTower,
                    FormFactor = MbFormFactor.ATX,
                    MaxGpuLength = 315,
                    MaxAirCpuCoolerHeight = 170,
                    PsuFactor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/fractal-design-meshify-c.jpg",
                    MaxStorageDevices = 5,
                    MaxRadiatorLength = 280,
                    Description = "The Fractal Design Meshify C is a mid-tower ATX case with a unique mesh front panel that provides excellent airflow.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Case
                {
                    Name = "NZXT H510",
                    Price = 69.99m,
                    CaseSize = CaseSize.MidTower,
                    FormFactor = MbFormFactor.ATX,
                    MaxGpuLength = 381,
                    MaxAirCpuCoolerHeight = 165,
                    PsuFactor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/nzxt-h510.jpg",
                    MaxStorageDevices = 7,
                    MaxRadiatorLength = 280,
                    Description = "The NZXT H510 is a mid-tower ATX case with a sleek and modern design that looks great in any setup.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Case
                {
                    Name = "Lian Li PC-O11 Dynamic",
                    Price = 149.99m,
                    CaseSize = CaseSize.FullTower,
                    FormFactor = MbFormFactor.ATX,
                    MaxGpuLength = 420,
                    MaxAirCpuCoolerHeight = 155,
                    PsuFactor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/lian-li-pc-o11-dynamic.jpg",
                    MaxStorageDevices = 6,
                    MaxRadiatorLength = 360,
                    Description = "The Lian Li PC-O11 Dynamic is a full-tower ATX case with a unique dual-chamber design that provides excellent cooling performance.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Case
                {
                    Name = "Phanteks Enthoo Evolv X",
                    Price = 199.99m,
                    CaseSize = CaseSize.FullTower,
                    FormFactor = MbFormFactor.ATX,
                    MaxGpuLength = 435,
                    MaxAirCpuCoolerHeight = 190,
                    PsuFactor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/phanteks-enthoo-evolv-x.jpg",
                    MaxStorageDevices = 10,
                    MaxRadiatorLength = 420,
                    Description = "The Phanteks Enthoo Evolv X is a full-tower ATX case with a premium build quality and a wide range of features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                }
            };

            return cases;
        }
    }
}

