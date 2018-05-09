using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MediaSaver.Models;

namespace MediaSaver.Repositories
{
    public class AlbumRepo : IAlbumRepo
    {
        // Get all albums by UserID
        public async Task<IEnumerable<Album>> GetAllAlbumsByUserIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        // Get all albums by name
        public async Task<IEnumerable<Album>> GetAllAlbumsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        // Post an album
        public async Task<Album> PostAlbumAsync(Album album)
        {
            throw new NotImplementedException();
        }

        // Update album   => To 'delete' (make isVisible = false) or to change the name of the album
        public async Task<Album> PutAlbumAsync(Album album)
        {
            throw new NotImplementedException();
        }
    }
}
