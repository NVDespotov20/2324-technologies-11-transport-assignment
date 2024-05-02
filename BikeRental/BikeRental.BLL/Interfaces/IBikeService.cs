using System.Collections.Generic;
using System.Threading.Tasks;
using BikeRental.DAL.Models;

namespace BikeRental.BLL.Interfaces
{
    public interface IBikeService
    {
        Task<IEnumerable<Bike>> GetAllBikesAsync();
        Task<Bike?> GetBikeByIdAsync(int bikeId);
        Task<List<Bike>> GetBikesByOwnerIdAsync(int ownerId);
        Task<List<Bike>> GetBikesByCityIdAsync(int cityId);
        Task<List<Bike>> GetBikesByCityIdExceptOwnedAsync(int cityId);
        Task<int> CreateBikeAsync(int cityId, int ownerId);
        Task<bool> DeleteBikeAsync(int bikeId);
    }
}
