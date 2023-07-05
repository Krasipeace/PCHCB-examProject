namespace PCHCB.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class PcConfigEntityConfiguration : IEntityTypeConfiguration<PcConfiguration>
    {
        public void Configure(EntityTypeBuilder<PcConfiguration> builder)
        {
            builder
                .HasOne(c => c.Case)
                .WithOne(pc => pc.PcConfiguration)
                .HasForeignKey<Case>(c => c.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.Cooler)
                .WithOne(pc => pc.PcConfiguration)
                .HasForeignKey<Cooler>(c => c.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.Cpu)
                .WithOne(pc => pc.PcConfiguration)
                .HasForeignKey<Cpu>(c => c.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(g => g.Gpu)
                .WithOne(pc => pc.PcConfiguration)
                .HasForeignKey<Gpu>(g => g.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(m => m.Motherboard)
                .WithOne(pc => pc.PcConfiguration)
                .HasForeignKey<Motherboard>(m => m.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p => p.Psu)
                .WithOne(pc => pc.PcConfiguration)
                .HasForeignKey<Psu>(p => p.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(r => r.Ram)
                .WithOne(pc => pc.PcConfiguration)
                .HasForeignKey<Ram>(r => r.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.Storage)
                .WithOne(pc => pc.PcConfiguration)
                .HasForeignKey<Storage>(s => s.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
