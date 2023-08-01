namespace PCHCB.Data
{
    using System.Reflection;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data.Models;

    using static PCHCB.Common.GeneralAppConstants;

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

        private ApplicationUser AdminUser { get; set; } = null!;
        private Provider AdminProvider { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            Assembly configAssembly = Assembly.GetAssembly(typeof(PCHCBDbContext)) ??
                                      Assembly.GetExecutingAssembly();
            builder.ApplyConfigurationsFromAssembly(configAssembly);

            SeedUsers();
            builder.Entity<ApplicationUser>().HasData(AdminUser);

            SeedProviders();
            builder.Entity<Provider>().HasData(AdminProvider);
        }

        private void SeedUsers()
        {
            AdminUser = new ApplicationUser
            {
                Id = Guid.Parse("73df6910-cc0d-4f98-90a0-748c29bbd618"),
                UserName = AdminEmail,
                Email = AdminEmail,
                EmailConfirmed = true,
                NormalizedEmail = AdminEmail.ToUpper(),
                NormalizedUserName = AdminEmail.ToUpper(),
                SecurityStamp = ("6789486A-AC97-43BF-BB19-A9928C1F1A54"),
                FirstName = "",
                LastName = "Admin",
            };

            AdminUser.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(AdminUser, "admin123");
        }

        private void SeedProviders()
        {
            AdminProvider = new Provider()
            {
                Id = Guid.Parse("028f3802-11ca-4f64-90d8-7bba2e3a74d5"),
                PhoneNumber = "+359123456789",
                UserId = AdminUser.Id,
                WebPage = "https://www.pchcb.com",
                LogoUrl = "https://www.pchcb.com/images/logo.png",
                Description = "This is Administrator account of pchcb app.",
            };
        }
    }
}