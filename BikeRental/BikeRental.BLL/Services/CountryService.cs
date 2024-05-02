using System.Collections.Generic;
using System.Threading.Tasks;
using BikeRental.BLL.Interfaces;
using BikeRental.DAL;
using BikeRental.DAL.Data;
using BikeRental.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeRental.BLL.Services
{
    public class CountryService : ICountryService
    {
        private readonly BikeRentalContext _context;

        public CountryService()
        {
            _context = DBContext.GetContext();
        }

        public async Task<List<Country>> GetAllCountriesAsync()
        {
            return await _context.Countries.ToListAsync();
        }

        public async Task<Country?> GetCountryByIdAsync(int countryId)
        {
            return await _context.Countries.FindAsync(countryId);
        }
        public async Task<string> GetCountryNameByIdAsync(int countryId)
        {
            var country = await _context.Countries.FindAsync(countryId);
            return country?.Name ?? "Unknown";
        }
        public string GetCountryNameByCityId(int cityId)
        {
            try
            {
                return _context.Countries
                    .FirstOrDefault(c => c.Cities.FirstOrDefault(c => c.Id == cityId) != null)!.Name;
            }
            catch (Exception ex)
            {
                return "Unknown";
            }
        }
        public async Task<int> CreateCountryAsync(string countryName)
        {
            var newCountry = new Country
            {
                Name = countryName
            };

            await _context.Countries.AddAsync(newCountry);
            await _context.SaveChangesAsync();

            return newCountry.Id;
        }

        public async Task<bool> DeleteCountryAsync(int countryId)
        {
            var countryToDelete = await _context.Countries.FindAsync(countryId);

            if (countryToDelete != null)
            {
                _context.Countries.Remove(countryToDelete);
                await _context.SaveChangesAsync();
                return true; // Country successfully deleted
            }

            return false; // Country not found
        }
    }
}
