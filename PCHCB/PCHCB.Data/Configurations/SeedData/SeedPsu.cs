namespace PCHCB.Data.Configurations.SeedData
{
    using PCHCB.Data.Models.Enums;
    using PCHCB.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class SeedPsu
    {
        public static List<Psu> GeneratePsus()
        {
            var psus = new List<Psu>
            {
                new Psu
                {
                    Name = "Corsair RM850x",
                    Price = 139.99m,
                    Wattage = 850,
                    Factor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/corsair-rm850x.jpg",
                    NvidiaConnector = true,
                    Description = "The Corsair RM850x is a high-end power supply with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Psu
                {
                    Name = "EVGA SuperNOVA 750 G5",
                    Price = 129.99m,
                    Wattage = 750,
                    Factor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/evga-supernova-750-g5.jpg",
                    NvidiaConnector = true,
                    Description = "The EVGA SuperNOVA 750 G5 is a high-end power supply with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Psu
                {
                    Name = "Seasonic FOCUS GX-650",
                    Price = 109.99m,
                    Wattage = 650,
                    Factor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/seasonic-focus-gx-650.jpg",
                    NvidiaConnector = true,
                    Description = "The Seasonic FOCUS GX-650 is a mid-range power supply with good performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Psu
                {
                    Name = "be quiet! Straight Power 11 Platinum 750W",
                    Price = 149.99m,
                    Wattage = 750,
                    Factor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/be-quiet-straight-power-11-platinum-750w.jpg",
                    NvidiaConnector = true,
                    Description = "The be quiet! Straight Power 11 Platinum 750W is a high-end power supply with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Psu
                {
                    Name = "Thermaltake Toughpower GF1 750W",
                    Price = 129.99m,
                    Wattage = 750,
                    Factor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/thermaltake-toughpower-gf1-750w.jpg",
                    NvidiaConnector = true,
                    Description = "The Thermaltake Toughpower GF1 750W is a high-end power supply with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                              new Psu
                {
                    Name = "Corsair AX1600i",
                    Price = 499.99m,
                    Wattage = 1600,
                    Factor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/corsair-ax1600i.jpg",
                    NvidiaConnector = true,
                    Description = "The Corsair AX1600i is a high-end power supply with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Psu
                {
                    Name = "EVGA SuperNOVA 1600 T2",
                    Price = 499.99m,
                    Wattage = 1600,
                    Factor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/evga-supernova-1600-t2.jpg",
                    NvidiaConnector = true,
                    Description = "The EVGA SuperNOVA 1600 T2 is a high-end power supply with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Psu
                {
                    Name = "Seasonic PRIME TX-1600",
                    Price = 499.99m,
                    Wattage = 1600,
                    Factor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/seasonic-prime-tx-1600.jpg",
                    NvidiaConnector = true,
                    Description = "The Seasonic PRIME TX-1600 is a high-end power supply with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Psu
                {
                    Name = "Thermaltake Toughpower PF1 ARGB 1200W",
                    Price = 299.99m,
                    Wattage = 1200,
                    Factor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/thermaltake-toughpower-pf1-argb-1200w.jpg",
                    NvidiaConnector = true,
                    Description = "The Thermaltake Toughpower PF1 ARGB 1200W is a high-end power supply with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Psu
                {
                    Name = "be quiet! Dark Power Pro 12 1500W",
                    Price = 499.99m,
                    Wattage = 1500,
                    Factor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/be-quiet-dark-power-pro-12-1500w.jpg",
                    NvidiaConnector = true,
                    Description = "The be quiet! Dark Power Pro 12 1500W is a high-end power supply with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Psu
                {
                    Name = "EVGA 500 W1",
                    Price = 49.99m,
                    Wattage = 500,
                    Factor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/evga-500-w1.jpg",
                    NvidiaConnector = false,
                    Description = "The EVGA 500 W1 is a budget power supply with decent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Psu
                {
                    Name = "Corsair CX450M",
                    Price = 64.99m,
                    Wattage = 450,
                    Factor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/corsair-cx450m.jpg",
                    NvidiaConnector = false,
                    Description = "The Corsair CX450M is a mid-range power supply with good performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Psu
                {
                    Name = "Seasonic S12III 500 SSR-500GB3",
                    Price = 59.99m,
                    Wattage = 500,
                    Factor = PsuFactor.Atx,
                    ImageUrl = "https://example.com/seasonic-s12iii-500-ssr-500gb3.jpg",
                    NvidiaConnector = false,
                    Description = "The Seasonic S12III 500 SSR-500GB3 is a budget power supply with decent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
            };

            return psus;
        }
    }
}
