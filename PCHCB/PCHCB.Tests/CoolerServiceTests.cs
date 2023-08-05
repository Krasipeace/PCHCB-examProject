namespace PCHCB.Tests
{
    using Microsoft.EntityFrameworkCore;
    using NUnit.Framework;

    using PCHCB.Services.Data;
    using PCHCB.Data;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Data.Models;
    using PCHCB.Web.ViewModels.Cooler;
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Enums;

    [TestFixture]
    public class CoolerServiceTests
    {
        private PCHCBDbContext dbContext;
        private ICoolerService coolerService;
        private const string testProviderId = "3f900985-864b-484d-8612-7e20b74613fb";

        [SetUp]
        public void Setup()
        {
            var option = new DbContextOptionsBuilder<PCHCBDbContext>()
                .UseInMemoryDatabase(databaseName: "PCHCBTestsDB")
                .Options;

            dbContext = new PCHCBDbContext(option);
            coolerService = new CoolerService(dbContext);

            dbContext.Coolers.AddAsync(new Cooler()
            {
                Name = "Cooler1",
                Price = 100,
                Type = CoolerType.Air,
                Compatibility = "Compatibility1",
                FanSize = 120,
                CoolerHeight = 150,
                Tdp = 180,
                Width = 30,
                ImageUrl = "http://ImageUrl1ImageUrl1",
                Description = "Description1Description1Description1",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse(testProviderId)
            });

            dbContext.Coolers.AddAsync(new Cooler()
            {
                Name = "Cooler2",
                Price = 200,
                Type = CoolerType.Water,
                Compatibility = "Compatibility2",
                RadiatorSize = RadiatorSize._240,
                FanSize = 240,
                CoolerHeight = 60,
                Tdp = 250,
                Width = 60,
                ImageUrl = "http://ImageUrl2ImageUrl2",
                Description = "Description2Description2Description2",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.NewGuid()
            });
        }

        [Test]
        public async Task CreateCoolerAsyncShouldCreateCooler()
        {
            var model = new CoolerFormModel()
            {
                Name = "Cooler3",
                Price = 300,
                Type = (int)CoolerType.Air,
                Compatibility = "Compatibility3",
                FanSize = 140,
                CoolerHeight = 160,
                Tdp = 200,
                Width = 40,
                ImageUrl = "http://ImageUrl3ImageUrl3",
                Description = "Description3Description3Description3",
            };

            var initialTotalCoolerCount = await dbContext.Coolers.CountAsync();

            var result = await coolerService.CreateCoolerAsync(testProviderId, model);

            var newTotalCoolerCount = await dbContext.Coolers.CountAsync();
            Assert.IsTrue(newTotalCoolerCount > initialTotalCoolerCount);

            var cooler = await dbContext.Coolers.FirstAsync(c => c.Id == result);
            Assert.IsNotNull(cooler);
            Assert.That(cooler.Name, Is.EqualTo("Cooler3"));
            Assert.That(cooler.Price, Is.EqualTo(300));
            Assert.That(cooler.Type, Is.EqualTo(CoolerType.Air));
            Assert.That(cooler.Compatibility, Is.EqualTo("Compatibility3"));
            Assert.That(cooler.FanSize, Is.EqualTo(140));
            Assert.That(cooler.CoolerHeight, Is.EqualTo(160));
            Assert.That(cooler.Tdp, Is.EqualTo(200));
            Assert.That(cooler.Width, Is.EqualTo(40));
            Assert.That(cooler.ImageUrl, Is.EqualTo("http://ImageUrl3ImageUrl3"));
            Assert.That(cooler.Description, Is.EqualTo("Description3Description3Description3"));
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public async Task GetCoolerForEditByIdAsyncShouldReturnCorrectCooler()
        {
            var cooledId = (await dbContext.Coolers.FirstAsync(c => c.Name == "Cooler1")).Id;

            var result = await coolerService.GetCoolerForEditByIdAsync(cooledId);

            Assert.That(result.Name, Is.EqualTo("Cooler1"));
            Assert.That(result.Price, Is.EqualTo(100));
            Assert.That(result.Type, Is.EqualTo(0));
            Assert.That(result.Compatibility, Is.EqualTo("Compatibility1"));
            Assert.That(result.FanSize, Is.EqualTo(120));
            Assert.That(result.CoolerHeight, Is.EqualTo(150));
            Assert.That(result.Tdp, Is.EqualTo(180));
            Assert.That(result.Width, Is.EqualTo(30));
            Assert.That(result.ImageUrl, Is.EqualTo("http://ImageUrl1ImageUrl1"));
            Assert.That(result.Description, Is.EqualTo("Description1Description1Description1"));
        }

        [Test]
        public async Task EditCoolerByIdAndFormModelUpdatesExistingCoolerInDbContext()
        {
            var coolerId = (await dbContext.Coolers.FirstAsync(c => c.Name == "Cooler1")).Id;

            var model = new CoolerFormModel()
            {
                Name = "Cooler1Edit",
                Price = 100,
                Type = 0,
                Compatibility = "Compatibility1",
                FanSize = 120,
                CoolerHeight = 150,
                Tdp = 180,
                Width = 30,
                ImageUrl = "http://ImageUrl1ImageUrl1.com",
                Description = "Edited cooler edited cooler",
            };

            await coolerService.EditCoolerByIdAndFormModelAsync(coolerId, model);

            var updatedCooler = await dbContext.Coolers.FirstAsync(c => c.Id == coolerId);

            Assert.That(updatedCooler.Name, Is.EqualTo("Cooler1Edit"));
            Assert.That(updatedCooler.Price, Is.EqualTo(100));
            Assert.That(updatedCooler.Type, Is.EqualTo(CoolerType.Air));
            Assert.That(updatedCooler.Compatibility, Is.EqualTo("Compatibility1"));
            Assert.That(updatedCooler.FanSize, Is.EqualTo(120));
            Assert.That(updatedCooler.CoolerHeight, Is.EqualTo(150));
            Assert.That(updatedCooler.Tdp, Is.EqualTo(180));
            Assert.That(updatedCooler.Width, Is.EqualTo(30));
            Assert.That(updatedCooler.ImageUrl, Is.EqualTo("http://ImageUrl1ImageUrl1.com"));
            Assert.That(updatedCooler.Description, Is.EqualTo("Edited cooler edited cooler"));
            Assert.That(updatedCooler.ProviderId, Is.EqualTo(Guid.Parse(testProviderId)));
        }

        [Test]
        public async Task IsProviderIdOwnerOfCoolerIdReturnsFalseIfCoolerIsOwnedByProviderWithProviderId()
        {
            var providerId = testProviderId;
            var coolerId = (await dbContext.Coolers.FirstAsync(c => c.Name == "Cooler1")).Id;

            var result = await coolerService.IsProviderIdOwnerOfCoolerIdAsync(providerId, coolerId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task IsCoolerExistByIdReturnsFalseIfDoesntExistInDb()
        {
            int coolerId = -1;

            var result = await coolerService.IsCoolerExistByIdAsync(coolerId);

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task IsCoolerExistByIdReturnsTrueIfDoesntExistInDb()
        {
            int coolerId = 2;

            var result = await coolerService.IsCoolerExistByIdAsync(coolerId);

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task GetAllCoolersAsyncReturnsAllCoolersFromDb()
        {
            var result = await coolerService.GetAllCoolersAsync();
            int actualCount = await dbContext.Coolers.CountAsync();

            Assert.That(result.Count(), Is.EqualTo(actualCount));
        }

        [Test]
        public async Task SearchCoolersAsyncReturnsMatchingCoolers()
        {
            var queryModel = new AllQueryModel()
            {
                ComponentsPerPage = 8,
                CurrentPage = 1,
                Sorting = GeneralSorting.Newest,
                SearchTerm = "Cooler1",
            };

            var result = await coolerService.SearchCoolersAsync(queryModel);
            var actualCount = await dbContext.Coolers.CountAsync(c => c.Name.Contains(queryModel.SearchTerm));

            Assert.That(result.TotalComponents, Is.EqualTo(actualCount));
        }

        [Test]
        public async Task DeleteCoolerByIdAsyncDeletesCoolerFromDb()
        {
            var coolerId = (await dbContext.Coolers.FirstAsync(c => c.Name == "Cooler1")).Id;

            await coolerService.DeleteCoolerByIdAsync(coolerId);

            var result = await dbContext.Coolers.FirstOrDefaultAsync(c => c.Id == coolerId);

            Assert.That(result, Is.Null);
        }
    }
}
