namespace PCHCB.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;

    public class PsuEntityConfiguration : IEntityTypeConfiguration<Psu>
    {
        public void Configure(EntityTypeBuilder<Psu> builder)
        {
            builder
                .HasOne(p => p.Provider)
                .WithMany(p => p.ProviderPsus)
                .HasForeignKey(p => p.ProviderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(GeneratePsus());
        }

        private Psu[] GeneratePsus()
        {
            ICollection<Psu> psus = new HashSet<Psu>();
            Psu psu;
            psu = new Psu()
            {
                Id = 1,
                Name = "Corsair RM850x",
                Price = 139.99m,
                Wattage = 850,
                Factor = PsuFactor.Atx,
                ImageUrl = "https://example.com/corsair-rm850x.jpg",
                NvidiaConnector = true,
                Description = "The Corsair RM850x is a high-end power supply with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            psus.Add(psu);

            psu = new Psu()
            {
                Id = 2,
                Name = "EVGA SuperNOVA 750 G5",
                Price = 129.99m,
                Wattage = 750,
                Factor = PsuFactor.Atx,
                ImageUrl = "https://example.com/evga-supernova-750-g5.jpg",
                NvidiaConnector = true,
                Description = "The EVGA SuperNOVA 750 G5 is a high-end power supply with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            psus.Add(psu);

            psu = new Psu()
            {
                Id = 3,
                Name = "Seasonic FOCUS GX-650",
                Price = 109.99m,
                Wattage = 650,
                Factor = PsuFactor.Atx,
                ImageUrl = "https://example.com/seasonic-focus-gx-650.jpg",
                NvidiaConnector = true,
                Description = "The Seasonic FOCUS GX-650 is a mid-range power supply with good performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            psus.Add(psu);

            psu = new Psu()
            {
                Id = 4,
                Name = "be quiet! Straight Power 11 Platinum 750W",
                Price = 149.99m,
                Wattage = 750,
                Factor = PsuFactor.Atx,
                ImageUrl = "https://example.com/be-quiet-straight-power-11-platinum-750w.jpg",
                NvidiaConnector = true,
                Description = "The be quiet! Straight Power 11 Platinum 750W is a high-end power supply with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            psus.Add(psu);

            psu = new Psu()
            {
                Id = 5,
                Name = "Thermaltake Toughpower GF1 750W",
                Price = 129.99m,
                Wattage = 750,
                Factor = PsuFactor.Atx,
                ImageUrl = "https://example.com/thermaltake-toughpower-gf1-750w.jpg",
                NvidiaConnector = true,
                Description = "The Thermaltake Toughpower GF1 750W is a high-end power supply with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            psus.Add(psu);

            psu = new Psu()
            {
                Id = 6,
                Name = "Corsair AX1600i",
                Price = 499.99m,
                Wattage = 1600,
                Factor = PsuFactor.Atx,
                ImageUrl = "https://example.com/corsair-ax1600i.jpg",
                NvidiaConnector = true,
                Description = "The Corsair AX1600i is a high-end power supply with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            psus.Add(psu);

            psu = new Psu()
            {
                Id = 7,
                Name = "EVGA SuperNOVA 1600 T2",
                Price = 499.99m,
                Wattage = 1600,
                Factor = PsuFactor.Atx,
                ImageUrl = "https://example.com/evga-supernova-1600-t2.jpg",
                NvidiaConnector = true,
                Description = "The EVGA SuperNOVA 1600 T2 is a high-end power supply with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            psus.Add(psu);

            psu = new Psu()
            {
                Id = 8,
                Name = "Seasonic PRIME TX-1600",
                Price = 499.99m,
                Wattage = 1600,
                Factor = PsuFactor.Atx,
                ImageUrl = "https://example.com/seasonic-prime-tx-1600.jpg",
                NvidiaConnector = true,
                Description = "The Seasonic PRIME TX-1600 is a high-end power supply with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            psus.Add(psu);

            psu = new Psu()
            {
                Id = 9,
                Name = "Thermaltake Toughpower PF1 ARGB 1200W",
                Price = 299.99m,
                Wattage = 1200,
                Factor = PsuFactor.Atx,
                ImageUrl = "https://example.com/thermaltake-toughpower-pf1-argb-1200w.jpg",
                NvidiaConnector = true,
                Description = "The Thermaltake Toughpower PF1 ARGB 1200W is a high-end power supply with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            psus.Add(psu);

            psu = new Psu()
            {
                Id = 10,
                Name = "be quiet! Dark Power Pro 12 1500W",
                Price = 499.99m,
                Wattage = 1500,
                Factor = PsuFactor.Atx,
                ImageUrl = "https://example.com/be-quiet-dark-power-pro-12-1500w.jpg",
                NvidiaConnector = true,
                Description = "The be quiet! Dark Power Pro 12 1500W is a high-end power supply with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            psus.Add(psu);

            psu = new Psu()
            {
                Id = 11,
                Name = "EVGA 500 W1",
                Price = 49.99m,
                Wattage = 500,
                Factor = PsuFactor.Atx,
                ImageUrl = "https://example.com/evga-500-w1.jpg",
                NvidiaConnector = false,
                Description = "The EVGA 500 W1 is a budget power supply with decent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            psus.Add(psu);

            psu = new Psu()
            {
                Id = 12,
                Name = "Corsair CX450M",
                Price = 64.99m,
                Wattage = 450,
                Factor = PsuFactor.Atx,
                ImageUrl = "https://example.com/corsair-cx450m.jpg",
                NvidiaConnector = false,
                Description = "The Corsair CX450M is a mid-range power supply with good performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            psus.Add(psu);

            psu = new Psu()
            {
                Id = 13,
                Name = "Seasonic S12III 500 SSR-500GB3",
                Price = 59.99m,
                Wattage = 500,
                Factor = PsuFactor.Atx,
                ImageUrl = "https://example.com/seasonic-s12iii-500-ssr-500gb3.jpg",
                NvidiaConnector = false,
                Description = "The Seasonic S12III 500 SSR-500GB3 is a budget power supply with decent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            psus.Add(psu);

            return psus.ToArray();
        }
    }
}
