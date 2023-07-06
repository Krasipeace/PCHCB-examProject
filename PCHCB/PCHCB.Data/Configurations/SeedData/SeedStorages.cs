namespace PCHCB.Data.Configurations.SeedData
{
    using PCHCB.Data.Models.Enums;
    using PCHCB.Data.Models;

    public class SeedStorages
    {
        public static List<Storage> GenerateStorages()
        {
            var storages = new List<Storage>
            {
                new Storage
                {
                    Name = "Samsung 860 EVO 1TB SSD",
                    Price = 129.99m,
                    Capacity = 1000,
                    Type = StorageType.SSD,
                    ImageUrl = "https://example.com/samsung-860-evo-ssd.jpg",
                    Description = "The Samsung 860 EVO 1TB SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "Crucial MX500 500GB SSD",
                    Price = 69.99m,
                    Capacity = 500,
                    Type = StorageType.SSD,
                    ImageUrl = "https://example.com/crucial-mx500-ssd.jpg",
                    Description = "The Crucial MX500 500GB SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "Western Digital Blue 2TB SSD",
                    Price = 229.99m,
                    Capacity = 2000,
                    Type = StorageType.SSD,
                    ImageUrl = "https://example.com/western-digital-blue-ssd.jpg",
                    Description = "The Western Digital Blue 2TB SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "ADATA SU800 1TB SSD",
                    Price = 99.99m,
                    Capacity = 1000,
                    Type = StorageType.SSD,
                    ImageUrl = "https://example.com/adata-su800-ssd.jpg",
                    Description = "The ADATA SU800 1TB SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "SanDisk Ultra 3D 2TB SSD",
                    Price = 249.99m,
                    Capacity = 2000,
                    Type = StorageType.SSD,
                    ImageUrl = "https://example.com/sandisk-ultra-3d-ssd.jpg",
                    Description = "The SanDisk Ultra 3D 2TB SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "Intel 665p 1TB SSD",
                    Price = 109.99m,
                    Capacity = 1000,
                    Type = StorageType.SSD,
                    ImageUrl = "https://example.com/intel-665p-ssd.jpg",
                    Description = "The Intel 665p 1TB SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "Seagate Barracuda Q1 2TB SSD",
                    Price = 219.99m,
                    Capacity = 2000,
                    Type = StorageType.SSD,
                    ImageUrl = "https://example.com/seagate-barracuda-q1-ssd.jpg",
                    Description = "The Seagate Barracuda Q1 2TB SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "SK hynix Gold S31 1TB SSD",
                    Price = 109.99m,
                    Capacity = 1000,
                    Type = StorageType.SSD,
                    ImageUrl = "https://example.com/sk-hynix-gold-s31-ssd.jpg",
                    Description = "The SK hynix Gold S31 1TB SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "TeamGroup T-Force Vulcan G 2TB SSD",
                    Price = 249.99m,
                    Capacity = 2000,
                    Type = StorageType.SSD,
                    ImageUrl = "https://example.com/teamgroup-t-force-vulcan-g-ssd.jpg",
                    Description = "The TeamGroup T-Force Vulcan G 2TB SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "PNY XLR8 CS3030 1TB SSD",
                    Price = 119.99m,
                    Capacity = 1000,
                    Type = StorageType.SSD,
                    ImageUrl = "https://example.com/pny-xlr8-cs3030-ssd.jpg",
                    Description = "The PNY XLR8 CS3030 1TB SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "Samsung 970 EVO Plus 1TB M.2 NVMe SSD",
                    Price = 149.99m,
                    Capacity = 1000,
                    Type = StorageType.M2,
                    ImageUrl = "https://example.com/samsung-970-evo-plus-m2.jpg",
                    Description = "The Samsung 970 EVO Plus 1TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "Western Digital Black SN750 500GB M.2 NVMe SSD",
                    Price = 99.99m,
                    Capacity = 500,
                    Type = StorageType.M2,
                    ImageUrl = "https://example.com/western-digital-black-sn750-m2.jpg",
                    Description = "The Western Digital Black SN750 500GB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "Crucial P5 2TB M.2 NVMe SSD",
                    Price = 299.99m,
                    Capacity = 2000,
                    Type = StorageType.M2,
                    ImageUrl = "https://example.com/crucial-p5-m2.jpg",
                    Description = "The Crucial P5 2TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "Sabrent Rocket Q 1TB M.2 NVMe SSD",
                    Price = 129.99m,
                    Capacity = 1000,
                    Type = StorageType.M2,
                    ImageUrl = "https://example.com/sabrent-rocket-q-m2.jpg",
                    Description = "The Sabrent Rocket Q 1TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "ADATA XPG SX8200 Pro 2TB M.2 NVMe SSD",
                    Price = 299.99m,
                    Capacity = 2000,
                    Type = StorageType.M2,
                    ImageUrl = "https://example.com/adata-xpg-sx8200-pro-m2.jpg",
                    Description = "The ADATA XPG SX8200 Pro 2TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "Intel 660p 1TB M.2 NVMe SSD",
                    Price = 119.99m,
                    Capacity = 1000,
                    Type = StorageType.M2,
                    ImageUrl = "https://example.com/intel-660p-m2.jpg",
                    Description = "The Intel 660p 1TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "Gigabyte AORUS NVMe Gen4 2TB M.2 NVMe SSD",
                    Price = 399.99m,
                    Capacity = 2000,
                    Type = StorageType.M2,
                    ImageUrl = "https://example.com/gigabyte-aorus-nvme-gen4-m2.jpg",
                    Description = "The Gigabyte AORUS NVMe Gen4 2TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "Seagate FireCuda 520 1TB M.2 NVMe SSD",
                    Price = 199.99m,
                    Capacity = 1000,
                    Type = StorageType.M2,
                    ImageUrl = "https://example.com/seagate-firecuda-520-m2.jpg",
                    Description = "The Seagate FireCuda 520 1TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "SK hynix Gold P31 1TB M.2 NVMe SSD",
                    Price = 129.99m,
                    Capacity = 1000,
                    Type = StorageType.M2,
                    ImageUrl = "https://example.com/sk-hynix-gold-p31-m2.jpg",
                    Description = "The SK hynix Gold P31 1TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                },
                new Storage
                {
                    Name = "TeamGroup T-Force Cardea Zero Z440 2TB M.2 NVMe SSD",
                    Price = 399.99m,
                    Capacity = 2000,
                    Type = StorageType.M2,
                    ImageUrl = "https://example.com/teamgroup-t-force-cardea-zero-z440-m2.jpg",
                    Description = "The TeamGroup T-Force Cardea Zero Z440 2TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                    AddedOn = DateTime.UtcNow,
                    ProviderId = Guid.NewGuid()
                }
            };

            return storages;
        }
    }
}
