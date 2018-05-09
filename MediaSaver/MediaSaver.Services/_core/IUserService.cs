using MediaSaver.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MediaSaver.Services
{
    public interface IUserService
    {
        // Get all users
        Task<IEnumerable<User>> GetAllUsersAsync();

        // Get user by ID
        Task<User> GetUserByIdAsync(int id);

        // Get users by first name
        Task<IEnumerable<User>> GetUsersByFirstNameAsync(string firstName);

        // Get users by last name
        Task<IEnumerable<User>> GetUsersByLastNameAsync(string lastName);

        // Get user by email
        Task<User> GetUserByEmailAsync(string email);

        // Get users by date
        Task<IEnumerable<User>> GetUserByDateAsync(DateTime date);

        // Get users between two dates
        Task<IEnumerable<User>> GetUsersBetweenDatesAsync(DateTime startDate, DateTime endDate);

        // Get number of users by date
        Task<int> GetNumberOfUsersByDateAsync(DateTime date);

        // Get number of users between two dates
        Task<int> GetNumberOfUsersBetweenDatesAsync(DateTime startDate, DateTime endDate);

        // Get all admins
        Task<IEnumerable<User>> GetAllAdminsAsync();

        // Get admin by ID
        Task<User> GetAdminByIDAsync(int id);

        // Get admins by first name
        Task<IEnumerable<User>> GetAdminsByFirstNameAsync(string firstName);

        // Get admins by last name
        Task<IEnumerable<User>> GetAdminsByLastNameAsync(string lastName);

        // Get admin by email
        Task<User> GetAdminByEmailAsync(string email);

        // Post user
        Task<User> PostUserAsync(User user);

        // Update user
        Task<User> UpdateUserAsync(User user);
    }
}
