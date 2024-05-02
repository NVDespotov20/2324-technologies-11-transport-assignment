using System;
using System.Collections.Generic;
using System.Linq;
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
    public class RentalAgreementServiceTests
    {
        private RentalAgreementService _rentalAgreementService = new RentalAgreementService();
        private UserService _userService = new UserService();
        private BikeService _bikeService = new BikeService();
        private BikeRentalContext _context;

        private List<int> _testUsernamesIds;
        private List<int> _createdBikeIds;
        private List<int> _createdRentalAgreementIds;

        private DateTime _startDate;
        private DateTime _endDate;
        [SetUp]
        public async Task Setup()
        {
            // Initialize the services and context before each test
            _context = DBContext.GetContext();
            _createdBikeIds = new List<int>();
            _createdRentalAgreementIds = new List<int>();

            // Create test users and bikes
            await GenerateTestUsers();
            await GenerateTestBikes();
        }

        [OneTimeTearDown]
        public async Task TearDown()
        {
            // Cleanup or additional teardown logic
            await DeleteTestRentalAgreements();
            await DeleteTestBikes();
            await DeleteTestUsers();
        }


        public async Task GenerateTestUsers()
        {
            _testUsernamesIds = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                string username = $"Testuser{i + 1}";
                _testUsernamesIds.Add(await _userService.CreateUserAsync(username, "Password123"));
            }
            
        }
        private async Task GenerateTestBikes()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                    _createdBikeIds.Add(
                        await _bikeService.CreateBikeAsync(1, await GetTestUserId(i+1))
                    );
            }
        }
        private async Task<int> GetTestUserId(int index)
        {
            return await _userService.GetUserIdByUserNameAsync($"Testuser{index}");
        }

        private async Task<int> CreateTestRentalAgreement(int bikeId, int renterId)
        {
            _startDate = DateTime.Now;
            _endDate = _startDate.AddDays(5);

            var rentalAgreementId = await _rentalAgreementService.CreateRentalAgreementAsync(bikeId, renterId, _startDate, _endDate);
            _createdRentalAgreementIds.Add(rentalAgreementId);
            return rentalAgreementId;
        }

        private async Task DeleteTestRentalAgreements()
        {
            // Delete the test rental agreements created during setup
            foreach (var rentalAgreementId in _createdRentalAgreementIds)
            {
                await _rentalAgreementService.DeleteRentalAgreementAsync(rentalAgreementId);
            }
        }

        private async Task DeleteTestBikes()
        {
            // Delete the test bikes created during setup
            foreach (var bikeId in _createdBikeIds)
            {
                await _bikeService.DeleteBikeAsync(bikeId);
            }
        }

        private async Task DeleteTestUsers()
        {
            // Delete the test users created during setup
            foreach (var userId in _testUsernamesIds)
            {
                await _userService.DeleteUserAsync(userId);
            }
        }

        [Test]
        public async Task GetAllRentalAgreementsAsync_ShouldReturnAllRentalAgreements()
        {
            var result = await _rentalAgreementService.GetAllRentalAgreementsAsync();

            Assert.IsNotNull(result);
            Assert.IsInstanceOf<IEnumerable<RentalAgreement>>(result);
            Assert.IsTrue(result.Any());
        }

        [Test]
        public async Task CreateRentalAgreementAsync_ShouldCreateRentalAgreement()
        {
            //Arange
            int testId = await GetTestUserId(1);
            // Act
            var rentalAgreementId = await CreateTestRentalAgreement(_createdBikeIds[0], testId);

            // Assert
            Assert.IsTrue(_rentalAgreementService.GetRentalAgreementsByRenterIdAsync(testId).Result.Any(ra => ra.Id == rentalAgreementId));
            await _rentalAgreementService.DeleteRentalAgreementAsync(rentalAgreementId);
        }

        [Test]
        public async Task GetRentalAgreementByIdAsync_ShouldReturnRentalAgreement()
        {
            // Arrange
            var rentalAgreements = await _rentalAgreementService.GetAllRentalAgreementsAsync();
            var rentalAgreementId = rentalAgreements.First().Id;

            // Act
            var result = await _rentalAgreementService.GetRentalAgreementByIdAsync(rentalAgreementId);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<RentalAgreement>(result);
            Assert.AreEqual(rentalAgreementId, result.Id);
        }

        [Test]
        public async Task GetActiveRentalAgreementsByRenterIdAsync_ShouldReturnActiveRentalAgreements()
        {
            // Arange
            int testId = await GetTestUserId(1);
            // Act
            var result = await _rentalAgreementService.GetActiveRentalAgreementsByRenterIdAsync(testId);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<List<RentalAgreement>>(result);
            Assert.IsTrue(result.Any());
            Assert.IsTrue(result.All(ra => ra.RenterId == testId && ra.EndDate > DateTime.Now));
        }

        [Test]
        public async Task DeleteRentalAgreementAsync_ShouldDeleteRentalAgreement()
        {
            // Arrange
            var rentalAgreementId = await CreateTestRentalAgreement(_createdBikeIds[1], await GetTestUserId(2));

            // Act
            var result = await _rentalAgreementService.DeleteRentalAgreementAsync(rentalAgreementId);

            // Assert
            Assert.IsTrue(result);
            Assert.IsNull(await _rentalAgreementService.GetRentalAgreementByIdAsync(rentalAgreementId));
        }
    }
}
