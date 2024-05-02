// IRentalAgreementService.cs

using System.Collections.Generic;
using System.Threading.Tasks;
using BikeRental.DAL.Models;

namespace BikeRental.BLL.Interfaces
{
    public interface IRentalAgreementService
    {
        Task<IEnumerable<RentalAgreement>> GetAllRentalAgreementsAsync();
        Task<RentalAgreement?> GetRentalAgreementByIdAsync(int rentalAgreementId);
        Task<List<RentalAgreement>> GetRentalAgreementsByRenterIdAsync(int userId);
        Task<int> GetRentalAgreementIdByBikeIdAndDatesAsync(int bikeId, DateTime startDate, DateTime endDate);
        Task<List<RentalAgreement>> GetActiveRentalAgreementsByRenterIdAsync(int userId);
        Task<int> CreateRentalAgreementAsync(int bikeId, int renterId, DateTime startDate, DateTime endDate);
        Task<bool> DeleteRentalAgreementAsync(int rentalAgreementId);
    }
}
