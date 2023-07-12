namespace PCHCB.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;

    public class CpuEntityConfiguration : IEntityTypeConfiguration<Cpu>
    {
        public void Configure(EntityTypeBuilder<Cpu> builder)
        {
            builder
                .HasOne(c => c.Provider)
                .WithMany(p => p.ProviderCpus)
                .HasForeignKey(c => c.ProviderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(GenerateCPUs());
        }

        private Cpu[] GenerateCPUs()
        {
            ICollection<Cpu> cpus = new List<Cpu>();

            Cpu cpu = new Cpu()
            {
                Id = 1,
                Name = "AMD Ryzen 5 5600X",
                Price = 299.99m,
                Socket = "AM4",
                Cores = 6,
                Threads = 12,
                Frequency = 3700,
                TurboFrequency = 4600,
                Cache = 35,
                Tdp = 65,
                RamFrequency = 3200,
                RamType = RamType.DDR4,
                ImageUrl = "https://example.com/amd-ryzen-5-5600x.jpg",
                Description = "The AMD Ryzen 5 5600X is a powerful 6-core processor with excellent single-threaded performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            cpus.Add(cpu);

            cpu = new Cpu()
            {
                Id = 2,
                Name = "Intel Core i5-11600K",
                Price = 269.99m,
                Socket = "LGA1200",
                Cores = 6,
                Threads = 12,
                Frequency = 3900,
                TurboFrequency = 4900,
                Cache = 12,
                Tdp = 125,
                RamFrequency = 3200,
                RamType = RamType.DDR4,
                ImageUrl = "https://example.com/intel-core-i5-11600k.jpg",
                Description = "The Intel Core i5-11600K is a high-performance 6-core processor with excellent gaming performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            cpus.Add(cpu);

            cpu = new Cpu()
            {
                Id = 3,
                Name = "AMD Ryzen 7 5800X",
                Price = 449.99m,
                Socket = "AM4",
                Cores = 8,
                Threads = 16,
                Frequency = 3800,
                TurboFrequency = 4700,
                Cache = 36,
                Tdp = 105,
                RamFrequency = 3200,
                RamType = RamType.DDR4,
                ImageUrl = "https://example.com/amd-ryzen-7-5800x.jpg",
                Description = "The AMD Ryzen 7 5800X is a high-performance 8-core processor with excellent multi-threaded performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            cpus.Add(cpu);

            cpu = new Cpu()
            {
                Id = 4,
                Name = "Intel Core i9-11900K",
                Price = 599.99m,
                Socket = "LGA1200",
                Cores = 8,
                Threads = 16,
                Frequency = 3500,
                TurboFrequency = 5300,
                Cache = 16,
                Tdp = 125,
                RamFrequency = 3200,
                RamType = RamType.DDR4,
                ImageUrl = "https://example.com/intel-core-i9-11900k.jpg",
                Description = "The Intel Core i9-11900K is a high-end 8-core processor with excellent gaming and multi-threaded performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            cpus.Add(cpu);

            cpu = new Cpu()
            {
                Id = 5,
                Name = "AMD Ryzen 9 5950X",
                Price = 799.99m,
                Socket = "AM4",
                Cores = 16,
                Threads = 32,
                Frequency = 3400,
                TurboFrequency = 4900,
                Cache = 72,
                Tdp = 105,
                RamFrequency = 3200,
                RamType = RamType.DDR4,
                ImageUrl = "https://example.com/amd-ryzen-9-5950x.jpg",
                Description = "The AMD Ryzen 9 5950X is a high-end 16-core processor with excellent multi-threaded performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            cpus.Add(cpu);

            cpu = new Cpu()
            {
                Id = 6,
                Name = "Intel Core i9-10900K",
                Price = 529.99m,
                Socket = "LGA1200",
                Cores = 10,
                Threads = 20,
                Frequency = 3700,
                TurboFrequency = 5300,
                Cache = 20,
                Tdp = 125,
                RamFrequency = 3200,
                RamType = RamType.DDR4,
                ImageUrl = "https://example.com/intel-core-i9-10900k.jpg",
                Description = "The Intel Core i9-10900K is a high-end 10-core processor with excellent gaming and multi-threaded performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            cpus.Add(cpu);

            cpu = new Cpu()
            {
                Id = 7,
                Name = "AMD Ryzen 9 5900X",
                Price = 549.99m,
                Socket = "AM4",
                Cores = 12,
                Threads = 24,
                Frequency = 3700,
                TurboFrequency = 4800,
                Cache = 70,
                Tdp = 105,
                RamFrequency = 3200,
                RamType = RamType.DDR4,
                ImageUrl = "https://example.com/amd-ryzen-9-5900x.jpg",
                Description = "The AMD Ryzen 9 5900X is a high-end 12-core processor with excellent multi-threaded performance.",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse("e92e7beb-55d6-4d18-a99d-3ed3411058f5")
            };
            cpus.Add(cpu);

            return cpus.ToArray();
        }
    }
}
