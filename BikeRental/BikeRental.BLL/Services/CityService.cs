using System.Collections.Generic;
using System.Threading.Tasks;
using BikeRental.BLL.Interfaces;
using BikeRental.DAL;
using BikeRental.DAL.Data;
using BikeRental.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeRental.BLL.Services
{
    public class CityService : ICityService
    {
        private readonly BikeRentalContext _context;

        public CityService()
        {
            _context = DBContext.GetContext();
        }

        public async Task<IEnumerable<City>> GetAllCitiesAsync()
        {
            return await _context.Cities.ToListAsync();
        }

        public async Task<City?> GetCityByIdAsync(int cityId)
        {
            return await _context.Cities.FindAsync(cityId);
        }
        public async Task<string> GetCityNameByIdAsync(int cityId)
        {
            var city = await _context.Cities.FindAsync(cityId);
            return city?.Name ?? "Unknown";
        }
        public async Task<int> GetCityIdByNameAsync(string cityName)
        {
            var city = await _context.Cities
                .Where(c => c.Name == cityName)
                .FirstOrDefaultAsync();

            return city != null ? city.Id : -1; // Return -1 if city is not found
        }
        public async Task<List<City>> GetCitiesByCountryIdAsync(int countryId)
        {
            return await _context.Cities
                .Where(city => city.CountryId == countryId)
                .ToListAsync();
        }

        public async Task<int> CreateCityAsync(string cityName, int countryId)
        {
            var newCity = new City
            {
                Name = cityName,
                CountryId = countryId
            };

            await _context.Cities.AddAsync(newCity);
            await _context.SaveChangesAsync();

            return newCity.Id;
        }

        public async Task<bool> DeleteCityAsync(int cityId)
        {
            var cityToDelete = await _context.Cities.FindAsync(cityId);

            if (cityToDelete != null)
            {
                _context.Cities.Remove(cityToDelete);
                await _context.SaveChangesAsync();
                return true; // City successfully deleted
            }

            return false; // City not found
        }
    }
}
