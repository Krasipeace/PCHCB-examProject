namespace PCHCB.Data.Configurations.SeedData
{
    using PCHCB.Data.Models.Enums;
    using PCHCB.Data.Models;

    public class SeedRams
    {
        public static List<Ram> GenerateRams()
        {
            var rams = new List<Ram>
            {
                new Ram
                {
                    Name = "Corsair Vengeance LPX 16GB DDR4 3200MHz C16",
                    Price = 79.99m,
                    Type = RamType.DDR4,
                    Frequency = 3200,
                    Capacity = 16,
                    Height = 31.2,
                    ModelNumber = "CMK16GX4M1D3200C16",
                    ImageUrl = "https://example.com/corsair-vengeance-lpx-16gb-ddr4-3200mhz-c16.jpg",
                    Description = "The Corsair Vengeance LPX 16GB DDR4 3200MHz C16 is a high-performance memory stick with excellent compatibility and reliability.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "G.Skill Ripjaws V 16GB DDR4 3600MHz C16",
                    Price = 89.99m,
                    Type = RamType.DDR4,
                    Frequency = 3600,
                    Capacity = 16,
                    Height = 42,
                    ModelNumber = "F4-3600C16D-16GVKC",
                    ImageUrl = "https://example.com/g-skill-ripjaws-v-16gb-ddr4-3600mhz-c16.jpg",
                    Description = "The G.Skill Ripjaws V 16GB DDR4 3600MHz C16 is a high-performance memory stick with excellent compatibility and reliability.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "Crucial Ballistix 16GB DDR4 3200MHz CL16",
                    Price = 74.99m,
                    Type = RamType.DDR4,
                    Frequency = 3200,
                    Capacity = 16,
                    Height = 39.17,
                    ModelNumber = "BL2K8G32C16U4B",
                    ImageUrl = "https://example.com/crucial-ballistix-16gb-ddr4-3200mhz-cl16.jpg",
                    Description = "The Crucial Ballistix 16GB DDR4 3200MHz CL16 is a high-performance memory stick with excellent compatibility and reliability.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "Kingston HyperX Fury 16GB DDR4 3200MHz CL16",
                    Price = 79.99m,
                    Type = RamType.DDR4,
                    Frequency = 3200,
                    Capacity = 16,
                    Height = 34,
                    ModelNumber = "HX432C16FB3/16",
                    ImageUrl = "https://example.com/kingston-hyperx-fury-16gb-ddr4-3200mhz-cl16.jpg",
                    Description = "The Kingston HyperX Fury 16GB DDR4 3200MHz CL16 is a high-performance memory stick with excellent compatibility and reliability.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "Team T-Force Vulcan Z 16GB DDR4 3200MHz CL16",
                    Price = 69.99m,
                    Type = RamType.DDR4,
                    Frequency = 3200,
                    Capacity = 16,
                    Height = 32,
                    ModelNumber = "TLZGD416G3200HC16CDC01",
                    ImageUrl = "https://example.com/team-t-force-vulcan-z-16gb-ddr4-3200mhz-cl16.jpg",
                    Description = "The Team T-Force Vulcan Z 16GB DDR4 3200MHz CL16 is a high-performance memory stick with excellent compatibility and reliability.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "Corsair Vengeance RGB Pro 16GB DDR4 3200MHz C16",
                    Price = 99.99m,
                    Type = RamType.DDR4,
                    Frequency = 3200,
                    Capacity = 16,
                    Height = 51,
                    ModelNumber = "CMW16GX4M2C3200C16",
                    ImageUrl = "https://example.com/corsair-vengeance-rgb-pro-16gb-ddr4-3200mhz-c16.jpg",
                    Description = "The Corsair Vengeance RGB Pro 16GB DDR4 3200MHz C16 is a high-performance memory stick with excellent compatibility and reliability.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "G.Skill Trident Z RGB 16GB DDR4 3200MHz C16",
                    Price = 99.99m,
                    Type = RamType.DDR4,
                    Frequency = 3200,
                    Capacity = 16,
                    Height = 44,
                    ModelNumber = "F4-3200C16D-16GTZR",
                    ImageUrl = "https://example.com/g-skill-trident-z-rgb-16gb-ddr4-3200mhz-c16.jpg",
                    Description = "The G.Skill Trident Z RGB 16GB DDR4 3200MHz C16 is a high-performance memory stick with excellent compatibility and reliability.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "Crucial Ballistix RGB 16GB DDR4 3200MHz CL16",
                    Price = 89.99m,
                    Type = RamType.DDR4,
                    Frequency = 3200,
                    Capacity = 16,
                    Height = 39.17,
                    ModelNumber = "BL2K8G32C16U4BL",
                    ImageUrl = "https://example.com/crucial-ballistix-rgb-16gb-ddr4-3200mhz-cl16.jpg",
                    Description = "The Crucial Ballistix RGB 16GB DDR4 3200MHz CL16 is a high-performance memory stick with excellent compatibility and reliability.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "Kingston HyperX Fury RGB 16GB DDR4 3200MHz CL16",
                    Price = 89.99m,
                    Type = RamType.DDR4,
                    Frequency = 3200,
                    Capacity = 16,
                    Height = 34,
                    ModelNumber = "HX432C16FB3A/16",
                    ImageUrl = "https://example.com/kingston-hyperx-fury-rgb-16gb-ddr4-3200mhz-cl16.jpg",
                    Description = "The Kingston HyperX Fury RGB 16GB DDR4 3200MHz CL16 is a high-performance memory stick with excellent compatibility and reliability.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "Team T-Force Delta RGB 16GB DDR4 3200MHz CL16",
                    Price = 79.99m,
                    Type = RamType.DDR4,
                    Frequency = 3200,
                    Capacity = 16,
                    Height = 44,
                    ModelNumber = "TF3D416G3200HC16CDC01",
                    ImageUrl = "https://example.com/team-t-force-delta-rgb-16gb-ddr4-3200mhz-cl16.jpg",
                    Description = "The Team T-Force Delta RGB 16GB DDR4 3200MHz CL16 is a high-performance memory stick with excellent compatibility and reliability.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                 new Ram
                {
                    Name = "Corsair Vengeance LPX 16GB DDR5",
                    Price = 199.99m,
                    Type = RamType.DDR5,
                    Frequency = 4800,
                    Capacity = 16,
                    Height = 31.2,
                    ModelNumber = "CMK16GX5M1Z4800C21",
                    ImageUrl = "https://example.com/corsair-vengeance-lpx-ddr5.jpg",
                    Description = "The Corsair Vengeance LPX 16GB DDR5 is a high-end memory stick with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "G.Skill Trident Z Royal 32GB DDR5",
                    Price = 399.99m,
                    Type = RamType.DDR5,
                    Frequency = 4800,
                    Capacity = 32,
                    Height = 44,
                    ModelNumber = "F6-4800C21D-32GTRS",
                    ImageUrl = "https://example.com/gskill-trident-z-royal-ddr5.jpg",
                    Description = "The G.Skill Trident Z Royal 32GB DDR5 is a high-end memory stick with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "Kingston HyperX Predator 64GB DDR5",
                    Price = 799.99m,
                    Type = RamType.DDR5,
                    Frequency = 5200,
                    Capacity = 64,
                    Height = 42.2,
                    ModelNumber = "HX452C21PB3K4/64",
                    ImageUrl = "https://example.com/kingston-hyperx-predator-ddr5.jpg",
                    Description = "The Kingston HyperX Predator 64GB DDR5 is a high-end memory stick with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "TeamGroup T-Force Xtreem ARGB 16GB DDR5",
                    Price = 199.99m,
                    Type = RamType.DDR5,
                    Frequency = 4800,
                    Capacity = 16,
                    Height = 48.7,
                    ModelNumber = "TFXAD516G4800HC21CDC01",
                    ImageUrl = "https://example.com/teamgroup-t-force-xtreem-argb-ddr5.jpg",
                    Description = "The TeamGroup T-Force Xtreem ARGB 16GB DDR5 is a high-end memory stick with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "Crucial Ballistix MAX 32GB DDR5",
                    Price = 399.99m,
                    Type = RamType.DDR5,
                    Frequency = 4800,
                    Capacity = 32,
                    Height = 40,
                    ModelNumber = "BLM32G4800C21",
                    ImageUrl = "https://example.com/crucial-ballistix-max-ddr5.jpg",
                    Description = "The Crucial Ballistix MAX 32GB DDR5 is a high-end memory stick with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "Patriot Viper RGB 16GB DDR5",
                    Price = 199.99m,
                    Type = RamType.DDR5,
                    Frequency = 4800,
                    Capacity = 16,
                    Height = 44,
                    ModelNumber = "PVR416G480C8K",
                    ImageUrl = "https://example.com/patriot-viper-rgb-ddr5.jpg",
                    Description = "The Patriot Viper RGB 16GB DDR5 is a high-end memory stick with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "ADATA XPG Spectrix D50 32GB DDR5",
                    Price = 399.99m,
                    Type = RamType.DDR5,
                    Frequency = 4800,
                    Capacity = 32,
                    Height = 44,
                    ModelNumber = "AX4U480038G20A-DT50",
                    ImageUrl = "https://example.com/adata-xpg-spectrix-d50-ddr5.jpg",
                    Description = "The ADATA XPG Spectrix D50 32GB DDR5 is a high-end memory stick with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "GeIL Orion RGB 16GB DDR5",
                    Price = 199.99m,
                    Type = RamType.DDR5,
                    Frequency = 4800,
                    Capacity = 16,
                    Height = 44,
                    ModelNumber = "GOC516GB4800C21DC",
                    ImageUrl = "https://example.com/geil-orion-rgb-ddr5.jpg",
                    Description = "The GeIL Orion RGB 16GB DDR5 is a high-end memory stick with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "Mushkin Redline Lumina 32GB DDR5",
                    Price = 399.99m,
                    Type = RamType.DDR5,
                    Frequency = 4800,
                    Capacity = 32,
                    Height = 44,
                    ModelNumber = "MR8U480038G21-DL",
                    ImageUrl = "https://example.com/mushkin-redline-lumina-ddr5.jpg",
                    Description = "The Mushkin Redline Lumina 32GB DDR5 is a high-end memory stick with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Ram
                {
                    Name = "ZADAK Shield RGB 16GB DDR5",
                    Price = 199.99m,
                    Type = RamType.DDR5,
                    Frequency = 4800,
                    Capacity = 16,
                    Height = 44,
                    ModelNumber = "ZS-4800-16G",
                    ImageUrl = "https://example.com/zadak-shield-rgb-ddr5.jpg",
                    Description = "The ZADAK Shield RGB 16GB DDR5 is a high-end memory stick with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },

        };

            return rams;
        }
    }
}
