namespace PCHCB.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;

    public class GpuEntityConfiguration : IEntityTypeConfiguration<Gpu>
    {
        public void Configure(EntityTypeBuilder<Gpu> builder)
        {
            builder
                .HasOne(p => p.Provider)
                .WithMany(g => g.ProviderGpus)
                .HasForeignKey(p => p.ProviderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(GenerateGpus());
        }

        private Gpu[] GenerateGpus()
        {
            ICollection<Gpu> gpus = new HashSet<Gpu>();

            Gpu gpu = new Gpu()
            {
                Id = 1,
                Name = "NVIDIA GeForce RTX 3080",
                Price = 699.99m,
                Memory = 10,
                Interface = InterfaceType.PCIExpress4,
                Length = 285,
                SlotsRequired = 2.5,
                PowerConsumption = 320,
                ImageUrl = "https://example.com/nvidia-geforce-rtx-3080.jpg",
                NvidiaConnector = false,
                Description = "The NVIDIA GeForce RTX 3080 is a high-end graphics card with excellent gaming performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            gpus.Add(gpu);

            gpu = new Gpu()
            {
                Id = 2,
                Name = "AMD Radeon RX 6800 XT",
                Price = 649.99m,
                Memory = 16,
                Interface = InterfaceType.PCIExpress4,
                Length = 267,
                SlotsRequired = 2.5,
                PowerConsumption = 300,
                ImageUrl = "https://example.com/amd-radeon-rx-6800-xt.jpg",
                NvidiaConnector = false,
                Description = "The AMD Radeon RX 6800 XT is a high-end graphics card with excellent gaming performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            gpus.Add(gpu);

            gpu = new Gpu()
            {
                Id = 3,
                Name = "NVIDIA GeForce RTX 3070",
                Price = 499.99m,
                Memory = 8,
                Interface = InterfaceType.PCIExpress4,
                Length = 242,
                SlotsRequired = 2,
                PowerConsumption = 220,
                ImageUrl = "https://example.com/nvidia-geforce-rtx-3070.jpg",
                NvidiaConnector = false,
                Description = "The NVIDIA GeForce RTX 3070 is a high-performance graphics card with excellent gaming performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            gpus.Add(gpu);

            gpu = new Gpu()
            {
                Id = 4,
                Name = "AMD Radeon RX 6700 XT",
                Price = 479.99m,
                Memory = 12,
                Interface = InterfaceType.PCIExpress4,
                Length = 267,
                SlotsRequired = 2.5,
                PowerConsumption = 230,
                ImageUrl = "https://example.com/amd-radeon-rx-6700-xt.jpg",
                NvidiaConnector = false,
                Description = "The AMD Radeon RX 6700 XT is a high-performance graphics card with excellent gaming performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            gpus.Add(gpu);

            gpu = new Gpu()
            {
                Id = 5,
                Name = "NVIDIA GeForce RTX 3060 Ti",
                Price = 399.99m,
                Memory = 8,
                Interface = InterfaceType.PCIExpress4,
                Length = 242,
                SlotsRequired = 2,
                PowerConsumption = 200,
                ImageUrl = "https://example.com/nvidia-geforce-rtx-3060-ti.jpg",
                NvidiaConnector = false,
                Description = "The NVIDIA GeForce RTX 3060 Ti is a high-performance graphics card with excellent gaming performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            gpus.Add(gpu);

            gpu = new Gpu()
            {
                Id = 6,
                Name = "NVIDIA GeForce RTX 3090",
                Price = 1499.99m,
                Memory = 24,
                Interface = InterfaceType.PCIExpress4,
                Length = 313,
                SlotsRequired = 3,
                PowerConsumption = 350,
                ImageUrl = "https://example.com/nvidia-geforce-rtx-3090.jpg",
                NvidiaConnector = false,
                Description = "The NVIDIA GeForce RTX 3090 is a high-end graphics card with excellent gaming performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            gpus.Add(gpu);

            gpu = new Gpu()
            {
                Id = 7,
                Name = "AMD Radeon RX 6900 XT",
                Price = 999.99m,
                Memory = 16,
                Interface = InterfaceType.PCIExpress4,
                Length = 267,
                SlotsRequired = 2.5,
                PowerConsumption = 300,
                ImageUrl = "https://example.com/amd-radeon-rx-6900-xt.jpg",
                NvidiaConnector = false,
                Description = "The AMD Radeon RX 6900 XT is a high-end graphics card with excellent gaming performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            gpus.Add(gpu);

            gpu = new Gpu()
            {
                Id = 8,
                Name = "NVIDIA GeForce RTX 4090",
                Price = 2499.99m,
                Memory = 48,
                Interface = InterfaceType.PCIExpress5,
                Length = 313,
                SlotsRequired = 3,
                PowerConsumption = 500,
                ImageUrl = "https://example.com/nvidia-geforce-rtx-4090.jpg",
                NvidiaConnector = true,
                Description = "The NVIDIA GeForce RTX 4090 is a high-end graphics card with excellent gaming performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            gpus.Add(gpu);

            return gpus.ToArray();
        }
    }
}
