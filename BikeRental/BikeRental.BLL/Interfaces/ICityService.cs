using System.Collections.Generic;
using System.Threading.Tasks;
using BikeRental.DAL.Models;

namespace BikeRental.BLL.Interfaces
{
    public interface ICityService
    {
        Task<IEnumerable<City>> GetAllCitiesAsync();
        Task<City?> GetCityByIdAsync(int cityId);
        Task<int> GetCityIdByNameAsync(string cityName);
        Task<string> GetCityNameByIdAsync(int cityId);
        Task<List<City>> GetCitiesByCountryIdAsync(int countryId);
        Task<int> CreateCityAsync(string cityName, int countryId);
        Task<bool> DeleteCityAsync(int cityId);
    }
}
