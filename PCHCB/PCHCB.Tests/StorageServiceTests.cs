namespace PCHCB.Tests
{
    using Microsoft.EntityFrameworkCore;

    using NUnit.Framework;

    using PCHCB.Data;
    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.ViewModels.Storage;
    using PCHCB.Web.ViewModels.Enums;
    using PCHCB.Web.ViewModels.Home;

    [TestFixture]
    public class StorageServiceTests
    {
        private PCHCBDbContext dbContext;
        private IStorageService storageService;
        private const string testProviderId = "3f900985-864b-484d-8612-7e20b74613fb";

        [SetUp]
        public void Setup()
        {
            var option = new DbContextOptionsBuilder<PCHCBDbContext>()
                .UseInMemoryDatabase(databaseName: "PCHCBTestsDB")
                .Options;
            dbContext = new PCHCBDbContext(option);
            storageService = new StorageService(dbContext);

            dbContext.Storages.AddAsync(new Storage()
            {
                Name = "Storage1",
                Price = 100,
                Capacity = 1000,
                Type = StorageType.SSD,
                ImageUrl = "http://ImageUrl1ImageUrl1.com/image.png",
                Description = "Description1Description1Description1",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse(testProviderId)
            });

            dbContext.SaveChanges();
        }

        [Test]
        public async Task CreateStorageAsyncShouldCreateStorageToDbContext()
        {
            var model = new StorageFormModel()
            {
                Name = "Storage2",
                Price = 55.55m,
                Capacity = 1024,
                Type = 1,
                ImageUrl = "http://ImageUrl2ImageUrl2.com/image.png",
                Description = "Description2Description2Description2",
            };

            int initialCount = await dbContext.Storages.CountAsync();
            var result = await storageService.CreateStorageAsync(testProviderId, model);

            var actualCount = await dbContext.Storages.CountAsync();
            Assert.IsTrue(initialCount < actualCount);
            var storage = await dbContext.Storages.FirstOrDefaultAsync(s => s.Id == result);
            Assert.IsNotNull(storage);
            Assert.That(storage.Name, Is.EqualTo("Storage2"));
            Assert.That(storage.Price, Is.EqualTo(55.55m));
            Assert.That(storage.Capacity, Is.EqualTo(1024));
            Assert.That(storage.Type, Is.EqualTo(StorageType.SSD));
            Assert.That(storage.ImageUrl, Is.EqualTo("http://ImageUrl2ImageUrl2.com/image.png"));
            Assert.That(storage.Description, Is.EqualTo("Description2Description2Description2"));
            Assert.That(storage.ProviderId, Is.EqualTo(Guid.Parse(testProviderId)));
            Assert.That(result > 1, Is.EqualTo(true));
        }

        [Test]
        public async Task GetStorageForEditByIdAsyncShouldReturnCorrectStorage()
        {
            int storageId = (await dbContext.Storages.FirstAsync(s => s.Name == "Storage1")).Id;

            var result = await storageService.GetStorageForEditByIdAsync(storageId);

            Assert.IsNotNull(result);
            Assert.That(result.Name, Is.EqualTo("Storage1"));
            Assert.That(result.Price, Is.EqualTo(100));
            Assert.That(result.Capacity, Is.EqualTo(1000));
            Assert.That(result.Type, Is.EqualTo(1));
            Assert.That(result.ImageUrl, Is.EqualTo("http://ImageUrl1ImageUrl1.com/image.png"));
            Assert.That(result.Description, Is.EqualTo("Description1Description1Description1"));
        }

        [Test]
        public async Task EditStorageByIdAndFormModelUpdatesExistingStorageInDbContext()
        {
            int storageId = (await dbContext.Storages.FirstAsync(s => s.Name == "Storage1")).Id;

            var model = new StorageFormModel()
            {
                Name = "Storage1Edit",
                Price = 44.98m,
                Capacity = 2048,
                Type = 1,
                ImageUrl = "http://ImageUrl1ImageUrl1.com/imageEdit.png",
                Description = "Description1Description1Description1Edit",
            };

            await storageService.EditStorageByIdAndFormModelAsync(storageId, model);
            var updatedStorage = await dbContext.Storages.FirstAsync(s => s.Id == storageId);

            Assert.IsNotNull(updatedStorage);
            Assert.That(updatedStorage.Name, Is.EqualTo("Storage1Edit"));
            Assert.That(updatedStorage.Price, Is.EqualTo(44.98m));
            Assert.That(updatedStorage.Capacity, Is.EqualTo(2048));
            Assert.That(updatedStorage.Type, Is.EqualTo(StorageType.SSD));
            Assert.That(updatedStorage.ImageUrl, Is.EqualTo("http://ImageUrl1ImageUrl1.com/imageEdit.png"));
            Assert.That(updatedStorage.Description, Is.EqualTo("Description1Description1Description1Edit"));
            Assert.That(updatedStorage.ProviderId, Is.EqualTo(Guid.Parse(testProviderId)));
        }

        [Test]
        public async Task IsProviderIdOwnerOfStorageIdReturnsFalseIfProviderIdIsOwner()
        {
            var providerId = testProviderId.ToUpper();
            int storageId = (await dbContext.Storages.FirstAsync(c => c.Name == "Storage1")).Id;

            var result = await storageService.IsProviderIdOwnerOfStorageIdAsync(providerId, storageId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task IsStorageExistsByIdReturnsTrueIfExistsInDbContext()
        {
            int storageId = (await dbContext.Storages.FirstAsync(c => c.Name == "Storage1")).Id;

            var result = await storageService.IsStorageExistByIdAsync(storageId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsStorageExistsByIdReturnsFalseIfNotExistsInDbContext()
        {
            int storageId = 1000;

            var result = await storageService.IsStorageExistByIdAsync(storageId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetAllStoragesAsyncReturnsAllStoragesFromDbContext()
        {
            var result = await storageService.GetAllStoragesAsync();
            int actualCount = await dbContext.Storages.CountAsync();

            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(actualCount));
        }

        [Test]
        public async Task SearchStoragesAsyncReturnsMatchingStorages()
        {
            var queryModel = new AllQueryModel()
            {
                ComponentsPerPage = 8,
                CurrentPage = 1,
                Sorting = GeneralSorting.Oldest,
                SearchTerm = "Storage1",
            };

            var expected = await storageService.SearchStoragesAsync(queryModel);
            int actual = await dbContext.Storages.CountAsync(s => s.Name.Contains(queryModel.SearchTerm));

            Assert.IsNotNull(expected);
            Assert.That(expected.TotalComponents, Is.EqualTo(actual));
        }

        [Test]
        public async Task GetStorageForDeleteByIdAsync()
        {
            int storageId = (await dbContext.Storages.FirstAsync(c => c.Name == "Storage1")).Id;

            var result = await storageService.GetStorageForDeleteByIdAsync(storageId);

            Assert.IsNotNull(result);
            Assert.That(result.Name, Is.EqualTo("Storage1"));
            Assert.That(result.ImageUrl, Is.EqualTo("http://ImageUrl1ImageUrl1.com/image.png"));
            Assert.That(result.Description, Is.EqualTo("Description1Description1Description1"));
        }

        [Test]
        public async Task DeleteStorageByIdAsyncRemovesStorageFromDbContext()
        {
            int storageId = (await dbContext.Storages.FirstAsync(s => s.Name == "Storage1")).Id;

            await storageService.DeleteStorageByIdAsync(storageId);
            var deletedStorage = await dbContext.Storages.FirstOrDefaultAsync(s => s.Id == storageId);

            Assert.IsNull(deletedStorage);
        }
    }
}
