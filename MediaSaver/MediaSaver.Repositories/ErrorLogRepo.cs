using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MediaSaver.Models;

namespace MediaSaver.Repositories
{
    public class ErrorLogRepo : IErrorLogRepo
    {
        // Get all the errors
        public async Task<IEnumerable<ErrorLog>> GetAllErrorsAsync()
        {
            throw new NotImplementedException();
        }

        // Get error by ID
        public async Task<ErrorLog> GetErrorByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        // Get all errors by UserID
        public async Task<IEnumerable<ErrorLog>> GetAllErrorsByUserIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        // Get all errors by date
        public async Task<IEnumerable<ErrorLog>> GetAllErrorsByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        // Get all errors between two dates
        public async Task<IEnumerable<ErrorLog>> GetAllErrorsBetweenDatesAsync(DateTime beginDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        // Post an error
        public async Task<ErrorLog> PostErrorAsync(ErrorLog errorLog)
        {
            throw new NotImplementedException();
        }
    }
}
