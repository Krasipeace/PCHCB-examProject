namespace PCHCB.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using PCHCB.Data.Models;

    public class PcConfigEntityConfiguration : IEntityTypeConfiguration<PcConfiguration>
    {
        public void Configure(EntityTypeBuilder<PcConfiguration> builder)
        {
            builder
                .HasOne(pc => pc.Builder)
                .WithMany(u => u.SavedConfigurations)
                .HasForeignKey(pc => pc.BuilderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
