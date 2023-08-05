namespace PCHCB.Tests
{
    using Microsoft.EntityFrameworkCore;

    using NUnit.Framework;

    using PCHCB.Data;
    using PCHCB.Data.Models;
    using PCHCB.Services.Data;
    using PCHCB.Services.Data.Contracts;

    [TestFixture]
    public class UserServiceTests
    {
        private PCHCBDbContext dbContext;
        private IUserService userService;

        [SetUp]
        public void Setup()
        {
            var option = new DbContextOptionsBuilder<PCHCBDbContext>()
                .UseInMemoryDatabase(databaseName: "PCHCBTestsDB")
                .Options;
            dbContext = new PCHCBDbContext(option);
            userService = new UserService(dbContext);

            dbContext.Users.AddAsync(new ApplicationUser()
            {
                FirstName = "FirstName1",
                LastName = "LastName1",
                Email = "user@email.net"
            });

            dbContext.SaveChanges();
        }

        [Test]
        public async Task GetFullNameByEmailAsyncShouldReturnFullName()
        {
            string fullName = await userService.GetFullNameByEmailAsync("user@email.net");

            Assert.That(fullName, Is.EqualTo("FirstName1 LastName1"));
        }

        [Test]
        public async Task AllUsersAsyncShouldReturnAllUsersCorrectly()
        {
            var userService = new UserService(dbContext);

            var user1 = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "test1",
                LastName = "test2",
                Email = "test12@test.com"
            };

            var user2 = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "test3",
                LastName = "test4",
                Email = "test34@test.com"
            };

            dbContext.Users.AddRange(user1, user2);
            dbContext.SaveChanges();

            var result = await userService.AllUsersAsync();
            Assert.That(result.Count, Is.EqualTo(3));

            var userViewModel = result.FirstOrDefault(u => u.Email == user1.Email);
            Assert.That(userViewModel, Is.Not.Null);
            Assert.That(userViewModel.FullName, Is.EqualTo("test1 test2"));
            Assert.That(userViewModel.PhoneNumber, Is.EqualTo(string.Empty));

            userViewModel = result.FirstOrDefault(u => u.Email == user2.Email);
            Assert.That(userViewModel, Is.Not.Null);
            Assert.That(userViewModel.FullName, Is.EqualTo("test3 test4"));
            Assert.That(userViewModel.PhoneNumber, Is.EqualTo(string.Empty));
        }

        [Test]
        public async Task GetFullNameByEmailAsyncShouldReturnFullNameWhenEmailExists()
        {
            var userService = new UserService(dbContext);

            var user1 = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "Kra",
                LastName = "Dra",
                Email = "kradra@test.com"
            };

            dbContext.Users.Add(user1);
            dbContext.SaveChanges();

            var result = await userService.GetFullNameByEmailAsync(user1.Email);

            Assert.That(result, Is.EqualTo("Kra Dra"));
        }

        [Test]
        public async Task GetFullNameByEmailAsyncShouldReturnEmptyStringWhenEmailDoesNotExist()
        {
            var userService = new UserService(dbContext);

            var result = await userService.GetFullNameByEmailAsync("noMail1111@test.com");

            Assert.That(result, Is.EqualTo(""));
        }
    }
}
