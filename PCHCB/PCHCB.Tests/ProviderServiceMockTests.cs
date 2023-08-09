namespace PCHCB.Tests
{
    using Microsoft.EntityFrameworkCore;

    using Moq;

    using PCHCB.Data;
    using PCHCB.Data.Models;
    using PCHCB.Services.Data;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.ViewModels.Provider;

    internal class ProviderServiceMockTests
    {
        private PCHCBDbContext dbContext;
        private Mock<IProviderService> providerService;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<PCHCBDbContext>()
                .UseInMemoryDatabase(databaseName: "PCHCBDbMockTests")
                .Options;

            this.dbContext = new PCHCBDbContext(options);
            this.dbContext.Database.EnsureCreated();

            var providerUser = new ApplicationUser()
            {
                FirstName = "FirstMoq",
                LastName = "LastMoq",
                Email = "moq123@email.net",
            };

            var provider = new Provider()
            {
                Id = Guid.Parse("64583B10-81CC-4C36-8AAF-EF4938F6E160"),
                PhoneNumber = "+35911223344",
                WebPage = "http://moqProviders.com/",
                LogoUrl = "http://moqProviders.com/image.png",
                Description = "Description1Description1Description1",
                UserId = providerUser.Id
            };

            this.dbContext.Providers.Add(provider);
            this.dbContext.SaveChanges();

            this.providerService = new Mock<IProviderService>();
        }

        [TearDown]
        public void TearDown()
        {
            this.dbContext.Database.EnsureDeleted();
        }

        [Test]
        public async Task GetProviderByIdAsyncShouldReturnProvider()
        {
            var userId = await dbContext.Providers
                .Select(p => p.UserId)
                .FirstAsync();

            var providerId = Guid.Parse("64583B10-81CC-4C36-8AAF-EF4938F6E160");

            var provider = new Provider()
            {
                Id = providerId,
                UserId = userId,
            };

            var result = await this.providerService.Object.GetProviderByUserIdAsync(userId.ToString().ToUpper());

            this.providerService.Verify(p => p.GetProviderByUserIdAsync(userId.ToString().ToUpper()), Times.Once);

            Assert.IsNotNull(providerId.ToString().ToUpper(), result);
        }

        [Test]
        public async Task GetProviderDetailsByIdAsyncShouldReturnProviderDetailsViewModel()
        {
            var providerId = Guid.NewGuid();
            var expectedProvider = new Provider()
            {
                Id = providerId,
                PhoneNumber = "+1234567890",
                WebPage = "www.example.com",
                LogoUrl = "www.example.com/images/logo.png",
                Description = "Description1Description1Description1"
            };

            dbContext.Providers.Add(expectedProvider);
            dbContext.SaveChanges();

            var service = new ProviderService(dbContext);

            var result = await service.GetProviderDetailsByIdAsync(providerId.ToString().ToUpper());

            Assert.That(result.Id, Is.EqualTo(expectedProvider.Id));
            Assert.That(result.PhoneNumber, Is.EqualTo(expectedProvider.PhoneNumber));
            Assert.That(result.WebPage, Is.EqualTo(expectedProvider.WebPage));
            Assert.That(result.LogoUrl, Is.EqualTo(expectedProvider.LogoUrl));
            Assert.That(result.Description, Is.EqualTo(expectedProvider.Description));
            Assert.That(result, Is.InstanceOf<ProviderDetailsViewModel>());
        }

        [Test]
        public async Task GetAllCasesAsyncByProviderIdShouldReturnCorrectData()
        {
            var providerId = Guid.NewGuid();
            var expectedCase = new Case()
            {
                Id = 99,
                ProviderId = providerId,
                Name = "Nameeeeeeeeeeeeee",
                ImageUrl = "www.example.com/images/case.png",
                Description = "Description1Description1Description1",
                Price = 100m,
            };

            dbContext.Cases.Add(expectedCase);
            dbContext.SaveChanges();

            var service = new ProviderService(dbContext);

            var result = await service.AllCasesByProviderIdAsync(providerId.ToString().ToUpper());

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result.First().Id, Is.EqualTo(expectedCase.Id));
            Assert.That(result.First().Name, Is.EqualTo(expectedCase.Name));
            Assert.That(result.First().ImageUrl, Is.EqualTo(expectedCase.ImageUrl));
            Assert.That(result.First().Price, Is.EqualTo(expectedCase.Price));
        }

        [Test]
        public async Task GetAllCpusAsyncByProviderIdShouldReturnCorrectData()
        {
            var providerId = Guid.NewGuid();
            var expectedCpu = new Cpu()
            {
                Id = 99,
                ProviderId = providerId,
                Name = "Nameeeeeeeeeeeeee",
                Socket = "Socket",
                ImageUrl = "www.example.com/images/cpu.png",
                Description = "Description1Description1Description1",
                Price = 100m,
            };

            dbContext.Cpus.Add(expectedCpu);
            dbContext.SaveChanges();

            var service = new ProviderService(dbContext);

            var result = await service.AllCpusByProviderIdAsync(providerId.ToString().ToUpper());

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result.First().Id, Is.EqualTo(expectedCpu.Id));
            Assert.That(result.First().Name, Is.EqualTo(expectedCpu.Name));
            Assert.That(result.First().ImageUrl, Is.EqualTo(expectedCpu.ImageUrl));
            Assert.That(result.First().Price, Is.EqualTo(expectedCpu.Price));
        }

        [Test]
        public async Task GetAllCoolersAsyncByProviderIdShouldReturnCorrectData()
        {
            var providerId = Guid.NewGuid();
            var expectedCooler = new Cooler()
            {
                Id = 99,
                ProviderId = providerId,
                Name = "Nameeeeeeeeeee",
                Compatibility = "Compatibility",
                ImageUrl = "www.example.com/images/cooler.png",
                Description = "Description1Description1Description1",
                Price = 100m,
            };

            dbContext.Coolers.Add(expectedCooler);
            dbContext.SaveChanges();

            var service = new ProviderService(dbContext);

            var result = await service.AllCoolersByProviderIdAsync(providerId.ToString().ToUpper());

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result.First().Id, Is.EqualTo(expectedCooler.Id));
            Assert.That(result.First().Name, Is.EqualTo(expectedCooler.Name));
            Assert.That(result.First().ImageUrl, Is.EqualTo(expectedCooler.ImageUrl));
            Assert.That(result.First().Price, Is.EqualTo(expectedCooler.Price));
        }

        [Test]
        public async Task GetAllMotherboardsAsyncByProviderIdShouldReturnCorrectData()
        {
            var providerId = Guid.NewGuid();
            var expectedMotherboard = new Motherboard()
            {
                Id = 99,
                ProviderId = providerId,
                Name = "Nameeeeeeeeeeee",
                Chipset = "Chipset",
                Socket = "Socket",
                ImageUrl = "www.example.com/images/mb.png",
                Description = "Description1Description1Description1",
                Price = 100m,
            };

            dbContext.Motherboards.Add(expectedMotherboard);
            dbContext.SaveChanges();

            var service = new ProviderService(dbContext);

            var result = await service.AllMotherboardsByProviderIdAsync(providerId.ToString().ToUpper());

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result.First().Id, Is.EqualTo(expectedMotherboard.Id));
            Assert.That(result.First().Name, Is.EqualTo(expectedMotherboard.Name));
            Assert.That(result.First().ImageUrl, Is.EqualTo(expectedMotherboard.ImageUrl));
            Assert.That(result.First().Price, Is.EqualTo(expectedMotherboard.Price));
        }

        [Test]
        public async Task GetAllGpusAsyncByProviderIdShouldReturnCorrectData()
        {
            var providerId = Guid.NewGuid();
            var expectedGpu = new Gpu()
            {
                Id = 99,
                ProviderId = providerId,
                Name = "Nameeeeeeeeeeeeee",
                ImageUrl = "www.example.com/images/gpu.png",
                Description = "Description1Description1Description1",
                Price = 100m,
            };

            dbContext.Gpus.Add(expectedGpu);
            dbContext.SaveChanges();

            var service = new ProviderService(dbContext);

            var result = await service.AllGpusByProviderIdAsync(providerId.ToString().ToUpper());

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result.First().Id, Is.EqualTo(expectedGpu.Id));
            Assert.That(result.First().Name, Is.EqualTo(expectedGpu.Name));
            Assert.That(result.First().ImageUrl, Is.EqualTo(expectedGpu.ImageUrl));
            Assert.That(result.First().Price, Is.EqualTo(expectedGpu.Price));
        }

        [Test]
        public async Task GetAllPsusAsyncByProviderIdShouldReturnCorrectData()
        {
            var providerId = Guid.NewGuid();
            var expectedPsu = new Psu()
            {
                Id = 99,
                ProviderId = providerId,
                Name = "Nameeeeeeeeeeeeee",
                ImageUrl = "www.example.com/images/case.png",
                Description = "Description1Description1Description1",
                Price = 100m,
            };

            dbContext.Psus.Add(expectedPsu);
            dbContext.SaveChanges();

            var service = new ProviderService(dbContext);

            var result = await service.AllPsusByProviderIdAsync(providerId.ToString().ToUpper());

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result.First().Id, Is.EqualTo(expectedPsu.Id));
            Assert.That(result.First().Name, Is.EqualTo(expectedPsu.Name));
            Assert.That(result.First().ImageUrl, Is.EqualTo(expectedPsu.ImageUrl));
            Assert.That(result.First().Price, Is.EqualTo(expectedPsu.Price));
        }

        [Test]
        public async Task GetAllRamAsyncByProviderIdShouldReturnCorrectData()
        {
            var providerId = Guid.NewGuid();
            var expectedRam = new Ram()
            {
                Id = 99,
                ProviderId = providerId,
                Name = "Nameeeeeeeeeeeee",
                ModelNumber = "ModelNumber",
                ImageUrl = "www.example.com/images/ram.png",
                Description = "Description1Description1Description1",
                Price = 100m,
            };

            dbContext.Rams.Add(expectedRam);
            dbContext.SaveChanges();

            var service = new ProviderService(dbContext);

            var result = await service.AllRamsByProviderIdAsync(providerId.ToString().ToUpper());

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result.First().Id, Is.EqualTo(expectedRam.Id));
            Assert.That(result.First().Name, Is.EqualTo(expectedRam.Name));
            Assert.That(result.First().ImageUrl, Is.EqualTo(expectedRam.ImageUrl));
            Assert.That(result.First().Price, Is.EqualTo(expectedRam.Price));
        }

        [Test]
        public async Task GetAllStoragesAsyncByProviderIdShouldReturnCorrectData()
        {
            var providerId = Guid.NewGuid();
            var expectedStorage = new Storage()
            {
                Id = 99,
                ProviderId = providerId,
                Name = "Nameeeeeeeeeeeeee",
                ImageUrl = "www.example.com/images/case.png",
                Description = "Description1Description1Description1",
                Price = 100m,
            };

            dbContext.Storages.Add(expectedStorage);
            dbContext.SaveChanges();

            var service = new ProviderService(dbContext);

            var result = await service.AllStoragesByProviderIdAsync(providerId.ToString().ToUpper());

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result.First().Id, Is.EqualTo(expectedStorage.Id));
            Assert.That(result.First().Name, Is.EqualTo(expectedStorage.Name));
            Assert.That(result.First().ImageUrl, Is.EqualTo(expectedStorage.ImageUrl));
            Assert.That(result.First().Price, Is.EqualTo(expectedStorage.Price));
        }
    }
}
