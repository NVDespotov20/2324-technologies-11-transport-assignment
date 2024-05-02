using System.Collections.Generic;
using System.Threading.Tasks;
using BikeRental.BLL.Interfaces;
using BikeRental.DAL;
using BikeRental.DAL.Data;
using BikeRental.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeRental.BLL.Services
{
    public class BikeService : IBikeService
    {
        private readonly BikeRentalContext _context;

        public BikeService()
        {
            _context = DBContext.GetContext();
        }

        public async Task<IEnumerable<Bike>> GetAllBikesAsync()
        {
            return await _context.Bikes.ToListAsync();
        }

        public async Task<Bike?> GetBikeByIdAsync(int bikeId)
        {
            return await _context.Bikes.FindAsync(bikeId);
        }
        public async Task<List<Bike>> GetBikesByOwnerIdAsync(int ownerId)
        {
            return await _context.Bikes
                .Where(bike => bike.OwnerId == ownerId)
                .ToListAsync();
        }
        public async Task<List<Bike>> GetBikesByCityIdAsync(int cityId)
        {
            return await _context.Bikes
                .Where(bike => bike.CityId == cityId)
                .ToListAsync();
        }
        public async Task<List<Bike>> GetBikesByCityIdExceptOwnedAsync(int cityId)
        {
            return await _context.Bikes
                .Where(bike => bike.CityId == cityId && bike.OwnerId != UserService.CurrentUser!.Id)
                .ToListAsync();
        }
        public async Task<int> CreateBikeAsync(int cityId, int ownerId)
        {
            var newBike = new Bike
            {
                CityId = cityId,
                OwnerId = ownerId
            };

            await _context.Bikes.AddAsync(newBike);
            if(await _context.SaveChangesAsync() > 0)
                return newBike.Id;

            return -1;
        }

        public async Task<bool> DeleteBikeAsync(int bikeId)
        {
            var bikeToDelete = await _context.Bikes.FindAsync(bikeId);

            if (bikeToDelete != null)
            {
                _context.Bikes.Remove(bikeToDelete);
                await _context.SaveChangesAsync();
                return true; // Bike successfully deleted
            }

            return false; // Bike not found
        }
    }
}
