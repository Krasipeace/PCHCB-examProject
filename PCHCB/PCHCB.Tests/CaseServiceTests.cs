namespace PCHCB.UnitTests.Controllers
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
        private const string providerId = "3f900985-864b-484d-8612-7e20b74613fb";

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<PCHCBDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
            this.dbContext = new PCHCBDbContext(options);
            this.caseService = new CaseService(this.dbContext);

            this.dbContext.Cases.AddAsync(new Data.Models.Case()
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
                ProviderId = Guid.Parse(providerId)
            });
            this.dbContext.Cases.AddAsync(new Data.Models.Case()
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

            this.dbContext.SaveChanges();
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
                Description = "This is a test case."
            };
            var initialTotalCaseCount = await this.dbContext.Cases.CountAsync();

            await this.caseService.CreateCaseAsync(providerId, caseFormModel);

            var newTotalCaseCount = await this.dbContext.Cases.CountAsync();
            Assert.IsTrue(newTotalCaseCount > initialTotalCaseCount);
        }

        [Test]
        public async Task GetCaseForEditByIdReturnsCorrectData()
        {
            var caseId = (await this.dbContext.Cases.FirstAsync(c => c.Name == "Case1")).Id;

            var result = await this.caseService.GetCaseForEditByIdAsync(caseId);

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
            var caseId = (await this.dbContext.Cases.FirstAsync(c => c.Name == "Case1")).Id;
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

            await this.caseService.EditCaseByIdAndFormModelAsync(caseId, caseFormModel);

            var updatedCase = await this.dbContext.Cases.FirstAsync(c => c.Id == caseId);
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
            var caseId = (await this.dbContext.Cases.FirstAsync(c => c.Name == "Case1")).Id;

            var result = await this.caseService.IsCaseExistByIdAsync(caseId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsCaseExistByIdReturnsFalseIfCaseDoesNotExistInDbContext()
        {
            var caseId = -1; 

            var result = await this.caseService.IsCaseExistByIdAsync(caseId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task IsProviderIdOwnerOfCaseIdReturnsFalseIfCaseIsOwnedByProviderWithProviderId()
        {
            var testProviderId = providerId;
            var caseId = (await this.dbContext.Cases.FirstAsync(c => c.Name == "Case1")).Id;

            var result = await this.caseService.IsProviderIdOwnerOfCaseIdAsync(testProviderId, caseId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task IsProviderIdOwnerOfCaseIdReturnsFalseIfCaseIsNotOwnedByProviderWithProvidedProviderId()
        {
            var providerId = "f1605898-5dc5-485e-9893-9306626a4b53";
            var caseId = (await this.dbContext.Cases.FirstAsync(c => c.Name == "Case1")).Id;

            var result = await this.caseService.IsProviderIdOwnerOfCaseIdAsync(providerId.ToString(), caseId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task DeleteCaseByIdRemovesCaseFromDbContext()
        {
            var caseId = (await this.dbContext.Cases.FirstAsync(c => c.Name == "Case1")).Id;

            await this.caseService.DeleteCaseByIdAsync(caseId);

            var result = await this.dbContext.Cases.FirstOrDefaultAsync(c => c.Id == caseId);
            Assert.Null(result);
        }

        [Test]
        public async Task GetAllCasesAsyncReturnsAllCasesFromDbContext()
        {
            var result = (await this.caseService.GetAllCasesAsync());

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

            var result = (await this.caseService.SearchCasesAsync(queryModel));

            Assert.That(result.TotalComponents, Is.EqualTo(9));
        }
    }
}
