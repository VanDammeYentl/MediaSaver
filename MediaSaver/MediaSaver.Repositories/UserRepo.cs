using MediaSaver.Models;
using MediaSaver.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSaver.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly MediaSaverDBContext _mediaSaverDBContext;

        public UserRepo(MediaSaverDBContext mediaSaverDBContext)
        {
            this._mediaSaverDBContext = mediaSaverDBContext;
        }

        // Get all users
        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _mediaSaverDBContext.Users
                                             .OrderBy(u => u.LastName)
                                             .OrderBy(u => u.FirstName)
                                             .ToListAsync();
        }

        // Get user by ID
        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _mediaSaverDBContext.Users
                                             .Where(u => u.ID == id)
                                             .SingleAsync();
        }

        // Get users by first name
        public async Task<IEnumerable<User>> GetUsersByFirstNameAsync(string firstName)
        {
            return await _mediaSaverDBContext.Users
                                             .Where(u => u.FirstName == firstName)
                                             .ToListAsync();
        }

        // Get users by last name
        public async Task<IEnumerable<User>> GetUsersByLastNameAsync(string lastName)
        {
            return await _mediaSaverDBContext.Users
                                             .Where(u => u.LastName == lastName)
                                             .ToListAsync();
        }

        // Get user by email
        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _mediaSaverDBContext.Users
                                             .Where(u => u.Email == email)
                                             .SingleAsync();
        }

        // Get users by date
        public async Task<IEnumerable<User>> GetUserByDateAsync(DateTime date)
        {
            return await _mediaSaverDBContext.Users
                                             .Where(u => u.DateOfCreation == date)
                                             .ToListAsync();
        }

        // Get users between two dates
        public async Task<IEnumerable<User>> GetUsersBetweenDatesAsync(DateTime startDate, DateTime endDate)
        {
            return await _mediaSaverDBContext.Users
                                             .Where(u => u.DateOfCreation < endDate && u.DateOfCreation > startDate)
                                             .ToListAsync();
        }

        // Get number of users by date
        public async Task<int> GetNumberOfUsersByDateAsync(DateTime date)
        {
            return await _mediaSaverDBContext.Users
                                             .CountAsync(u => u.DateOfCreation == date);
        }

        // Get number of users between two dates
        public async Task<int> GetNumberOfUsersBetweenDatesAsync(DateTime startDate, DateTime endDate)
        {
            return await _mediaSaverDBContext.Users
                                             .CountAsync(u => u.DateOfCreation < endDate && u.DateOfCreation > startDate);
        }

        // Get all admins
        public async Task<IEnumerable<User>> GetAllAdminsAsync()
        {
            return await _mediaSaverDBContext.Users
                                             .Where(u => u.IsAdmin == true)
                                             .OrderBy(u => u.LastName)
                                             .OrderBy(u => u.FirstName)
                                             .ToListAsync();
        }

        // Get admin by ID
        public async Task<User> GetAdminByIDAsync(int id)
        {
            return await _mediaSaverDBContext.Users
                                             .Where(u => u.IsAdmin == true && u.ID == id)
                                             .SingleAsync();
        }

        // Get admins by first name
        public async Task<IEnumerable<User>> GetAdminsByFirstNameAsync(string firstName)
        {
            return await _mediaSaverDBContext.Users
                                             .Where(u => u.FirstName == firstName)
                                             .ToListAsync();
        }

        // Get admins by last name
        public async Task<IEnumerable<User>> GetAdminsByLastNameAsync(string lastName)
        {
            return await _mediaSaverDBContext.Users
                                             .Where(u => u.LastName == lastName)
                                             .ToListAsync();
        }

        // Get admin by email
        public async Task<User> GetAdminByEmailAsync(string email)
        {
            return await _mediaSaverDBContext.Users
                                             .Where(u => u.Email == email)
                                             .SingleAsync();
        }

        // TODO: Post user
        public async Task<User> PostUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        // TODO: Update user
        public async Task<User> UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
