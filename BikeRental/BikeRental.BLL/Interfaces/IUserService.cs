using BikeRental.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.BLL.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User?> GetUserByIdAsync(int userId);
        string GetUsernameById(int userId);
        Task<User?> GetUserByUsernameAsync(string username);
        Task<int> CreateUserAsync(string username, string password);
        Task<bool> DeleteUserAsync(int userId);
        Task<bool> ValidateUserCredentialsAsync(string username, string password);
    }
}
