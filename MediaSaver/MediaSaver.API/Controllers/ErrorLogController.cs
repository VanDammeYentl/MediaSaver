using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaSaver.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediaSaver.API.Controllers
{
    [Produces("application/json")]
    [Route("api/ErrorLog")]
    public class ErrorLogController : Controller
    {
        private readonly IErrorLogService _errorLogService;

        public ErrorLogController(IErrorLogService errorLogService)
        {
            this._errorLogService = errorLogService;
        }
    }
}