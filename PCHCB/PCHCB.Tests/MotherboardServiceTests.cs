namespace PCHCB.Tests
{
    using Microsoft.EntityFrameworkCore;

    using NUnit.Framework;

    using PCHCB.Data;
    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.ViewModels.Motherboard;
    using PCHCB.Web.ViewModels.Enums;
    using PCHCB.Web.ViewModels.Home;

    [TestFixture]
    public class MotherboardServiceTests
    {
        private PCHCBDbContext dbContext;
        private IMotherboardService motherboardService;
        private const string testProviderId = "3f900985-864b-484d-8612-7e20b74613fb";

        [SetUp]
        public void Setup()
        {
            var option = new DbContextOptionsBuilder<PCHCBDbContext>()
                .UseInMemoryDatabase(databaseName: "PCHCBTestsDB")
                .Options;

            dbContext = new PCHCBDbContext(option);
            motherboardService = new MotherboardService(dbContext);

            dbContext.Motherboards.AddAsync(new Motherboard()
            {
                Name = "Motherboard1",
                Price = 100,
                Socket = "AM4",
                Chipset = "B550",
                FormFactor = MbFormFactor.ATX,
                RamType = RamType.DDR4,
                RamSlots = 4,
                RamCapacity = 128,
                M2Slots = 2,
                SataSlots = 6,
                PcieSlots = 3,
                PcieType = InterfaceType.PCIExpress4,
                ImageUrl = "http://ImageUrl1ImageUrl1.com",
                Description = "Description1Description1Description1",
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse(testProviderId)
            });
        }

        [Test]
        public async Task CreateMotherboardAsyncShouldCreateMotherboardToDbContext()
        {
            var model = new MotherboardFormModel()
            {
                Name = "Motherboard2",
                Price = 200,
                Socket = "AM4",
                Chipset = "B550",
                FormFactor = 0,
                RamType = 1,
                RamSlots = 4,
                RamCapacity = 128,
                M2Slots = 2,
                SataSlots = 6,
                PcieType = 1,
                ImageUrl = "http://ImageUrl2ImageUrl2.com",
                Description = "Description2Description2Description2",
            };

            int initialCount = await dbContext.Motherboards.CountAsync();
            var result = await motherboardService.CreateMotherboardAsync(testProviderId, model);

            int actualCount = await dbContext.Motherboards.CountAsync();
            Assert.IsTrue(initialCount < actualCount);
            var motherboard = await dbContext.Motherboards.FirstOrDefaultAsync(m => m.Name == "Motherboard2");
            Assert.That(motherboard?.Name, Is.EqualTo("Motherboard2"));
            Assert.That(motherboard.Price, Is.EqualTo(200));
            Assert.That(motherboard.Socket, Is.EqualTo("AM4"));
            Assert.That(motherboard.Chipset, Is.EqualTo("B550"));
            Assert.That(motherboard.FormFactor, Is.EqualTo(MbFormFactor.ATX));
            Assert.That(motherboard.RamType, Is.EqualTo(RamType.DDR4));
            Assert.That(motherboard.RamSlots, Is.EqualTo(4));
            Assert.That(motherboard.RamCapacity, Is.EqualTo(128));
            Assert.That(motherboard.M2Slots, Is.EqualTo(2));
            Assert.That(motherboard.SataSlots, Is.EqualTo(6));
            Assert.That(motherboard.PcieType, Is.EqualTo(InterfaceType.PCIExpress4));
            Assert.That(motherboard.ImageUrl, Is.EqualTo("http://ImageUrl2ImageUrl2.com"));
            Assert.That(motherboard.Description, Is.EqualTo("Description2Description2Description2"));
            Assert.That(motherboard.ProviderId.ToString(), Is.EqualTo(testProviderId));
            Assert.That(result > 1, Is.EqualTo(true));
        }

        [Test]
        public async Task GetMotherboardForEditByIdAsyncShouldReturnCorrectMotherboard()
        {
            int motherboardId = (await dbContext.Motherboards.FirstAsync(m => m.Name == "Motherboard1")).Id;

            var result = await motherboardService.GetMotherboardForEditByIdAsync(motherboardId);

            Assert.IsNotNull(result);
            Assert.That(result.Name, Is.EqualTo("Motherboard1"));
            Assert.That(result.Price, Is.EqualTo(100));
            Assert.That(result.Socket, Is.EqualTo("AM4"));
            Assert.That(result.Chipset, Is.EqualTo("B550"));
            Assert.That(result.FormFactor, Is.EqualTo(0));
            Assert.That(result.RamType, Is.EqualTo(1));
            Assert.That(result.RamSlots, Is.EqualTo(4));
            Assert.That(result.RamCapacity, Is.EqualTo(128));
            Assert.That(result.M2Slots, Is.EqualTo(2));
            Assert.That(result.SataSlots, Is.EqualTo(6));
            Assert.That(result.PcieType, Is.EqualTo(1));
            Assert.That(result.ImageUrl, Is.EqualTo("http://ImageUrl1ImageUrl1.com"));
            Assert.That(result.Description, Is.EqualTo("Description1Description1Description1"));
        }

        [Test]
        public async Task EditMotherboardByIdAndFormModelUpdatesExistingMotherboardInDbContext()
        {
            int motherboardId = (await dbContext.Motherboards.FirstAsync(m => m.Name == "Motherboard1")).Id;
            var model = new MotherboardFormModel()
            {
                Name = "Motherboard1Edit",
                Price = 200.12m,
                Socket = "AM4",
                Chipset = "B550",
                FormFactor = 0,
                RamType = 1,
                RamSlots = 4,
                RamCapacity = 128,
                M2Slots = 2,
                SataSlots = 6,
                PcieType = 1,
                ImageUrl = "http://ImageUrl1ImageUrl1.com/image.png",
                Description = "Description1Description1Description1 Description1Description1Description1",
            };

            await motherboardService.EditMotherboardByIdAndFormModelAsync(motherboardId, model);
            var updatedMotherboard = await dbContext.Motherboards.FirstAsync(m => m.Id == motherboardId);

            Assert.IsNotNull(updatedMotherboard);
            Assert.That(updatedMotherboard.Name, Is.EqualTo("Motherboard1Edit"));
            Assert.That(updatedMotherboard.Price, Is.EqualTo(200.12m));
            Assert.That(updatedMotherboard.Socket, Is.EqualTo("AM4"));
            Assert.That(updatedMotherboard.Chipset, Is.EqualTo("B550"));
            Assert.That(updatedMotherboard.FormFactor, Is.EqualTo(MbFormFactor.ATX));
            Assert.That(updatedMotherboard.RamType, Is.EqualTo(RamType.DDR4));
            Assert.That(updatedMotherboard.RamSlots, Is.EqualTo(4));
            Assert.That(updatedMotherboard.RamCapacity, Is.EqualTo(128));
            Assert.That(updatedMotherboard.M2Slots, Is.EqualTo(2));
            Assert.That(updatedMotherboard.SataSlots, Is.EqualTo(6));
            Assert.That(updatedMotherboard.PcieType, Is.EqualTo(InterfaceType.PCIExpress4));
            Assert.That(updatedMotherboard.ImageUrl, Is.EqualTo("http://ImageUrl1ImageUrl1.com/image.png"));
            Assert.That(updatedMotherboard.Description, Is.EqualTo("Description1Description1Description1 Description1Description1Description1"));
        }

        [Test]
        public async Task IsProviderIdOwnerOfMotherboardIdReturnsFalseIfProviderIdIsOwner()
        {
            var providerId = Guid.Parse(testProviderId);
            int motherboardId = (await dbContext.Motherboards.FirstAsync(c => c.Name == "Motherboard1Edit")).Id;

            var result = await motherboardService.IsProviderIdOwnerOfMotherboardIdAsync(providerId.ToString(), motherboardId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task IsMotherboardExistsByIdReturnsTrueIfExistsInDbContext()
        {
            int motherboardId = 1;

            var result = await motherboardService.IsMotherboardExistByIdAsync(motherboardId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsMotherboardExistsByIdReturnsFalseIfNotExistsInDbContext()
        {
            int motherboardId = 1000;

            var result = await motherboardService.IsMotherboardExistByIdAsync(motherboardId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetAllMotherboardsAsyncReturnsAllMotherboardsFromDbContext()
        {
            var result = await motherboardService.GetAllMotherboardsAsync();
            int actualCount = await dbContext.Motherboards.CountAsync();

            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(actualCount));
        }

        [Test]
        public async Task SearchAllMotherboardsAsyncReturnsMatchingMotherboards()
        {
            var queryModel = new AllQueryModel()
            {
                SearchTerm = "Motherboard1",
                Sorting = GeneralSorting.Oldest,
                CurrentPage = 1,
                ComponentsPerPage = 12,
            };

            var result = await motherboardService.SearchMotherboardsAsync(queryModel);
            int actualCount = await dbContext.Motherboards.CountAsync(m => m.Name.Contains(queryModel.SearchTerm));

            Assert.IsNotNull(result);
            Assert.IsNotNull(actualCount);
            Assert.IsNotNull(result);
            Assert.That(result.TotalComponents, Is.EqualTo(actualCount));
        }

        [Test]
        public async Task DeleteMotherboardByIdAsyncRemovesMotherboardFromDbContext()
        {
            int motherboardId = (await dbContext.Motherboards.FirstAsync(m => m.Name == "Motherboard2")).Id;
            await motherboardService.DeleteMotherboardByIdAsync(motherboardId);
            var deletedMotherboard = await dbContext.Motherboards.FirstOrDefaultAsync(m => m.Id == motherboardId);

            Assert.IsNull(deletedMotherboard);
        }
    }
}
