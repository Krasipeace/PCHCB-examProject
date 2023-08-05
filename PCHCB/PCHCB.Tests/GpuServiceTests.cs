namespace PCHCB.Tests
{
    using Microsoft.EntityFrameworkCore;

    using NUnit.Framework;

    using PCHCB.Data;
    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.ViewModels.Gpu;
    using PCHCB.Web.ViewModels.Enums;
    using PCHCB.Web.ViewModels.Home;

    [TestFixture]
    public class GpuServiceTests
    {
        private PCHCBDbContext dbContext;
        private IGpuService gpuService;
        private const string testProviderId = "3f900985-864b-484d-8612-7e20b74613fb";

        [SetUp]
        public void Setup()
        {
            var option = new DbContextOptionsBuilder<PCHCBDbContext>()
                .UseInMemoryDatabase(databaseName: "PCHCBTestsDB")
                .Options;

            dbContext = new PCHCBDbContext(option);
            gpuService = new GpuService(dbContext);

            dbContext.Gpus.AddAsync(new Gpu()
            {
                Name = "Gpu1",
                Price = 100,
                Memory = 8,
                Interface = InterfaceType.PCIExpress5,
                Length = 300,
                SlotsRequired = 2,
                PowerConsumption = 500,
                NvidiaConnector = false,
                ImageUrl = "http://ImageUrl1ImageUrl1.com",
                Description = "Description1Description1Description1",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse(testProviderId)
            });

            dbContext.SaveChanges();
        }

        [Test]
        public async Task CreateGpuAsyncShouldCreateGpuToGpuDbContext()
        {
            var model = new GpuFormModel()
            {
                Name = "Gpu2",
                Price = 200,
                Memory = 16,
                Interface = 2,
                Length = 300,
                SlotsRequired = 2,
                PowerConsumption = 500,
                NvidiaConnector = false,
                ImageUrl = "http://ImageUrl2ImageUrl2.com",
                Description = "Description2Description2Description2",
            };

            var initialCount = await dbContext.Gpus.CountAsync();
            var result = await gpuService.CreateGpuAsync(testProviderId, model);

            var actualCount = await dbContext.Gpus.CountAsync();
            Assert.IsTrue(initialCount < actualCount);
            var gpu = await dbContext.Gpus.FirstOrDefaultAsync(g => g.Id == result);
            Assert.IsNotNull(gpu);
            Assert.That(gpu.Name, Is.EqualTo(model.Name));
            Assert.That(gpu.Price, Is.EqualTo(model.Price));
            Assert.That(gpu.Memory, Is.EqualTo(model.Memory));
            Assert.That(gpu.Interface, Is.EqualTo((InterfaceType)model.Interface));
            Assert.That(gpu.Length, Is.EqualTo(model.Length));
            Assert.That(gpu.SlotsRequired, Is.EqualTo(model.SlotsRequired));
            Assert.That(gpu.PowerConsumption, Is.EqualTo(model.PowerConsumption));
            Assert.That(gpu.NvidiaConnector, Is.EqualTo(model.NvidiaConnector));
            Assert.That(gpu.ImageUrl, Is.EqualTo(model.ImageUrl));
            Assert.That(gpu.Description, Is.EqualTo(model.Description));
            Assert.That(Guid.Parse(testProviderId), Is.EqualTo(gpu.ProviderId));
        }

        [Test]
        public async Task GetGpuForEditByIdAsyncShouldReturnCorrectGpu()
        {
            int gpuId = (await dbContext.Gpus.FirstAsync(g => g.Name == "Gpu1")).Id;

            var result = await gpuService.GetGpuForEditByIdAsync(gpuId);

            Assert.IsNotNull(result);
            Assert.That(result.Name, Is.EqualTo("Gpu1"));
            Assert.That(result.Price, Is.EqualTo(100));
            Assert.That(result.Memory, Is.EqualTo(8));
            Assert.That(result.Interface, Is.EqualTo(2));
            Assert.That(result.Length, Is.EqualTo(300));
            Assert.That(result.SlotsRequired, Is.EqualTo(2));
            Assert.That(result.PowerConsumption, Is.EqualTo(500));
            Assert.That(result.NvidiaConnector, Is.EqualTo(false));
            Assert.That(result.ImageUrl, Is.EqualTo("http://ImageUrl1ImageUrl1.com"));
            Assert.That(result.Description, Is.EqualTo("Description1Description1Description1"));
        }

        [Test]
        public async Task EditGpuByIdAndFormModelUpdatesExistingGpuInDbContext()
        {
            int gpuId = (await dbContext.Gpus.FirstAsync(g => g.Name == "Gpu1")).Id;

            var model = new GpuFormModel
            {
                Name = "Gpu1Edit",
                Price = 299,
                Memory = 8,
                Interface = 2,
                Length = 300,
                SlotsRequired = 2.5,
                PowerConsumption = 500,
                NvidiaConnector = false,
                ImageUrl = "http://ImageUrl1ImageUrl1.com/image.png",
                Description = "Description1Description1Description1 Description1Description1Description1",
            };

            await gpuService.EditGpuByIdAndFormModelAsync(gpuId, model);
            var updatedGpu = await dbContext.Gpus.FirstAsync(g => g.Id == gpuId);

            Assert.That(updatedGpu.Name, Is.EqualTo(model.Name));
            Assert.That(updatedGpu.Price, Is.EqualTo(model.Price));
            Assert.That(updatedGpu.Memory, Is.EqualTo(model.Memory));
            Assert.That(updatedGpu.Interface, Is.EqualTo((InterfaceType)model.Interface));
            Assert.That(updatedGpu.Length, Is.EqualTo(model.Length));
            Assert.That(updatedGpu.SlotsRequired, Is.EqualTo(model.SlotsRequired));
            Assert.That(updatedGpu.PowerConsumption, Is.EqualTo(model.PowerConsumption));
            Assert.That(updatedGpu.NvidiaConnector, Is.EqualTo(model.NvidiaConnector));
            Assert.That(updatedGpu.ImageUrl, Is.EqualTo(model.ImageUrl));
            Assert.That(updatedGpu.Description, Is.EqualTo(model.Description));
        }

        [Test]
        public async Task IsProviderIdOwnerOfGpuIdReturnsFalseIfProviderIdIsOwner()
        {
            var providerId = testProviderId;
            int gpuId = (await dbContext.Gpus.FirstAsync(c => c.Name == "Gpu1Edit")).Id;

            var result = await gpuService.IsProviderIdOwnerOfGpuIdAsync(providerId, gpuId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task IsGpuExistsByIdReturnsTrueIfExistsInDbContext()
        {
            int gpuId = 1;

            var result = await gpuService.IsGpuExistByIdAsync(gpuId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsGpuExistsByIdReturnsFalseIfNotExistsInDbContext()
        {
            int gpuId = 1000;

            var result = await gpuService.IsGpuExistByIdAsync(gpuId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetAllGpusAsyncReturnsAllGpusFromDbContext()
        {
            var result = await gpuService.GetAllGpusAsync();
            int actualCount = await dbContext.Gpus.CountAsync();

            Assert.IsNotNull(result);
            Assert.That(result.Count(), Is.EqualTo(actualCount));
        }

        [Test]
        public async Task SearchAllGpusAsyncReturnsMatchingGpus()
        {
            var queryModel = new AllQueryModel
            {
                ComponentsPerPage = 12,
                CurrentPage = 1,
                Sorting = GeneralSorting.PriceDescending,
                SearchTerm = "Gpu1",
            };

            var result = await gpuService.SearchGpusAsync(queryModel);
            int actualCount = await dbContext.Gpus.CountAsync(g => g.Name.Contains(queryModel.SearchTerm));

            Assert.IsNotNull(result);
            Assert.That(result.TotalComponents, Is.EqualTo(actualCount));
        }

        [Test]
        public async Task GetGpuForDeleteByIdAsync()
        {
            int gpuId = (await dbContext.Gpus.FirstAsync(c => c.Name == "Gpu1")).Id;

            var result = await gpuService.GetGpuForDeleteByIdAsync(gpuId);

            Assert.IsNotNull(result);
            Assert.That(result.Name, Is.EqualTo("Gpu1"));
            Assert.That(result.ImageUrl, Is.EqualTo("http://ImageUrl1ImageUrl1.com"));
            Assert.That(result.Description, Is.EqualTo("Description1Description1Description1"));
        }

        [Test]
        public async Task DeleteGpuByIdAsyncRemovesGpuFromDbContext()
        {
            int gpuId = (await dbContext.Gpus.FirstAsync(g => g.Name == "Gpu2")).Id;

            await gpuService.DeleteGpuByIdAsync(gpuId);
            var deletedGpu = await dbContext.Gpus.FirstOrDefaultAsync(g => g.Id == gpuId);

            Assert.IsNull(deletedGpu);
        }
    }
}
