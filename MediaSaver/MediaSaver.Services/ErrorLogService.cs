using MediaSaver.Models;
using MediaSaver.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MediaSaver.Services
{
    public class ErrorLogService : IErrorLogService
    {
        private readonly IErrorLogRepo _errorLogRepo;

        public ErrorLogService(IErrorLogRepo errorLogRepo)
        {
            this._errorLogRepo = errorLogRepo;
        }

        // Get all the errors
        public async Task<IEnumerable<ErrorLog>> GetAllErrorsAsync()
        {
            return await _errorLogRepo.GetAllErrorsAsync();
        }

        // Get error by ID
        public async Task<ErrorLog> GetErrorByIdAsync(int id)
        {
            return await _errorLogRepo.GetErrorByIdAsync(id);
        }

        // Get all errors by UserID
        public async Task<IEnumerable<ErrorLog>> GetAllErrorsByUserIdAsync(int id)
        {
            return await _errorLogRepo.GetAllErrorsByUserIdAsync(id);
        }

        // Get all errors by date
        public async Task<IEnumerable<ErrorLog>> GetAllErrorsByDate(DateTime date)
        {
            return await _errorLogRepo.GetAllErrorsByDate(date);
        }

        // Get all errors between two dates
        public async Task<IEnumerable<ErrorLog>> GetAllErrorsBetweenDatesAsync(DateTime beginDate, DateTime endDate)
        {
            return await _errorLogRepo.GetAllErrorsBetweenDatesAsync(beginDate, endDate);
        }

        // Post an error
        public async Task<ErrorLog> PostErrorAsync(ErrorLog errorLog)
        {
            return await _errorLogRepo.PostErrorAsync(errorLog);
        }
    }
}
