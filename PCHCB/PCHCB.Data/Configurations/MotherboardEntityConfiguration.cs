namespace PCHCB.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;

    public class MotherboardEntityConfiguration : IEntityTypeConfiguration<Motherboard>
    {
        public void Configure(EntityTypeBuilder<Motherboard> builder)
        {
            builder
                .HasOne(p => p.Provider)
                .WithMany(m => m.ProviderMotherboards)
                .HasForeignKey(p => p.ProviderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(GenerateMotherboards());
        }

        private Motherboard[] GenerateMotherboards()
        {
            ICollection<Motherboard> motherboards = new List<Motherboard>();

            Motherboard motherboard;

            motherboard = new Motherboard()
            {
                Id = 1,
                Name = "ASUS ROG Strix B550-F Gaming",
                Price = 189.99m,
                FormFactor = MbFormFactor.ATX,
                Socket = "AM4",
                Chipset = "B550",
                RamType = RamType.DDR4,
                RamSlots = 4,
                RamCapacity = 128,
                SataSlots = 6,
                PcieType = InterfaceType.PCIExpress4,
                PcieSlots = 2,
                M2Slots = 2,
                ImageUrl = "https://example.com/asus-rog-strix-b550-f-gaming.jpg",
                Description = "The ASUS ROG Strix B550-F Gaming is a high-end motherboard with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            motherboards.Add(motherboard);

            motherboard = new Motherboard()
            {
                Id = 2,
                Name = "GIGABYTE B450 AORUS PRO WIFI",
                Price = 119.99m,
                FormFactor = MbFormFactor.ATX,
                Socket = "AM4",
                Chipset = "B450",
                RamType = RamType.DDR4,
                RamSlots = 4,
                RamCapacity = 128,
                SataSlots = 6,
                PcieType = InterfaceType.PCIExpress3,
                PcieSlots = 2,
                M2Slots = 2,
                ImageUrl = "https://example.com/gigabyte-b450-aorus-pro-wifi.jpg",
                Description = "The GIGABYTE B450 AORUS PRO WIFI is a mid-range motherboard with good performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            motherboards.Add(motherboard);

            motherboard = new Motherboard()
            {
                Id = 3,
                Name = "ASUS Prime Z490-A",
                Price = 229.99m,
                FormFactor = MbFormFactor.ATX,
                Socket = "LGA1200",
                Chipset = "Z490",
                RamType = RamType.DDR4,
                RamSlots = 4,
                RamCapacity = 128,
                SataSlots = 6,
                PcieType = InterfaceType.PCIExpress3,
                PcieSlots = 3,
                M2Slots = 2,
                ImageUrl = "https://example.com/asus-prime-z490-a.jpg",
                Description = "The ASUS Prime Z490-A is a high-end motherboard with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            motherboards.Add(motherboard);

            motherboard = new Motherboard()
            {
                Id = 4,
                Name = "MSI MPG B550 Gaming Edge WiFi",
                Price = 179.99m,
                FormFactor = MbFormFactor.ATX,
                Socket = "AM4",
                Chipset = "B550",
                RamType = RamType.DDR4,
                RamSlots = 4,
                RamCapacity = 128,
                SataSlots = 6,
                PcieType = InterfaceType.PCIExpress4,
                PcieSlots = 2,
                M2Slots = 2,
                ImageUrl = "https://example.com/msi-mpg-b550-gaming-edge-wifi.jpg",
                Description = "The MSI MPG B550 Gaming Edge WiFi is a high-end motherboard with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            motherboards.Add(motherboard);

            motherboard = new Motherboard()
            {
                Id = 5,
                Name = "ASRock B450M PRO4",
                Price = 79.99m,
                FormFactor = MbFormFactor.MicroATX,
                Socket = "AM4",
                Chipset = "B450",
                RamType = RamType.DDR4,
                RamSlots = 4,
                RamCapacity = 64,
                SataSlots = 4,
                PcieType = InterfaceType.PCIExpress3,
                PcieSlots = 2,
                M2Slots = 1,
                ImageUrl = "https://example.com/asrock-b450m-pro4.jpg",
                Description = "The ASRock B450M PRO4 is a budget motherboard with decent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            motherboards.Add(motherboard);

            motherboard = new Motherboard()
            {
                Id = 6,
                Name = "ASUS ROG Strix X570-E Gaming",
                Price = 299.99m,
                FormFactor = MbFormFactor.ATX,
                Socket = "AM4",
                Chipset = "X570",
                RamType = RamType.DDR4,
                RamSlots = 4,
                RamCapacity = 128,
                SataSlots = 8,
                PcieType = InterfaceType.PCIExpress4,
                PcieSlots = 3,
                M2Slots = 2,
                ImageUrl = "https://example.com/asus-rog-strix-x570-e-gaming.jpg",
                Description = "The ASUS ROG Strix X570-E Gaming is a high-end motherboard with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            motherboards.Add(motherboard);

            motherboard = new Motherboard()
            {
                Id = 7,
                Name = "ASUS ROG Strix B550-I Gaming",
                Price = 229.99m,
                FormFactor = MbFormFactor.MiniITX,
                Socket = "AM4",
                Chipset = "B550",
                RamType = RamType.DDR4,
                RamSlots = 2,
                RamCapacity = 64,
                SataSlots = 4,
                PcieType = InterfaceType.PCIExpress4,
                PcieSlots = 1,
                M2Slots = 2,
                ImageUrl = "https://example.com/asus-rog-strix-b550-i-gaming.jpg",
                Description = "The ASUS ROG Strix B550-I Gaming is a high-end motherboard with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            motherboards.Add(motherboard);

            return motherboards.ToArray();
        }
    }
}
