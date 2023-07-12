namespace PCHCB.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;

    using System.Collections;
    using System.Collections.Generic;

    public class CoolerEntityConfiguration : IEntityTypeConfiguration<Cooler>
    {
        public void Configure(EntityTypeBuilder<Cooler> builder)
        {
            builder
                .HasOne(p => p.Provider)
                .WithMany(c => c.ProviderCoolers)
                .HasForeignKey(p => p.ProviderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(GenerateCoolers());
        }

        private Cooler[] GenerateCoolers()
        {
            ICollection<Cooler> coolers = new HashSet<Cooler>();

            Cooler cooler;

            cooler = new Cooler
            {
                Id = 1,
                Name = "Noctua NH-D15",
                Price = 99.99m,
                Type = CoolerType.Air,
                ImageUrl = "https://example.com/noctua-nh-d15.jpg",
                Compatibility = "Intel LGA2066, LGA2011-0 & LGA2011-3 (Square ILM), LGA1200, LGA1156, LGA1155, LGA1151, LGA1150 & AMD AM2, AM2+, AM3, AM3+, AM4, FM1, FM2, FM2+",
                FanSize = 140,
                CoolerHeight = 165,
                Tdp = 220,
                Width = 150,
                Description = "The Noctua NH-D15 is a high-end air cooler with excellent cooling performance and low noise levels.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            coolers.Add(cooler);

            cooler = new Cooler()
            {
                Id = 2,
                Name = "Corsair H100i RGB Platinum",
                Price = 159.99m,
                Type = CoolerType.Water,
                ImageUrl = "https://example.com/corsair-h100i-rgb-platinum.jpg",
                Compatibility = "Intel 1200, 1150, 1151, 1155, 1156, 1366, 2011, 2066 & AMD AM4, sTRX4*, TR4* (*Threadripper bracket not included)",
                RadiatorSize = RadiatorSize._240,
                Tdp = 250,
                Description = "The Corsair H100i RGB Platinum is a high-end water cooler with customizable RGB lighting and excellent cooling performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            coolers.Add(cooler);

            cooler = new Cooler()
            {
                Id = 3,
                Name = "be quiet! Dark Rock Pro 4",
                Price = 89.99m,
                Type = CoolerType.Air,
                ImageUrl = "https://example.com/be-quiet-dark-rock-pro-4.jpg",
                Compatibility = "Intel: LGA 1150 / 1151 / 1155 / 1156 / 1366 / 2011(-3) Square ILM / 2066 & AMD: AM2(+) / AM3(+) / AM4 / FM1 / FM2(+)",
                FanSize = 120,
                CoolerHeight = 162.8,
                Tdp = 250,
                Width = 136,
                Description = "The be quiet! Dark Rock Pro 4 is a high-end air cooler with a sleek design and excellent cooling performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            coolers.Add(cooler);

            cooler = new Cooler()
            {
                Id = 4,
                Name = "NZXT Kraken X63",
                Price = 149.99m,
                Type = CoolerType.Water,
                ImageUrl = "https://example.com/nzxt-kraken-x63.jpg",
                Compatibility = "Intel Socket LGA 1200, 1151, 1150, 1155, 1156, 1366, 2011, 2011-3, 2066 & AMD Socket AM4, sTRX4*, TR4* (*Threadripper bracket not included)",
                RadiatorSize = RadiatorSize._280,
                Tdp = 250,
                Description = "The NZXT Kraken X63 is a high-end water cooler with a customizable LCD display and excellent cooling performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            coolers.Add(cooler);

            cooler = new Cooler()
            {
                Id = 5,
                Name = "Cooler Master Hyper 212 RGB Black Edition",
                Price = 44.99m,
                Type = CoolerType.Air,
                ImageUrl = "https://example.com/cooler-master-hyper-212-rgb-black-edition.jpg",
                Compatibility = "Intel LGA 2066 / 2011-v3 / 2011 / 1366 / 1151 / 1150 / 1155 / 1156 / 775 & AMD AM4 / AM3+ / AM3 / AM2+ / AM2 / FM2+ / FM2 / FM1",
                FanSize = 120,
                CoolerHeight = 159,
                Tdp = 150,
                Width = 120,
                Description = "The Cooler Master Hyper 212 RGB Black Edition is a mid-range air cooler with customizable RGB lighting and good cooling performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            coolers.Add(cooler);

            cooler = new Cooler()
            {
                Id = 6,
                Name = "Deepcool Castle 360EX",
                Price = 149.99m,
                Type = CoolerType.Water,
                ImageUrl = "https://example.com/deepcool-castle-360ex.jpg",
                Compatibility = "Intel LGA20XX/LGA1366/LGA115X & AMD AM4/AM3+/AM3/AM2+/AM2/FM2+/FM2/FM1",
                RadiatorSize = RadiatorSize._360,
                Tdp = 250,
                Description = "The Deepcool Castle 360EX is a high-end water cooler with a unique mirror finish and excellent cooling performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            coolers.Add(cooler);

            cooler = new Cooler()
            {
                Id = 7,
                Name = "Arctic Freezer 34 eSports DUO",
                Price = 49.99m,
                Type = CoolerType.Air,
                ImageUrl = "https://example.com/arctic-freezer-34-esports-duo.jpg",
                Compatibility = "Intel Socket 115x, 2011(-3), 2066 & AMD Socket AM4",
                FanSize = 120,
                CoolerHeight = 157,
                Tdp = 210,
                Width = 124,
                Description = "The Arctic Freezer 34 eSports DUO is a mid-range air cooler with a dual-fan design and good cooling performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            coolers.Add(cooler);

            cooler = new Cooler()
            {
                Id = 8,
                Name = "Thermaltake Floe Riing RGB 360 TT Premium Edition",
                Price = 199.99m,
                Type = CoolerType.Water,
                ImageUrl = "https://example.com/thermaltake-floe-riing-rgb-360-tt-premium-edition.jpg",
                Compatibility = "Intel LGA 2066/2011-3/2011/1366/1156/1155/1151/1150 & AMD AM4/FM2/FM1/AM3+/AM3/AM2+/AM2",
                RadiatorSize = RadiatorSize._360,
                Tdp = 250,
                Description = "The Thermaltake Floe Riing RGB 360 TT Premium Edition is a high-end water cooler with customizable RGB lighting and excellent cooling performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            coolers.Add(cooler);

            cooler = new Cooler()
            {
                Id = 9,
                Name = "Cooler Master MasterLiquid ML240L RGB V2",
                Price = 79.99m,
                Type = CoolerType.Water,
                ImageUrl = "https://example.com/cooler-master-masterliquid-ml240l-rgb-v2.jpg",
                Compatibility = "Intel LGA2066, LGA2011-v3, LGA2011, LGA1200, LGA1151, LGA1150, LGA1156, LGA1155, LGA1366 & AMD AM4, AM3+, AM3, AM2+, AM2, FM2+, FM2, FM1",
                RadiatorSize = RadiatorSize._240,
                Tdp = 200,
                Description = "The Cooler Master MasterLiquid ML240L RGB V2 is a mid-range water cooler with customizable RGB lighting and good cooling performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            coolers.Add(cooler);

            cooler = new Cooler()
            {
                Id = 10,
                Name = "Scythe Mugen 5 Rev.B",
                Price = 49.99m,
                Type = CoolerType.Air,
                ImageUrl = "https://example.com/scythe-mugen-5-rev-b.jpg",
                Compatibility = "Intel Socket LGA775, LGA1150, LGA1151, LGA1155, LGA1156, LGA1366, LGA2011(-3) Square ILM, LGA2066 & AMD Socket AM2(+), AM3(+), AM4, FM1, FM2(+)",
                FanSize = 120,
                CoolerHeight = 154.5,
                Tdp = 180,
                Width = 130,
                Description = "The Scythe Mugen 5 Rev.B is a mid-range air cooler with a quiet fan and good cooling performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            coolers.Add(cooler);

            return coolers.ToArray();
        }
    }
}
