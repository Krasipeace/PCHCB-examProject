namespace PCHCB.Tests
{
    using Microsoft.EntityFrameworkCore;
    using NUnit.Framework;

    using PCHCB.Data.Models.Enums;
    using PCHCB.Data;
    using PCHCB.Services.Data;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.ViewModels.Case;
    using PCHCB.Web.ViewModels.Enums;
    using PCHCB.Web.ViewModels.Home;

    [TestFixture]
    public class CaseServiceTests
    {
        private PCHCBDbContext dbContext;
        private ICaseService caseService;
        private const string testProviderId = "3f900985-864b-484d-8612-7e20b74613fb";

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<PCHCBDbContext>()
                .UseInMemoryDatabase(databaseName: "PCHCBTestsDB")
                .Options;
            dbContext = new PCHCBDbContext(options);
            caseService = new CaseService(dbContext);

            dbContext.Cases.AddAsync(new Data.Models.Case()
            {
                Name = "Case1",
                Price = 100,
                CaseSize = CaseSize.FullTower,
                FormFactor = MbFormFactor.ATX,
                MaxGpuLength = 500,
                MaxAirCpuCoolerHeight = 150,
                PsuFactor = PsuFactor.Sfx,
                ImageUrl = "http://image.url",
                MaxRadiatorLength = 400,
                Description = "Description1Description1Description1",
                AddedOn = DateTime.Now,
                ProviderId = Guid.Parse(testProviderId)
            });
            dbContext.Cases.AddAsync(new Data.Models.Case()
            {
                Name = "Case2",
                Price = 150,
                CaseSize = CaseSize.MidTower,
                FormFactor = MbFormFactor.MicroATX,
                MaxGpuLength = 450,
                MaxAirCpuCoolerHeight = 140,
                PsuFactor = PsuFactor.Atx,
                ImageUrl = "http://image2.url",
                MaxRadiatorLength = 450,
                Description = "Description2Description2Description2",
                AddedOn = DateTime.Now,
                ProviderId = Guid.Parse("f1605898-5dc5-485e-9893-9306626a4b53")
            });

            dbContext.SaveChanges();
        }

        [Test]
        public async Task CreateCaseAddsCaseToDbContext()
        {
            var caseFormModel = new CaseFormModel()
            {
                Name = "Test Case 1",
                Price = 120,
                CaseSize = 2,
                FormFactor = 1,
                MaxGpuLength = 350,
                MaxAirCpuCoolerHeight = 125,
                PsuFactor = 1,
                ImageUrl = "test/image/url",
                MaxRadiatorLength = 240,
                Description = "This is a test case.",
            };
            var initialTotalCaseCount = await dbContext.Cases.CountAsync();

            await caseService.CreateCaseAsync(testProviderId, caseFormModel);

            var newTotalCaseCount = await dbContext.Cases.CountAsync();
            Assert.IsTrue(newTotalCaseCount > initialTotalCaseCount);

            var newCase = await dbContext.Cases.FirstAsync(c => c.Name == "Test Case 1");
            Assert.IsNotNull(newCase);
            Assert.That(newCase.Name, Is.EqualTo("Test Case 1"));
            Assert.That(newCase.Price, Is.EqualTo(120));
            Assert.That(newCase.CaseSize, Is.EqualTo(CaseSize.FullTower));
            Assert.That(newCase.FormFactor, Is.EqualTo(MbFormFactor.MicroATX));
            Assert.That(newCase.MaxGpuLength, Is.EqualTo(350));
            Assert.That(newCase.MaxAirCpuCoolerHeight, Is.EqualTo(125));
            Assert.That(newCase.PsuFactor, Is.EqualTo(PsuFactor.Lfx));
            Assert.That(newCase.ImageUrl, Is.EqualTo("test/image/url"));
            Assert.That(newCase.MaxRadiatorLength, Is.EqualTo(240));
            Assert.That(newCase.Description, Is.EqualTo("This is a test case."));
        }

        [Test]
        public async Task GetCaseForEditByIdReturnsCorrectData()
        {
            var caseId = (await dbContext.Cases.FirstAsync(c => c.Name == "Case1")).Id;

            var result = await caseService.GetCaseForEditByIdAsync(caseId);

            Assert.That(result.Name, Is.EqualTo("Case1"));
            Assert.That(result.Price, Is.EqualTo(100));
            Assert.That(result.CaseSize, Is.EqualTo(2));
            Assert.That(result.FormFactor, Is.EqualTo(0));
            Assert.That(result.MaxGpuLength, Is.EqualTo(500));
            Assert.That(result.MaxAirCpuCoolerHeight, Is.EqualTo(150));
            Assert.That(result.PsuFactor, Is.EqualTo(2));
            Assert.That(result.ImageUrl, Is.EqualTo("http://image.url"));
            Assert.That(result.MaxRadiatorLength, Is.EqualTo(400));
            Assert.That(result.Description, Is.EqualTo("Description1Description1Description1"));
        }

        [Test]
        public async Task EditCaseByIdAndFormModelUpdatesExistingCaseInDbContext()
        {
            var caseId = (await dbContext.Cases.FirstAsync(c => c.Name == "Case1")).Id;
            var caseFormModel = new CaseFormModel()
            {
                Name = "Case1 Updated",
                Price = 90,
                CaseSize = 1,
                FormFactor = 2,
                MaxGpuLength = 480,
                MaxAirCpuCoolerHeight = 140,
                PsuFactor = 5,
                ImageUrl = "http://image.url/updated",
                MaxRadiatorLength = 360,
                Description = "This is an updated case"
            };

            await caseService.EditCaseByIdAndFormModelAsync(caseId, caseFormModel);

            var updatedCase = await dbContext.Cases.FirstAsync(c => c.Id == caseId);
            Assert.That(updatedCase?.Name, Is.EqualTo("Case1 Updated"));
            Assert.That(updatedCase.Price, Is.EqualTo(90));
            Assert.That(updatedCase.CaseSize, Is.EqualTo(CaseSize.MidTower));
            Assert.That(updatedCase.FormFactor, Is.EqualTo(MbFormFactor.MiniITX));
            Assert.That(updatedCase.MaxGpuLength, Is.EqualTo(480));
            Assert.That(updatedCase.MaxAirCpuCoolerHeight, Is.EqualTo(140));
            Assert.That(updatedCase.PsuFactor, Is.EqualTo(PsuFactor.flexAtx));
            Assert.That(updatedCase.ImageUrl, Is.EqualTo("http://image.url/updated"));
            Assert.That(updatedCase.MaxRadiatorLength, Is.EqualTo(360));
            Assert.That(updatedCase.Description, Is.EqualTo("This is an updated case"));
        }

        [Test]
        public async Task IsCaseExistByIdReturnsTrueIfCaseExistsInDbContext()
        {
            var caseId = (await dbContext.Cases.FirstAsync(c => c.Name == "Case1")).Id;

            var result = await caseService.IsCaseExistByIdAsync(caseId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsCaseExistByIdReturnsFalseIfCaseDoesNotExistInDbContext()
        {
            var caseId = -1;

            var result = await caseService.IsCaseExistByIdAsync(caseId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task IsProviderIdOwnerOfCaseIdReturnsFalseIfCaseIsOwnedByProviderWithProviderId()
        {
            var providerId = testProviderId;
            var caseId = (await dbContext.Cases.FirstAsync(c => c.Name == "Case1")).Id;

            var result = await caseService.IsProviderIdOwnerOfCaseIdAsync(providerId, caseId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task IsProviderIdOwnerOfCaseIdReturnsFalseIfCaseIsNotOwnedByProviderWithProvidedProviderId()
        {
            var providerId = "f1605898-5dc5-485e-9893-9306626a4b53";
            var caseId = (await dbContext.Cases.FirstAsync(c => c.Name == "Case1")).Id;

            var result = await caseService.IsProviderIdOwnerOfCaseIdAsync(providerId.ToString(), caseId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task DeleteCaseByIdRemovesCaseFromDbContext()
        {
            var caseId = (await dbContext.Cases.FirstAsync(c => c.Name == "Case1")).Id;

            await caseService.DeleteCaseByIdAsync(caseId);

            var result = await dbContext.Cases.FirstOrDefaultAsync(c => c.Id == caseId);
            Assert.Null(result);
        }

        [Test]
        public async Task GetAllCasesAsyncReturnsAllCasesFromDbContext()
        {
            var result = await caseService.GetAllCasesAsync();

            Assert.That(result.Count(), Is.EqualTo(8));
        }

        [Test]
        public async Task SearchCasesAsyncReturnsMatchingCases()
        {
            var queryModel = new AllQueryModel()
            {
                ComponentsPerPage = 10,
                CurrentPage = 1,
                Sorting = GeneralSorting.Newest,
                SearchTerm = "Case1"
            };

            var result = await caseService.SearchCasesAsync(queryModel);

            Assert.That(result.TotalComponents, Is.EqualTo(9));
        }
    }
}
