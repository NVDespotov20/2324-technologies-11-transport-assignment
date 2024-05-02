using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BikeRental.BLL.Interfaces;
using BikeRental.DAL.Data;
using BikeRental.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeRental.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly BikeRentalContext _context;
        public static User? CurrentUser { get; set; }
        public UserService()
        {
             _context = DBContext.GetContext();
        }
        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }
        public string GetUsernameById(int userId)
        {
            var user = _context.Users.Find(userId);
            return user!.Username ?? "Unknown";
        }
        public async Task<int> GetUserIdByUserNameAsync(string username)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
            return user!.Id;
        }
        public string GetUsernameByBikeId(int bikeId)
        {
            try
            {
                return _context.Users
                    .FirstOrDefault(u => u.BikesOwned.FirstOrDefault(b => b.Id == bikeId) != null)!.Username;
            }
            catch (Exception ex)
            {
                return "Unknown";
            }
        }
        public async Task<User?> GetUserByIdAsync(int userId)
        {
            return await _context.Users.FindAsync(userId);
        }
        public async Task<User?> GetUserByUsernameAsync(string username)
        {
            User? user = await _context.Users.SingleOrDefaultAsync(u => u.Username == username);

            return user;
        }
        public async Task<int> CreateUserAsync(string username, string password)
        {
            if (username == "" || password == "") return -1;
            if(await GetUserByUsernameAsync(username) != null) return -1;
            // Hash the password before saving it to the database
            string hashedPassword = HashPassword(password);

            var newUser = new User
            {
                Username = username,
                PasswordHash = hashedPassword
            };

            _context.Users.Add(newUser);
            try
            {
                if (await _context.SaveChangesAsync() != 1)
                    return -1;
            }
            catch(Exception ex) { }
            return newUser.Id;
        }
        public async Task<bool> DeleteUserAsync(int userId)
        {
            var userToDelete = await _context.Users.FindAsync(userId);

            if (userToDelete != null)
            {
                _context.Users.Remove(userToDelete);
                await _context.SaveChangesAsync();
                return true; // User successfully deleted
            }

            return false; // User not found
        }
        public async Task<bool> ValidateUserCredentialsAsync(string username, string password)
        {
            // Retrieve the user by username
            var user = await GetUserByUsernameAsync(username);

            if (user == null)
                return false;
            // Validate the provided password against the stored hash
            if (VerifyPasswordHash(password, user.PasswordHash))
            {
                CurrentUser = user;
                return true;
            }
            return false;

        }

        // Password hashing and verification methods
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        private bool VerifyPasswordHash(string password, string storedHash)
        {
            string hashedPassword = HashPassword(password);
            return hashedPassword == storedHash;
        }
    }
}
