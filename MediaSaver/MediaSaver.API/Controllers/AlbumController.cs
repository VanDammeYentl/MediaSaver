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
    [Route("api/Album")]
    public class AlbumController : Controller
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            this._albumService = albumService;
        }
    }
}