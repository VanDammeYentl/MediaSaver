using MediaSaver.Models;
using MediaSaver.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MediaSaver.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            this._userRepo = userRepo;
        }

        // Get all users
        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepo.GetAllUsersAsync();
        }

        // Get user by ID
        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepo.GetUserByIdAsync(id);
        }

        // Get users by first name
        public async Task<IEnumerable<User>> GetUsersByFirstNameAsync(string firstName)
        {
            return await _userRepo.GetUsersByFirstNameAsync(firstName);
        }

        // Get users by last name
        public async Task<IEnumerable<User>> GetUsersByLastNameAsync(string lastName)
        {
            return await _userRepo.GetUsersByLastNameAsync(lastName);
        }

        // Get user by email
        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _userRepo.GetUserByEmailAsync(email);
        }

        // Get users by date
        public async Task<IEnumerable<User>> GetUserByDateAsync(DateTime date)
        {
            return await _userRepo.GetUserByDateAsync(date);
        }

        // Get users between two dates
        public async Task<IEnumerable<User>> GetUsersBetweenDatesAsync(DateTime startDate, DateTime endDate)
        {
            return await _userRepo.GetUsersBetweenDatesAsync(startDate, endDate);
        }

        // Get number of users by date
        public async Task<int> GetNumberOfUsersByDateAsync(DateTime date)
        {
            return await _userRepo.GetNumberOfUsersByDateAsync(date);
        }

        // Get number of users between two dates
        public async Task<int> GetNumberOfUsersBetweenDatesAsync(DateTime startDate, DateTime endDate)
        {
            return await _userRepo.GetNumberOfUsersBetweenDatesAsync(startDate, endDate);
        }

        // Get all admins
        public async Task<IEnumerable<User>> GetAllAdminsAsync()
        {
            return await _userRepo.GetAllAdminsAsync();
        }

        // Get admin by ID
        public async Task<User> GetAdminByIDAsync(int id)
        {
            return await _userRepo.GetAdminByIDAsync(id);
        }

        // Get admins by first name
        public async Task<IEnumerable<User>> GetAdminsByFirstNameAsync(string firstName)
        {
            return await _userRepo.GetAdminsByFirstNameAsync(firstName);
        }

        // Get admins by last name
        public async Task<IEnumerable<User>> GetAdminsByLastNameAsync(string lastName)
        {
            return await _userRepo.GetAdminsByLastNameAsync(lastName);
        }

        // Get admin by email
        public async Task<User> GetAdminByEmailAsync(string email)
        {
            return await _userRepo.GetAdminByEmailAsync(email);
        }

        // Post user
        public async Task<User> PostUserAsync(User user)
        {
            return await _userRepo.PostUserAsync(user);
        }

        // Update user
        public async Task<User> UpdateUserAsync(User user)
        {
            return await _userRepo.UpdateUserAsync(user);
        }
    }
}
