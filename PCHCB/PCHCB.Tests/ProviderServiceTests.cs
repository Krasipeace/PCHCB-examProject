namespace PCHCB.Tests
{
    using Microsoft.EntityFrameworkCore;

    using NUnit.Framework;

    using PCHCB.Data;
    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.ViewModels.Enums;
    using PCHCB.Web.ViewModels.Home;

    [TestFixture]
    internal class ProviderServiceTests
    {
        private PCHCBDbContext dbContext;
        private IProviderService providerService;
        private const string testProviderId = "3f900985-864b-484d-8612-7e20b74613fb";

        [SetUp]
        public void Setup()
        {
            var option = new DbContextOptionsBuilder<PCHCBDbContext>()
                .UseInMemoryDatabase(databaseName: "PCHCBTestsDB")
                .Options;

            dbContext = new PCHCBDbContext(option);
            providerService = new ProviderService(dbContext);

            var providerUser = new ApplicationUser()
            {
                FirstName = "First",
                LastName = "Last",
                Email = "user@email.net",
            };

            var provider = new Provider()
            {
                Id = Guid.Parse(testProviderId.ToUpper()),
                PhoneNumber = "+359123456789",
                WebPage = "http://Providers.com/",
                LogoUrl = "http://Providers.com/image.png",
                Description = "Description1Description1Description1",
                UserId = providerUser.Id
            };

            dbContext.Providers.AddAsync(provider);
            dbContext.SaveChanges();
        }

        [Test]
        public async Task CreateProviderShouldCreateNewProviderWhenValidInputIsEntered()
        {
            var providerUser2 = new ApplicationUser()
            {
                FirstName = "Firstnamee",
                LastName = "Lastnamee",
                Email = "user2@email.net",
            };

            await this.dbContext.Users.AddAsync(providerUser2);
            await this.dbContext.SaveChangesAsync();

            var model = new BecomeProviderFormModel()
            {
                PhoneNumber = "+123456789",
                WebPage = "https://www.testpage.com",
                LogoUrl = "https://www.testpage.com/image.png",
                Description = "Test provider description",
            };

            await this.dbContext.Providers.AddAsync(new Provider()
            {
                Id = Guid.NewGuid(),
                PhoneNumber = "+123456789",
                WebPage = "https://www.testpage.com",
                LogoUrl = "https://www.testpage.com/image.png",
                Description = "Test provider description",
                UserId = providerUser2.Id
            });

            await this.dbContext.SaveChangesAsync();

            var modelId = (await this.dbContext.Providers.FirstAsync(p => p.PhoneNumber == "+123456789")).Id;
            await this.providerService.CreateProvider(modelId.ToString().ToUpper(), model);
            int countProviders = await this.dbContext.Providers.CountAsync();

            Assert.That(dbContext.Providers.CountAsync().Result, Is.EqualTo(countProviders));
            Assert.IsTrue(dbContext.Providers.Any(p => p.PhoneNumber == "+123456789"));
            Assert.IsTrue(dbContext.Providers.Any(p => p.WebPage == "https://www.testpage.com"));
            Assert.IsTrue(dbContext.Providers.Any(p => p.LogoUrl == "https://www.testpage.com/image.png"));
            Assert.IsTrue(dbContext.Providers.Any(p => p.Description == "Test provider description"));
            Assert.IsTrue(dbContext.Providers.Any(p => p.UserId == modelId));
        }
    }
}
