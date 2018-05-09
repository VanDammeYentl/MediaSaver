using MediaSaver.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MediaSaver.Repositories
{
    public class UserRepo : IUserRepo
    {
        // Get all users
        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        // Get user by ID
        public async Task<User> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        // Get users by first name
        public async Task<IEnumerable<User>> GetUsersByFirstNameAsync(string firstName)
        {
            throw new NotImplementedException();
        }

        // Get users by last name
        public async Task<IEnumerable<User>> GetUsersByLastNameAsync(string lastName)
        {
            throw new NotImplementedException();
        }

        // Get user by email
        public async Task<User> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        // Get users by date
        public async Task<IEnumerable<User>> GetUserByDateAsync(DateTime date)
        {
            throw new NotImplementedException();
        }

        // Get users between two dates
        public async Task<IEnumerable<User>> GetUsersBetweenDatesAsync(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        // Get number of users by date
        public async Task<int> GetNumberOfUsersByDateAsync(DateTime date)
        {
            throw new NotImplementedException();
        }

        // Get number of users between two dates
        public async Task<int> GetNumberOfUsersBetweenDatesAsync(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        // Get all admins
        public async Task<IEnumerable<User>> GetAllAdminsAsync()
        {
            throw new NotImplementedException();
        }

        // Get admin by ID
        public async Task<User> GetAdminByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        // Get admins by first name
        public async Task<IEnumerable<User>> GetAdminsByFirstNameAsync(string firstName)
        {
            throw new NotImplementedException();
        }

        // Get admins by last name
        public async Task<IEnumerable<User>> GetAdminsByLastNameAsync(string lastName)
        {
            throw new NotImplementedException();
        }

        // Get admin by email
        public async Task<User> GetAdminByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        // Post user
        public async Task<User> PostUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        // Update user
        public async Task<User> UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
