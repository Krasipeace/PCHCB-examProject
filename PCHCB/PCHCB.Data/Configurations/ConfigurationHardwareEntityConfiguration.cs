namespace PCHCB.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class ConfigurationHardwareEntityConfiguration : IEntityTypeConfiguration<ConfigurationHardware>
    {
        public void Configure(EntityTypeBuilder<ConfigurationHardware> builder)
        {
            builder
                .HasKey(ch => new { 
                    ch.PcConfigurationId, 
                    ch.CaseId,
                    ch.CoolerId,
                    ch.CpuId,
                    ch.GpuId,
                    ch.MotherboardId,
                    ch.PsuId,
                    ch.RamId,
                    ch.StorageId
                    });

            builder
                .HasOne(c => c.Case)
                .WithMany(ch => ch.ConfigurationHardwares)
                .HasForeignKey(c => c.CaseId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.Cooler)
                .WithMany(ch => ch.ConfigurationHardwares)
                .HasForeignKey(c => c.CoolerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.Cpu)
                .WithMany(ch => ch.ConfigurationHardwares)
                .HasForeignKey(c => c.CpuId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(g => g.Gpu)
                .WithMany(ch => ch.ConfigurationHardwares)
                .HasForeignKey(g => g.GpuId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(m => m.Motherboard)
                .WithMany(ch => ch.ConfigurationHardwares)
                .HasForeignKey(m => m.MotherboardId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p => p.Psu)
                .WithMany(ch => ch.ConfigurationHardwares)
                .HasForeignKey(p => p.PsuId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(r => r.Ram)
                .WithMany(ch => ch.ConfigurationHardwares)
                .HasForeignKey(r => r.RamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.Storage)
                .WithMany(ch => ch.ConfigurationHardwares)
                .HasForeignKey(s => s.StorageId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(pc => pc.PcConfiguration)
                .WithMany(ch => ch.ConfigurationHardwares)
                .HasForeignKey(pc => pc.PcConfigurationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
