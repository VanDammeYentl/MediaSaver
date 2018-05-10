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
    public class AlbumRepo : IAlbumRepo
    {
        private readonly MediaSaverDBContext _mediaSaverDBContext;

        public AlbumRepo(MediaSaverDBContext mediaSaverDBContext)
        {
            this._mediaSaverDBContext = mediaSaverDBContext;
        }

        // Get all albums by UserID
        public async Task<IEnumerable<Album>> GetAllAlbumsByUserIdAsync(int id)
        {
            return await _mediaSaverDBContext.Albums
                                             .Where(a => a.UserID == id)
                                             .ToListAsync();
        }

        // Get all albums by name
        public async Task<IEnumerable<Album>> GetAllAlbumsByNameAsync(string name)
        {
            return await _mediaSaverDBContext.Albums
                                             .Where(a => a.AlbumName == name)
                                             .ToListAsync();
        }

        // TODO: Post an album
        public async Task<Album> PostAlbumAsync(Album album)
        {
            throw new NotImplementedException();
        }

        // TODO: Update album   => To 'delete' (make isVisible = false) or to change the name of the album
        public async Task<Album> PutAlbumAsync(Album album)
        {
            throw new NotImplementedException();
        }
    }
}
