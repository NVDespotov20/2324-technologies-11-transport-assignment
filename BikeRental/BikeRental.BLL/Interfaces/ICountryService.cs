using System.Collections.Generic;
using System.Threading.Tasks;
using BikeRental.DAL.Models;

namespace BikeRental.BLL.Interfaces
{
    public interface ICountryService
    {
        Task<List<Country>> GetAllCountriesAsync();
        Task<Country?> GetCountryByIdAsync(int countryId);
        Task<string> GetCountryNameByIdAsync(int countryId);
        string GetCountryNameByCityId(int cityId);
        Task<int> CreateCountryAsync(string countryName);
        Task<bool> DeleteCountryAsync(int countryId);
    }
}
