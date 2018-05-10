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
    [Route("api/MediaObject")]
    public class MediaObjectController : Controller
    {
        private readonly IMediaObjectService _mediaObjectService;

        public MediaObjectController(IMediaObjectService mediaObjectService)
        {
            this._mediaObjectService = mediaObjectService;
        }
    }
}