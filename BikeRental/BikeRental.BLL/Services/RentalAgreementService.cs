using System.Collections.Generic;
using System.Threading.Tasks;
using BikeRental.BLL.Interfaces;
using BikeRental.DAL;
using BikeRental.DAL.Data;
using BikeRental.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace BikeRental.BLL.Services
{
    public class RentalAgreementService : IRentalAgreementService
    {
        private readonly BikeRentalContext _context;

        public RentalAgreementService()
        {
            _context = DBContext.GetContext();
        }

        public async Task<IEnumerable<RentalAgreement>> GetAllRentalAgreementsAsync()
        {
            return await _context.RentalAgreements.ToListAsync();
        }

        public async Task<RentalAgreement?> GetRentalAgreementByIdAsync(int rentalAgreementId)
        {
            return await _context.RentalAgreements.FindAsync(rentalAgreementId);
        }
        public async Task<List<RentalAgreement>> GetRentalAgreementsByRenterIdAsync(int userId)
        {
            return await _context.RentalAgreements
                .Where(ra => ra.RenterId == userId)
                .ToListAsync();
        }
        public async Task<int> GetRentalAgreementIdByBikeIdAndDatesAsync(int bikeId, DateTime startDate, DateTime endDate)
        {
            try
            {
                var rentalAgreement = await _context.RentalAgreements
                    .FirstOrDefaultAsync(ra =>
                        ra.BikeId == bikeId &&
                        ra.StartDate == startDate &&
                        ra.EndDate == endDate);

                return rentalAgreement?.Id ?? -1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public async Task<List<RentalAgreement>> GetActiveRentalAgreementsByRenterIdAsync(int userId)
        {
            return await _context.RentalAgreements
                .Where(ra => ra.RenterId == userId)
                .Where(ra => ra.EndDate > DateTime.Now)
                .ToListAsync();
        }
        public async Task<int> CreateRentalAgreementAsync(int bikeId, int renterId, DateTime startDate, DateTime endDate)
        {
            var rentals = await GetAllRentalAgreementsAsync();

            if (!rentals.Where(ra => ra.EndDate > startDate && ra.BikeId == bikeId).IsNullOrEmpty())
                return -1;
            var newRentalAgreement = new RentalAgreement
            {
                BikeId = bikeId,
                RenterId = renterId,
                StartDate = startDate,
                EndDate = endDate
            };

            await _context.RentalAgreements.AddAsync(newRentalAgreement);
            if (await _context.SaveChangesAsync() != 1)
                return -1;

            return newRentalAgreement.Id;
        }

        public async Task<bool> DeleteRentalAgreementAsync(int rentalAgreementId)
        {
            var rentalAgreementToDelete = await _context.RentalAgreements.FindAsync(rentalAgreementId);

            if (rentalAgreementToDelete != null)
            {
                _context.RentalAgreements.Remove(rentalAgreementToDelete);
                await _context.SaveChangesAsync();
                return true; // Rental agreement successfully deleted
            }

            return false; // Rental agreement not found
        }
    }
}
