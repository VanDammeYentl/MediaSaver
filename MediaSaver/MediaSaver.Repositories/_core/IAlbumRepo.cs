using MediaSaver.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MediaSaver.Repositories
{
    public interface IAlbumRepo
    {
        // Get all albums by UserID
        Task<IEnumerable<Album>> GetAllAlbumsByUserIdAsync(int id);

        // Get all albums by name
        Task<IEnumerable<Album>> GetAllAlbumsByNameAsync(string name);

        // Post an album
        Task<Album> PostAlbumAsync(Album album);

        // Update album   => To 'delete' (make isVisible = false) or to change the name of the album
        Task<Album> PutAlbumAsync(Album album);
    }
}
