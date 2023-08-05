namespace PCHCB.Tests
{
    using Microsoft.EntityFrameworkCore;

    using NUnit.Framework;

    using PCHCB.Data;
    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.ViewModels.Psu;
    using PCHCB.Web.ViewModels.Enums;
    using PCHCB.Web.ViewModels.Home;

    [TestFixture]
    public class PsuServiceTests
    {
        private PCHCBDbContext dbContext;
        private IPsuService psuService;
        private const string testProviderId = "3f900985-864b-484d-8612-7e20b74613fb";

        [SetUp]
        public void Setup()
        {
            var option = new DbContextOptionsBuilder<PCHCBDbContext>()
                .UseInMemoryDatabase(databaseName: "PCHCBTestsDB")
                .Options;
            dbContext = new PCHCBDbContext(option);
            psuService = new PsuService(dbContext);

            dbContext.Psus.AddAsync(new Psu()
            {
                Name = "Psu1",
                Price = 100,
                Wattage = 500,
                Factor = PsuFactor.Atx,
                NvidiaConnector = false,
                ImageUrl = "http://ImageUrl1ImageUrl1.com",
                Description = "Description1Description1Description1",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse(testProviderId)
            });
        }

        [Test]
        public async Task CreatePsuAsyncShouldCreatePsuToDbContext()
        {
            var model = new PsuFormModel()
            {
                Name = "Psu2",
                Price = 200,
                Wattage = 1000,
                Factor = 2,
                NvidiaConnector = false,
                ImageUrl = "http://ImageUrl2ImageUrl2.com",
                Description = "Description2Description2Description2",
            };

            int initialCount = await dbContext.Psus.CountAsync();
            var result = await psuService.CreatePsuAsync(testProviderId, model);

            int actualCount = await dbContext.Psus.CountAsync();
            Assert.IsTrue(initialCount < actualCount);
            var psu = await dbContext.Psus.FirstOrDefaultAsync(p => p.Name == "Psu2");
            Assert.IsNotNull(psu);
            Assert.That(psu.Name, Is.EqualTo("Psu2"));
            Assert.That(psu.Price, Is.EqualTo(200));
            Assert.That(psu.Wattage, Is.EqualTo(1000));
            Assert.That(psu.Factor, Is.EqualTo((PsuFactor)2));
            Assert.That(psu.NvidiaConnector, Is.EqualTo(false));
            Assert.That(psu.ImageUrl, Is.EqualTo("http://ImageUrl2ImageUrl2.com"));
            Assert.That(psu.Description, Is.EqualTo("Description2Description2Description2"));
            Assert.That(Guid.Parse(testProviderId), Is.EqualTo(psu.ProviderId));
            Assert.That(result > 1, Is.EqualTo(true));
        }

        [Test]
        public async Task GetPsuForEditByIdAsyncShouldReturnCorrectPsu()
        {
            int psuId = (await dbContext.Psus.FirstAsync(p => p.Name == "Psu1")).Id;

            var result = await psuService.GetPsuForEditByIdAsync(psuId);

            Assert.IsNotNull(result);
            Assert.That(result.Name, Is.EqualTo("Psu1"));
            Assert.That(result.Price, Is.EqualTo(100));
            Assert.That(result.Wattage, Is.EqualTo(500));
            Assert.That(result.Factor, Is.EqualTo(0));
            Assert.That(result.NvidiaConnector, Is.EqualTo(false));
            Assert.That(result.ImageUrl, Is.EqualTo("http://ImageUrl1ImageUrl1.com"));
            Assert.That(result.Description, Is.EqualTo("Description1Description1Description1"));
        }

        [Test]
        public async Task EditPsuByIdAndFormModelUpdatesExistingPsuInDbContext()
        {
            int psuId = (await dbContext.Psus.FirstAsync(p => p.Name == "Psu1")).Id;

            var model = new PsuFormModel()
            {
                Name = "Psu1Edit",
                Price = 150.12m,
                Wattage = 750,
                Factor = 1,
                NvidiaConnector = true,
                ImageUrl = "http://ImageUrl1ImageUrl1.com/image.png",
                Description = "Description1Description1Description1Edit",
            };

            await psuService.EditPsuByIdAndFormModelAsync(psuId, model);
            var updatedPsu = await dbContext.Psus.FirstAsync(p => p.Id == psuId);

            Assert.IsNotNull(updatedPsu);
            Assert.That(updatedPsu.Name, Is.EqualTo("Psu1Edit"));
            Assert.That(updatedPsu.Price, Is.EqualTo(150.12m));
            Assert.That(updatedPsu.Wattage, Is.EqualTo(750));
            Assert.That(updatedPsu.Factor, Is.EqualTo((PsuFactor)1));
            Assert.That(updatedPsu.NvidiaConnector, Is.EqualTo(true));
            Assert.That(updatedPsu.ImageUrl, Is.EqualTo("http://ImageUrl1ImageUrl1.com/image.png"));
            Assert.That(updatedPsu.Description, Is.EqualTo("Description1Description1Description1Edit"));
        }

        [Test]
        public async Task IsProviderIdOwnerOfPsuIdReturnsFalseIfProviderIdIsOwner()
        {
            var providerId = testProviderId;
            int psuId = (await dbContext.Psus.FirstAsync(c => c.Name == "Psu1Edit")).Id;

            var result = await psuService.IsProviderIdOwnerOfPsuIdAsync(providerId, psuId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task IsPsuExistsByIdReturnsTrueIfExistsInDbContext()
        {
            int psuId = 1;

            var result = await psuService.IsPsuExistByIdAsync(psuId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsPsuExistsByIdReturnsFalseIfNotExistsInDbContext()
        {
            int psuId = 1000;

            var result = await psuService.IsPsuExistByIdAsync(psuId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetAllPsusAsyncReturnsAllPsusFromDbContext()
        {
            var result = await psuService.GetAllPsusAsync();
            int actualCount = await dbContext.Psus.CountAsync();

            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(actualCount));
        }

        [Test]
        public async Task SearchPsusAsyncReturnsMatchingPsus()
        {
            var queryModel = new AllQueryModel()
            {
                SearchTerm = "Psu1",
                CurrentPage = 1,
                ComponentsPerPage = 4,
                Sorting = GeneralSorting.Oldest,
            };

            var result = await psuService.SearchPsusAsync(queryModel);
            int actualCount = await dbContext.Psus.CountAsync(p => p.Name.Contains(queryModel.SearchTerm));

            Assert.IsNotNull(result);
            Assert.That(result.TotalComponents, Is.EqualTo(actualCount));
        }

        [Test]
        public async Task DeletePsuByIdAsyncRemovesPsuFromDbContext()
        {
            int psuId = (await dbContext.Psus.FirstAsync(p => p.Name == "Psu2")).Id;

            await psuService.DeletePsuByIdAsync(psuId);
            var psu = await dbContext.Psus.FirstOrDefaultAsync(p => p.Id == psuId);

            Assert.IsNull(psu);
        }
    }
}
