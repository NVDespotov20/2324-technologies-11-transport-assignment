using System.Collections.Generic;
using System.Threading.Tasks;
using BikeRental.BLL.Services;
using BikeRental.DAL;
using BikeRental.DAL.Data;
using BikeRental.DAL.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace BikeRental.Tests.BLL.Services
{
    [TestFixture]
    public class BikeServiceTests
    {
        private BikeService _bikeService = new BikeService();
        private UserService _userService = new UserService();
        private BikeRentalContext _context;

        private List<string> _testUsernames;

        [SetUp]
        public async Task Setup()
        {
            // Initialize the service and context before each test
            _context = DBContext.GetContext();

            // Create test users and store their usernames
            await GenerateTestData();
        }

        [OneTimeTearDown]
        public async Task TearDown()
        {
            // Cleanup or additional teardown logic
            await DeleteTestUsers();
        }

        public async Task GenerateTestData()
        {
            _testUsernames = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                string username = $"testuser{i + 1}";
                await _userService.CreateUserAsync(username, "Password123");
                _testUsernames.Add(username);
            }
            UserService.CurrentUser = await _userService.GetUserByUsernameAsync(_testUsernames[0]);
        }

        private async Task<int> GetTestUserId(int index)
        {
            return await _userService.GetUserIdByUserNameAsync($"testuser{index}");
        }

        private async Task DeleteTestUsers()
        {
            // Delete the test users created during setup
            foreach (var username in _testUsernames)
            {
                var user = await _userService.GetUserByUsernameAsync(username);
                if (user != null)
                {
                    await _userService.DeleteUserAsync(user.Id);
                }
            }
        }

        [Test]
        public async Task GetAllBikesAsync_ShouldReturnAllBikes()
        {
            var result = await _bikeService.GetAllBikesAsync();

            Assert.IsNotNull(result);
            Assert.IsInstanceOf<IEnumerable<Bike>>(result);
            Assert.IsTrue(result.Any(r => r.OwnerId == GetTestUserId(1).Result));
        }

        [Test]
        public async Task CreateBikeAsync_ShouldCreateBike()
        {
            // Act
            var bikeId = await _bikeService.CreateBikeAsync(1, await GetTestUserId(1));

            // Assert
            Assert.IsTrue(_bikeService.GetBikesByOwnerIdAsync(await GetTestUserId(1)).Result.Any(b => b.Id == bikeId));
            await _bikeService.DeleteBikeAsync(bikeId);
        }

        [Test]
        public async Task GetBikeByIdAsync_ShouldReturnBike()
        {
            // Arrange
            var bikes = await _bikeService.GetAllBikesAsync();
            var bikeId = bikes.First().Id;

            // Act
            var result = await _bikeService.GetBikeByIdAsync(bikeId);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<Bike>(result);
            Assert.AreEqual(bikeId, result.Id);
        }

        [Test]
        public async Task GetBikesByOwnerIdAsync_ShouldReturnBikes()
        {
            // Arrange
            var ownerId = await GetTestUserId(1);

            // Act
            var result = await _bikeService.GetBikesByOwnerIdAsync(ownerId);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<List<Bike>>(result);
            Assert.IsTrue(result.Any());
            Assert.IsTrue(result.All(b => b.OwnerId == ownerId));
        }

        [Test]
        public async Task GetBikesByCityIdAsync_ShouldReturnBikes()
        {
            // Arrange
            var cityId = 1;

            // Act
            var result = await _bikeService.GetBikesByCityIdAsync(cityId);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<List<Bike>>(result);
        }

        [Test]
        public async Task GetBikesByCityIdExceptOwnedAsync_ShouldReturnBikes()
        {
            // Arrange
            var cityId = 1;

            // Act
            var result = await _bikeService.GetBikesByCityIdExceptOwnedAsync(cityId);

            // Assert
            Assert.IsNotEmpty(result);
            Assert.IsInstanceOf<List<Bike>>(result);
        }

        [Test]
        public async Task DeleteBikeAsync_ShouldDeleteBike()
        {
            // Arrange
            var bikeId = await _bikeService.CreateBikeAsync(1, await GetTestUserId(1));

            // Act
            var result = await _bikeService.DeleteBikeAsync(bikeId);

            // Assert
            Assert.IsTrue(result);
            Assert.IsNull(await _bikeService.GetBikeByIdAsync(bikeId));
        }
    }
}
