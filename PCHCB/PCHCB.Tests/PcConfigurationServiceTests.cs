namespace PCHCB.Tests
{
    using Microsoft.EntityFrameworkCore;

    using NUnit.Framework;

    using PCHCB.Data.Models.Enums;
    using PCHCB.Data;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Data.Models;
    using PCHCB.Services.Data;

    using static PCHCB.Common.ComponentsWattageConstants.Ram;
    using static PCHCB.Common.ComponentsWattageConstants.Storage;
    using static PCHCB.Common.ComponentsWattageConstants.Motherboard;
    using static PCHCB.Common.ComponentsWattageConstants.Cooler;

    [TestFixture]
    internal class PcConfigurationServiceTests
    {
        private DbContextOptions<PCHCBDbContext> dbContext;
        private IPcConfigurationService service;

        [SetUp]
        public void Setup()
        {
            this.dbContext =
                new DbContextOptionsBuilder<PCHCBDbContext>()
                .UseInMemoryDatabase(databaseName: "PCHCBPcConfigTests")
                .Options;

            this.service = new PcConfigurationService(new PCHCBDbContext(this.dbContext));
        }

        [Test]
        public void CalculateWattageShouldReturnCorrectResult()
        {
            var cpu = new Cpu { Id = 1, Tdp = 100 };
            var gpu = new Gpu { Id = 1, PowerConsumption = 100 };
            var motherboard = new Motherboard { Id = 1, FormFactor = MbFormFactor.ATX };
            var cooler = new Cooler { Id = 1, Type = CoolerType.Air };
            var storage = new Storage { Id = 1, Type = StorageType.SSD };
            var ram = new Ram { Id = 1, Type = RamType.DDR4 };

            var motherboardWatts = service.GetMotherboardWattage(motherboard);
            var ramWatts = service.GetRamWattage(ram);
            var storageWatts = service.GetStorageWattage(storage);
            var coolerWatts = service.GetCoolerWattage(cooler);

            double result = 100 + 100 + AtxWattage + SsdWattage + Ddr4Wattage + AirWattage;

            Assert.That(result, Is.EqualTo(motherboardWatts + storageWatts + ramWatts + coolerWatts + cpu.Tdp + gpu.PowerConsumption));
        }

        [Test]
        public void GetRamWattageReturnsCorrectResult()
        {
            var ram = new Ram { Type = RamType.DDR4 };

            double result = service.GetRamWattage(ram);

            Assert.That(result, Is.EqualTo(Ddr4Wattage));
        }

        [Test]
        public void GetMotherboardWattageReturnsCorrectResult()
        {
            var motherboard = new Motherboard { FormFactor = MbFormFactor.ATX };

            double result = service.GetMotherboardWattage(motherboard);

            Assert.That(result, Is.EqualTo(AtxWattage));
        }

        [Test]
        public void TestGetStorageWattageReturnsCorrectResult()
        {
            var storage = new Storage { Type = StorageType.SSD };

            double result = service.GetStorageWattage(storage);

            Assert.That(result, Is.EqualTo(SsdWattage));
        }

        [Test]
        public void GetCoolerWattageReturnsCorrectResult()
        {
            var cooler = new Cooler { Type = CoolerType.Air };

            double result = service.GetCoolerWattage(cooler);

            Assert.That(result, Is.EqualTo(AirWattage));
        }
    }
}
