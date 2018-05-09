using MediaSaver.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MediaSaver.Services
{
    public interface IErrorLogService
    {
        // Get all the errors
        Task<IEnumerable<ErrorLog>> GetAllErrorsAsync();

        // Get error by ID
        Task<ErrorLog> GetErrorByIdAsync(int id);

        // Get all errors by UserID
        Task<IEnumerable<ErrorLog>> GetAllErrorsByUserIdAsync(int id);

        // Get all errors by date
        Task<IEnumerable<ErrorLog>> GetAllErrorsByDate(DateTime date);

        // Get all errors between two dates
        Task<IEnumerable<ErrorLog>> GetAllErrorsBetweenDatesAsync(DateTime beginDate, DateTime endDate);

        // Post an error
        Task<ErrorLog> PostErrorAsync(ErrorLog errorLog);
    }
}
