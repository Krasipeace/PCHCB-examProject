namespace PCHCB.Web.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using System.Reflection;

    using PCHCB.Data.Models;

    public class PCHCBDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public PCHCBDbContext(DbContextOptions<PCHCBDbContext> options)
            : base(options)
        {
        }

        public DbSet<Case> Cases { get; set; } = null!;

        public DbSet<Cooler> Coolers { get; set; } = null!;

        public DbSet<Cpu> Cpus { get; set; } = null!;

        public DbSet<Gpu> Gpus { get; set; } = null!;

        public DbSet<Motherboard> Motherboards { get; set; } = null!;

        public DbSet<Psu> Psus { get; set; } = null!;

        public DbSet<Ram> Rams { get; set; } = null!;

        public DbSet<Storage> Storages { get; set; } = null!;

        public DbSet<PcConfiguration> PcConfigurations { get; set; } = null!;

        public DbSet<ConfigurationHardware> ConfigurationHardwares { get; set; } = null!;

        public DbSet<Provider> Providers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            Assembly configAssembly = Assembly.GetAssembly(typeof(PCHCBDbContext)) ??
                                      Assembly.GetExecutingAssembly();
            builder.ApplyConfigurationsFromAssembly(configAssembly);
        }
    }
}