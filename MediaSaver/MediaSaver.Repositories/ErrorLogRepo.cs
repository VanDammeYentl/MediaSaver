using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaSaver.Models;
using MediaSaver.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace MediaSaver.Repositories
{
    public class ErrorLogRepo : IErrorLogRepo
    {
        private readonly MediaSaverDBContext _mediaSaverDBContext;

        public ErrorLogRepo(MediaSaverDBContext mediaSaverDBContext)
        {
            this._mediaSaverDBContext = mediaSaverDBContext;
        }

        // Get all the errors
        public async Task<IEnumerable<ErrorLog>> GetAllErrorsAsync()
        {
            return await _mediaSaverDBContext.ErrorLogs
                                             .OrderBy(e => e.DateOfError)
                                             .ToListAsync();
        }

        // Get error by ID
        public async Task<ErrorLog> GetErrorByIdAsync(int id)
        {
            return await _mediaSaverDBContext.ErrorLogs
                                             .Where(e => e.ID == id)
                                             .SingleAsync();
        }

        // Get all errors by UserID
        public async Task<IEnumerable<ErrorLog>> GetAllErrorsByUserIdAsync(int id)
        {
            return await _mediaSaverDBContext.ErrorLogs
                                             .Where(e => e.UserID == id)
                                             .ToListAsync();
        }

        // Get all errors by date
        public async Task<IEnumerable<ErrorLog>> GetAllErrorsByDate(DateTime date)
        {
            return await _mediaSaverDBContext.ErrorLogs
                                             .Where(e => e.DateOfError == date)
                                             .ToListAsync();
        }

        // Get all errors between two dates
        public async Task<IEnumerable<ErrorLog>> GetAllErrorsBetweenDatesAsync(DateTime beginDate, DateTime endDate)
        {
            return await _mediaSaverDBContext.ErrorLogs
                                             .Where(e => e.DateOfError < endDate && e.DateOfError > beginDate)
                                             .ToListAsync();
        }

        // TODO: Post an error
        public async Task<ErrorLog> PostErrorAsync(ErrorLog errorLog)
        {
            throw new NotImplementedException();
        }
    }
}
