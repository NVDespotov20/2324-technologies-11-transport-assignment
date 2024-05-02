using System;
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
    public class CountryServiceTests
    {
        private CountryService _countryService;
        private BikeRentalContext _context;

        // Keep track of the created countries to delete them later
        private List<int> _createdCountryIds;

        [SetUp]
        public void Setup()
        {
            // Initialize the service and context before each test
            _context = DBContext.GetContext();
            _countryService = new CountryService();
            _createdCountryIds = new List<int>();
        }

        [OneTimeTearDown]
        public async Task TearDown()
        {
            // Cleanup or additional teardown logic
            // Delete any countries created during the tests
            foreach (var countryId in _createdCountryIds)
            {
                await _countryService.DeleteCountryAsync(countryId);
            }
        }

        [Test]
        public async Task GetCountryNameByIdAsync_ShouldReturnCountryName()
        {
            // Act
            var result = await _countryService.GetCountryNameByIdAsync(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Afghanistan", result);
        }

        [Test]
        public void GetCountryNameByCityId_ShouldReturnCountryName()
        {
            // Act
            var result = _countryService.GetCountryNameByCityId(1);

            // Assert
            Assert.AreEqual("Afghanistan", result);
        }

        [Test]
        public async Task CreateCountryAsync_ShouldCreateCountry()
        {
            // Act
            var countryId = await _countryService.CreateCountryAsync("TestCountry");

            // Assert
            Assert.IsTrue(_countryService.GetCountryByIdAsync(countryId).Result != null);

            // Store the created country Id for cleanup
            _createdCountryIds.Add(countryId);
        }

        [Test]
        public async Task DeleteCountryAsync_ShouldDeleteCountry()
        {
            // Arrange
            var countryId = await _countryService.CreateCountryAsync("CountryToDelete");

            // Act
            var result = await _countryService.DeleteCountryAsync(countryId);

            // Assert
            Assert.IsTrue(result);
            Assert.IsNull(await _countryService.GetCountryByIdAsync(countryId));

            // Remove the created country Id from the cleanup list
            _createdCountryIds.Remove(countryId);
        }
    }
}
