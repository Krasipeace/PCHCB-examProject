namespace PCHCB.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;

    public class StorageEntityConfiguration : IEntityTypeConfiguration<Storage>
    {
        public void Configure(EntityTypeBuilder<Storage> builder)
        {
            builder
                .HasOne(p => p.Provider)
                .WithMany(s => s.ProviderStorages)
                .HasForeignKey(p => p.ProviderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(GenerateStorages());
        }

        private Storage[] GenerateStorages()
        {
            ICollection<Storage> storages = new HashSet<Storage>();

            Storage storage;

            storage = new Storage()
            {
                Id = 1,
                Name = "Samsung 860 EVO 1TB SSD",
                Price = 129.99m,
                Capacity = 1000,
                Type = StorageType.SSD,
                ImageUrl = "https://example.com/samsung-860-evo-ssd.jpg",
                Description = "The Samsung 860 EVO 1TB SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            storage = new Storage()
            {
                Id = 2,
                Name = "Crucial MX500 500GB SSD",
                Price = 69.99m,
                Capacity = 500,
                Type = StorageType.SSD,
                ImageUrl = "https://example.com/crucial-mx500-ssd.jpg",
                Description = "The Crucial MX500 500GB SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            storage = new Storage()
            {
                Id = 3,
                Name = "Western Digital Blue 2TB SSD",
                Price = 229.99m,
                Capacity = 2000,
                Type = StorageType.SSD,
                ImageUrl = "https://example.com/western-digital-blue-ssd.jpg",
                Description = "The Western Digital Blue 2TB SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            storage = new Storage()
            {
                Id = 4,
                Name = "ADATA SU800 1TB SSD",
                Price = 99.99m,
                Capacity = 1000,
                Type = StorageType.SSD,
                ImageUrl = "https://example.com/adata-su800-ssd.jpg",
                Description = "The ADATA SU800 1TB SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            storage = new Storage()
            {
                Id = 5,
                Name = "SanDisk Ultra 3D 2TB SSD",
                Price = 249.99m,
                Capacity = 2000,
                Type = StorageType.SSD,
                ImageUrl = "https://example.com/sandisk-ultra-3d-ssd.jpg",
                Description = "The SanDisk Ultra 3D 2TB SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            storage = new Storage()
            {
                Id = 6,
                Name = "Intel 665p 1TB SSD",
                Price = 109.99m,
                Capacity = 1000,
                Type = StorageType.SSD,
                ImageUrl = "https://example.com/intel-665p-ssd.jpg",
                Description = "The Intel 665p 1TB SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            storage = new Storage()
            {
                Id = 7,
                Name = "Seagate Barracuda Q1 2TB SSD",
                Price = 219.99m,
                Capacity = 2000,
                Type = StorageType.SSD,
                ImageUrl = "https://example.com/seagate-barracuda-q1-ssd.jpg",
                Description = "The Seagate Barracuda Q1 2TB SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            storage = new Storage()
            {
                Id = 8,
                Name = "SK hynix Gold S31 1TB SSD",
                Price = 109.99m,
                Capacity = 1000,
                Type = StorageType.SSD,
                ImageUrl = "https://example.com/sk-hynix-gold-s31-ssd.jpg",
                Description = "The SK hynix Gold S31 1TB SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            storage = new Storage()
            {
                Id = 9,
                Name = "TeamGroup T-Force Vulcan G 2TB SSD",
                Price = 249.99m,
                Capacity = 2000,
                Type = StorageType.SSD,
                ImageUrl = "https://example.com/teamgroup-t-force-vulcan-g-ssd.jpg",
                Description = "The TeamGroup T-Force Vulcan G 2TB SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            storage = new Storage()
            {
                Id = 10,
                Name = "PNY XLR8 CS3030 1TB SSD",
                Price = 119.99m,
                Capacity = 1000,
                Type = StorageType.SSD,
                ImageUrl = "https://example.com/pny-xlr8-cs3030-ssd.jpg",
                Description = "The PNY XLR8 CS3030 1TB SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            storage = new Storage()
            {
                Id = 11,
                Name = "Samsung 970 EVO Plus 1TB M.2 NVMe SSD",
                Price = 149.99m,
                Capacity = 1000,
                Type = StorageType.M2,
                ImageUrl = "https://example.com/samsung-970-evo-plus-m2.jpg",
                Description = "The Samsung 970 EVO Plus 1TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            storage = new Storage()
            {
                Id = 12,
                Name = "Crucial P5 2TB M.2 NVMe SSD",
                Price = 299.99m,
                Capacity = 2000,
                Type = StorageType.M2,
                ImageUrl = "https://example.com/crucial-p5-m2.jpg",
                Description = "The Crucial P5 2TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            storage = new Storage()
            {
                Id = 13,
                Name = "Sabrent Rocket Q 1TB M.2 NVMe SSD",
                Price = 129.99m,
                Capacity = 1000,
                Type = StorageType.M2,
                ImageUrl = "https://example.com/sabrent-rocket-q-m2.jpg",
                Description = "The Sabrent Rocket Q 1TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            storage = new Storage()
            {
                Id = 14,
                Name = "ADATA XPG SX8200 Pro 2TB M.2 NVMe SSD",
                Price = 299.99m,
                Capacity = 2000,
                Type = StorageType.M2,
                ImageUrl = "https://example.com/adata-xpg-sx8200-pro-m2.jpg",
                Description = "The ADATA XPG SX8200 Pro 2TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            storage = new Storage()
            {
                Id = 15,
                Name = "Intel 660p 1TB M.2 NVMe SSD",
                Price = 119.99m,
                Capacity = 1000,
                Type = StorageType.M2,
                ImageUrl = "https://example.com/intel-660p-m2.jpg",
                Description = "The Intel 660p 1TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            storage = new Storage()
            {
                Id = 16,
                Name = "Gigabyte AORUS NVMe Gen4 2TB M.2 NVMe SSD",
                Price = 399.99m,
                Capacity = 2000,
                Type = StorageType.M2,
                ImageUrl = "https://example.com/gigabyte-aorus-nvme-gen4-m2.jpg",
                Description = "The Gigabyte AORUS NVMe Gen4 2TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            storage = new Storage()
            {
                Id = 17,
                Name = "Seagate FireCuda 520 1TB M.2 NVMe SSD",
                Price = 199.99m,
                Capacity = 1000,
                Type = StorageType.M2,
                ImageUrl = "https://example.com/seagate-firecuda-520-m2.jpg",
                Description = "The Seagate FireCuda 520 1TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            storage = new Storage()
            {
                Id = 18,
                Name = "SK hynix Gold P31 1TB M.2 NVMe SSD",
                Price = 129.99m,
                Capacity = 1000,
                Type = StorageType.M2,
                ImageUrl = "https://example.com/sk-hynix-gold-p31-m2.jpg",
                Description = "The SK hynix Gold P31 1TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            storages.Add(storage);

            return storages.ToArray();
        }
    }
}
