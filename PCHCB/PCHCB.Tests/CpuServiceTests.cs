namespace PCHCB.Tests
{
    using Microsoft.EntityFrameworkCore;

    using NUnit.Framework;

    using PCHCB.Data;
    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.ViewModels.Cpu;
    using PCHCB.Web.ViewModels.Enums;
    using PCHCB.Web.ViewModels.Home;

    [TestFixture]
    internal class CpuServiceTests
    {
        private PCHCBDbContext dbContext;
        private ICpuService cpuService;
        private const string testProviderId = "3f900985-864b-484d-8612-7e20b74613fb";

        [SetUp]
        public void Setup()
        {
            var option = new DbContextOptionsBuilder<PCHCBDbContext>()
                .UseInMemoryDatabase(databaseName: "PCHCBTestsDB")
                .Options;

            dbContext = new PCHCBDbContext(option);
            cpuService = new CpuService(dbContext);

            dbContext.Cpus.AddAsync(new Cpu()
            {
                Name = "Cpu1",
                Price = 100,
                Cores = 6,
                Threads = 12,
                Frequency = 3600,
                TurboFrequency = 4200,
                Cache = 32,
                Tdp = 95,
                RamFrequency = 3200,
                RamType = RamType.DDR4,
                Socket = "Socket1",
                ImageUrl = "http://ImageUrl1ImageUrl1.com",
                Description = "Description1Description1Description1",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse(testProviderId)
            });

            dbContext.SaveChanges();
        }

        [Test]
        public async Task CreateCpuAsyncShouldCreateCpuToDbContext()
        {
            var model = new CpuFormModel()
            {
                Name = "Cpu2",
                Price = 200,
                Cores = 8,
                Threads = 16,
                Frequency = 3600,
                TurboFrequency = 4200,
                Cache = 32,
                Tdp = 95,
                RamFrequency = 3200,
                RamType = 1,
                Socket = "Socket2",
                ImageUrl = "http://ImageUrl2ImageUrl2.com",
                Description = "Description2Description2Description2",
            };

            var initialCount = await dbContext.Cpus.CountAsync();
            var result = await cpuService.CreateCpuAsync(testProviderId, model);

            var actualCount = await dbContext.Cpus.CountAsync();
            Assert.IsTrue(initialCount < actualCount);
            var cpu = await dbContext.Cpus.FirstOrDefaultAsync(c => c.Id == result);
            Assert.IsNotNull(cpu);
            Assert.That(model.Name, Is.EqualTo(cpu.Name));
            Assert.That(model.Price, Is.EqualTo(cpu.Price));
            Assert.That(model.Cores, Is.EqualTo(cpu.Cores));
            Assert.That(model.Threads, Is.EqualTo(cpu.Threads));
            Assert.That(model.Frequency, Is.EqualTo(cpu.Frequency));
            Assert.That(model.TurboFrequency, Is.EqualTo(cpu.TurboFrequency));
            Assert.That(model.Cache, Is.EqualTo(cpu.Cache));
            Assert.That(model.Tdp, Is.EqualTo(cpu.Tdp));
            Assert.That(model.RamFrequency, Is.EqualTo(cpu.RamFrequency));
            Assert.That(model.RamType, Is.EqualTo(1));
            Assert.That(model.Socket, Is.EqualTo(cpu.Socket));
            Assert.That(model.ImageUrl, Is.EqualTo(cpu.ImageUrl));
            Assert.That(model.Description, Is.EqualTo(cpu.Description));
            Assert.That(Guid.Parse(testProviderId), Is.EqualTo(cpu.ProviderId));
            Assert.That(result > 1, Is.EqualTo(true));
        }

        [Test]
        public async Task GetCpuForEditByIdAsyncShouldReturnCorrectCpu()
        {
            int cpuId = (await dbContext.Cpus.FirstAsync(c => c.Name == "Cpu1")).Id;

            var result = await cpuService.GetCpuForEditByIdAsync(cpuId);

            Assert.IsNotNull(result);
            Assert.That(result.Name, Is.EqualTo("Cpu1"));
            Assert.That(result.Price, Is.EqualTo(100));
            Assert.That(result.Cores, Is.EqualTo(6));
            Assert.That(result.Threads, Is.EqualTo(12));
            Assert.That(result.Frequency, Is.EqualTo(3600));
            Assert.That(result.TurboFrequency, Is.EqualTo(4200));
            Assert.That(result.Cache, Is.EqualTo(32));
            Assert.That(result.Tdp, Is.EqualTo(95));
            Assert.That(result.RamFrequency, Is.EqualTo(3200));
            Assert.That(result.RamType, Is.EqualTo(1));
            Assert.That(result.Socket, Is.EqualTo("Socket1"));
            Assert.That(result.ImageUrl, Is.EqualTo("http://ImageUrl1ImageUrl1.com"));
            Assert.That(result.Description, Is.EqualTo("Description1Description1Description1"));
        }

        [Test]
        public async Task EditCpuByIdAndFormModelUpdatesExistingCpuInDbContext()
        {
            int cpuId = (await dbContext.Cpus.FirstAsync(c => c.Name == "Cpu1")).Id;

            var model = new CpuFormModel()
            {
                Name = "Cpu1Edit",
                Price = 200,
                Cores = 8,
                Threads = 16,
                Frequency = 3600,
                TurboFrequency = 4200,
                Cache = 32,
                Tdp = 95,
                RamFrequency = 3200,
                RamType = 1,
                Socket = "Socket1Edit",
                ImageUrl = "http://ImageUrl1ImageUrl1ImageUrl1.com",
                Description = "Description1Description1Description1Description1Description1Description1",
            };

            await cpuService.EditCpuByIdAndFormModelAsync(cpuId, model);
            var updatedCpu = await dbContext.Cpus.FirstAsync(c => c.Id == cpuId);

            Assert.IsNotNull(updatedCpu);
            Assert.That(updatedCpu.Name, Is.EqualTo("Cpu1Edit"));
            Assert.That(updatedCpu.Price, Is.EqualTo(200));
            Assert.That(updatedCpu.Cores, Is.EqualTo(8));
            Assert.That(updatedCpu.Threads, Is.EqualTo(16));
            Assert.That(updatedCpu.Frequency, Is.EqualTo(3600));
            Assert.That(updatedCpu.TurboFrequency, Is.EqualTo(4200));
            Assert.That(updatedCpu.Cache, Is.EqualTo(32));
            Assert.That(updatedCpu.Tdp, Is.EqualTo(95));
            Assert.That(updatedCpu.RamFrequency, Is.EqualTo(3200));
            Assert.That(updatedCpu.RamType, Is.EqualTo(RamType.DDR4));
            Assert.That(updatedCpu.Socket, Is.EqualTo("Socket1Edit"));
            Assert.That(updatedCpu.ImageUrl, Is.EqualTo("http://ImageUrl1ImageUrl1ImageUrl1.com"));
            Assert.That(updatedCpu.Description, Is.EqualTo("Description1Description1Description1Description1Description1Description1"));
            Assert.That(updatedCpu.ProviderId, Is.EqualTo(Guid.Parse(testProviderId)));
        }

        [Test]
        public async Task IsProviderIdOwnerOfCpuIdReturnsFalseIfProviderIdIsOwner()
        {
            var providerId = testProviderId;
            int cpuId = (await dbContext.Cpus.FirstAsync(c => c.Name == "Cpu1Edit")).Id;

            var result = await cpuService.IsProviderIdOwnerOfCpuIdAsync(providerId, cpuId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task IsCpuExistsByIdReturnsTrueIfExistsInDbContext()
        {
            int cpuId = 1;

            var result = await cpuService.IsCpuExistByIdAsync(cpuId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsCpuExistsByIdReturnsFalseIfNotExistsInDbContext()
        {
            int cpuId = 1000;

            var result = await cpuService.IsCpuExistByIdAsync(cpuId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetAllCpusAsyncReturnsAllCpusFromDbContext()
        {
            var result = await cpuService.GetAllCpusAsync();
            int actualCount = await dbContext.Cpus.CountAsync();

            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(actualCount));
        }

        [Test]
        public async Task GetAllCpusDetailsAsyncReturnsAllCpusFromDbContext()
        {
            var expected = await cpuService.GetAllCpusDetailsAsync();
            int actual = await dbContext.Cpus.CountAsync();

            Assert.IsNotNull(expected);
            Assert.That(expected.Count, Is.EqualTo(actual));
        }

        [Test]
        public async Task SearchCpusAsyncReturnsMatchingCpus()
        {
            var queryModel = new AllQueryModel()
            {
                ComponentsPerPage = 8,
                CurrentPage = 1,
                Sorting = GeneralSorting.Newest,
                SearchTerm = "Cpu1",
            };

            var result = await cpuService.SearchCpusAsync(queryModel);
            int actualCount = await dbContext.Cpus.CountAsync(c => c.Name.Contains(queryModel.SearchTerm));

            Assert.IsNotNull(result);
            Assert.That(result.TotalComponents, Is.EqualTo(actualCount));
        }

        [Test]
        public async Task GetCpuForDeleteByIdAsync()
        {
            int cpuId = (await dbContext.Cpus.FirstAsync(c => c.Name == "Cpu1")).Id;

            var result = await cpuService.GetCpuForDeleteByIdAsync(cpuId);

            Assert.IsNotNull(result);
            Assert.That(result.Name, Is.EqualTo("Cpu1"));
            Assert.That(result.ImageUrl, Is.EqualTo("http://ImageUrl1ImageUrl1.com"));
            Assert.That(result.Description, Is.EqualTo("Description1Description1Description1"));
        }

        [Test]
        public async Task DeleteCpuByIdAsyncRemovesCpuFromDbContext()
        {
            int cpuId = (await dbContext.Cpus.FirstAsync(c => c.Name == "Cpu2")).Id;

            await cpuService.DeleteCpuByIdAsync(cpuId);
            var cpu = await dbContext.Cpus.FirstOrDefaultAsync(c => c.Id == cpuId);

            Assert.IsNull(cpu);
        }
    }
}
