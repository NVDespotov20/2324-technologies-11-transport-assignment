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
    public class CityServiceTests
    {
        private CityService _cityService;
        private BikeRentalContext _context;

        // Keep track of the created cities to delete them later
        private List<int> _createdCityIds;

        [SetUp]
        public void Setup()
        {
            // Initialize the service and context before each test
            _context = DBContext.GetContext();
            _cityService = new CityService();
            _createdCityIds = new List<int>();
        }

        [OneTimeTearDown]
        public async Task TearDown()
        {
            // Cleanup or additional teardown logic
            // Delete any cities created during the tests
            foreach (var cityId in _createdCityIds)
            {
                await _cityService.DeleteCityAsync(cityId);
            }
        }

        [Test]
        public async Task GetCityNameByIdAsync_ShouldReturnCityName()
        {
            // Act
            var result = await _cityService.GetCityNameByIdAsync(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Kabul", result);
        }

        [Test]
        public async Task GetCityIdByNameAsync_ShouldReturnCityId()
        {
            // Act
            var result = await _cityService.GetCityIdByNameAsync("Buenos Aires");

            // Assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public async Task GetCitiesByCountryIdAsync_ShouldReturnCities()
        {
            // Arrange
            var countryId = 2;

            // Act
            var result = await _cityService.GetCitiesByCountryIdAsync(countryId);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<List<City>>(result);
            Assert.AreEqual(5, result.Count); // Assuming there are 5 cities in country with Id 2
            Assert.IsTrue(result.Any(c => c.Name == "Buenos Aires"));
        }

        [Test]
        public async Task CreateCityAsync_ShouldCreateCity()
        {
            // Act
            var cityId = await _cityService.CreateCityAsync("TestCity", 1);

            // Assert
            Assert.IsTrue(_cityService.GetCityByIdAsync(cityId).Result != null);

            // Store the created city Id for cleanup
            _createdCityIds.Add(cityId);
        }

        [Test]
        public async Task DeleteCityAsync_ShouldDeleteCity()
        {
            // Arrange
            var cityId = await _cityService.CreateCityAsync("CityToDelete", 1);

            // Act
            var result = await _cityService.DeleteCityAsync(cityId);

            // Assert
            Assert.IsTrue(result);
            Assert.IsNull(await _cityService.GetCityByIdAsync(cityId));

            // Remove the created city Id from the cleanup list
            _createdCityIds.Remove(cityId);
        }
    }
}
