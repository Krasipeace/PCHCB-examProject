namespace PCHCB.Tests
{
    using Microsoft.EntityFrameworkCore;

    using NUnit.Framework;

    using PCHCB.Data;
    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.ViewModels.Ram;
    using PCHCB.Web.ViewModels.Enums;
    using PCHCB.Web.ViewModels.Home;

    [TestFixture]
    internal class RamServiceTests
    {
        private PCHCBDbContext dbContext;
        private IRamService ramService;
        private IProviderService providerService;
        private const string testProviderId = "3f900985-864b-484d-8612-7e20b74613fb";

        [SetUp]
        public void Setup()
        {
            var option = new DbContextOptionsBuilder<PCHCBDbContext>()
                .UseInMemoryDatabase(databaseName: "PCHCBTestsDB")
                .Options;
            dbContext = new PCHCBDbContext(option);
            ramService = new RamService(dbContext);
            providerService = new ProviderService(dbContext);

            dbContext.Rams.AddAsync(new Ram()
            {
                Name = "Ram1",
                Price = 100,
                Capacity = 8,
                Frequency = 3200,
                Type = RamType.DDR4,
                Height = 30,
                ModelNumber = "ModelNumber1",
                ImageUrl = "http://ImageUrl1ImageUrl1.com/image.png",
                Description = "Description1Description1Description1",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse(testProviderId)
            });

            dbContext.SaveChanges();
        }

        [Test]
        public async Task CreateRamAsyncShouldAddRamToDbContext()
        {
            var model = new RamFormModel()
            {
                Name = "Ram2",
                Price = 200,
                Capacity = 16,
                Frequency = 3200,
                Type = 2,
                Height = 30,
                ModelNumber = "ModelNumber2",
                ImageUrl = "http://ImageUrl2ImageUrl2.com/image.png",
                Description = "Description2Description2Description2",
            };

            int initialCount = await dbContext.Rams.CountAsync();
            var result = await ramService.CreateRamAsync(testProviderId, model);

            int actualCount = await dbContext.Rams.CountAsync();
            Assert.IsTrue(initialCount < actualCount);
            var ram = await dbContext.Rams.FirstOrDefaultAsync(r => r.Id == result);
            Assert.IsNotNull(ram);
            Assert.That(ram.Name, Is.EqualTo(model.Name));
            Assert.That(ram.Price, Is.EqualTo(model.Price));
            Assert.That(ram.Capacity, Is.EqualTo(model.Capacity));
            Assert.That(ram.Frequency, Is.EqualTo(model.Frequency));
            Assert.That(ram.Type, Is.EqualTo((RamType)model.Type));
            Assert.That(ram.Height, Is.EqualTo(model.Height));
            Assert.That(ram.ModelNumber, Is.EqualTo(model.ModelNumber));
            Assert.That(ram.ImageUrl, Is.EqualTo(model.ImageUrl));
            Assert.That(ram.Description, Is.EqualTo(model.Description));
            Assert.That(ram.ProviderId.ToString(), Is.EqualTo(testProviderId));
            Assert.That(result > 1, Is.EqualTo(true));
        }

        [Test]
        public async Task GetRamForEditByIdAsyncShouldReturnCorrectRam()
        {
            int ramId = (await dbContext.Rams.FirstAsync(r => r.Name == "Ram1")).Id;

            var result = await ramService.GetRamForEditByIdAsync(ramId);

            Assert.IsNotNull(result);
            Assert.That(result.Name, Is.EqualTo("Ram1"));
            Assert.That(result.Price, Is.EqualTo(100));
            Assert.That(result.Capacity, Is.EqualTo(8));
            Assert.That(result.Frequency, Is.EqualTo(3200));
            Assert.That(result.Type, Is.EqualTo((int)RamType.DDR4));
            Assert.That(result.Height, Is.EqualTo(30));
            Assert.That(result.ModelNumber, Is.EqualTo("ModelNumber1"));
            Assert.That(result.ImageUrl, Is.EqualTo("http://ImageUrl1ImageUrl1.com/image.png"));
            Assert.That(result.Description, Is.EqualTo("Description1Description1Description1"));
        }

        [Test]
        public async Task EditRamByIdAndFormModelUpdatesExistingRamInDbContext()
        {
            int ramId = (await dbContext.Rams.FirstAsync(r => r.Name == "Ram1")).Id;

            var model = new RamFormModel()
            {
                Name = "Ram1Edit",
                Price = 66.69m,
                Capacity = 16,
                Frequency = 3200,
                Type = 2,
                Height = 32,
                ModelNumber = "ModelNumber1Edit",
                ImageUrl = "http://ImageUrl1EditImageUrl1Edit.com/image.png",
                Description = "Description1EditDescription1EditDescription1Edit",
            };

            await ramService.EditRamByIdAndFormModelAsync(ramId, model);
            var updatedRam = await dbContext.Rams.FirstAsync(r => r.Id == ramId);

            Assert.IsNotNull(updatedRam);
            Assert.That(updatedRam.Name, Is.EqualTo(model.Name));
            Assert.That(updatedRam.Price, Is.EqualTo(model.Price));
            Assert.That(updatedRam.Capacity, Is.EqualTo(model.Capacity));
            Assert.That(updatedRam.Frequency, Is.EqualTo(model.Frequency));
            Assert.That(updatedRam.Type, Is.EqualTo((RamType)model.Type));
            Assert.That(updatedRam.Height, Is.EqualTo(model.Height));
            Assert.That(updatedRam.ModelNumber, Is.EqualTo(model.ModelNumber));
            Assert.That(updatedRam.ImageUrl, Is.EqualTo(model.ImageUrl));
            Assert.That(updatedRam.Description, Is.EqualTo(model.Description));
            Assert.That(updatedRam.ProviderId.ToString().ToUpper(), Is.EqualTo(testProviderId.ToUpper()));
        }

        [Test]
        public async Task IsProviderIdOwnerOfRamIdReturnsTrueIfProviderIdIsOwner()
        {
            var providerId = testProviderId.ToUpper();
            int ramId = (await dbContext.Rams.FirstAsync(c => c.Name == "Ram1")).Id;

            var result = await ramService.IsProviderIdOwnerOfRamIdAsync(providerId, ramId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsRamExistsByIdReturnsTrueIfExistsInDbContext()
        {
            int ramId = 1;

            var result = await ramService.IsRamExistByIdAsync(ramId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsRamExistsByIdReturnsFalseIfNotExistsInDbContext()
        {
            int ramId = 1000;

            var result = await ramService.IsRamExistByIdAsync(ramId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetAllRamsASyncReturnsAllRamsFromDbContext()
        {
            var result = await ramService.GetAllRamsAsync();
            int actualCount = await dbContext.Rams.CountAsync();

            Assert.IsNotNull(result);
            Assert.That(result.Count(), Is.EqualTo(actualCount));
        }

        [Test]
        public async Task GetAllRamsDetailsAsyncReturnsAllRamsDetailsFromDbContext()
        {
            var expected = await ramService.GetAllRamsDetailsAsync();
            int actual = await dbContext.Rams.CountAsync();

            Assert.That(expected.Count, Is.EqualTo(actual));
        }

        [Test]
        public async Task SearchRamsAsyncReturnsMatchingRams()
        {
            var queryModel = new AllQueryModel()
            {
                SearchTerm = "Ram1",
                CurrentPage = 1,
                ComponentsPerPage = 4,
                Sorting = GeneralSorting.PriceAscending,
            };

            var result = await ramService.SearchRamsAsync(queryModel);
            int actualCount = await dbContext.Rams.CountAsync(r => r.Name.Contains(queryModel.SearchTerm));

            Assert.IsNotNull(result);
            Assert.That(result.TotalComponents, Is.EqualTo(actualCount));
        }

        [Test]
        public async Task GetRamForDeleteByIdAsync()
        {
            int ramId = (await dbContext.Rams.FirstAsync(c => c.Name == "Ram1")).Id;

            var result = await ramService.GetRamForDeleteByIdAsync(ramId);

            Assert.IsNotNull(result);
            Assert.That(result.Name, Is.EqualTo("Ram1"));
            Assert.That(result.ImageUrl, Is.EqualTo("http://ImageUrl1ImageUrl1.com/image.png"));
            Assert.That(result.Description, Is.EqualTo("Description1Description1Description1"));
        }

        [Test]
        public async Task DeleteRamByIdAsyncRemovesRamFromDbContext()
        {
            int ramId = (await dbContext.Rams.FirstAsync(r => r.Name == "Ram2")).Id;
            await ramService.DeleteRamByIdAsync(ramId);
            var deletedRam = await dbContext.Rams.FirstOrDefaultAsync(r => r.Id == ramId);
            Assert.IsNull(deletedRam);
        }
    }
}
