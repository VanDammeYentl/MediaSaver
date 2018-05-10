using MediaSaver.Models;
using MediaSaver.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MediaSaver.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepo _albumRepo;

        public AlbumService(IAlbumRepo albumRepo)
        {
            this._albumRepo = albumRepo;
        }
        
        // Get all albums by UserID
        public async Task<IEnumerable<Album>> GetAllAlbumsByUserIdAsync(int id)
        {
            return await _albumRepo.GetAllAlbumsByUserIdAsync(id);
        }

        // Get all albums by name
        public async Task<IEnumerable<Album>> GetAllAlbumsByNameAsync(string name)
        {
            return await _albumRepo.GetAllAlbumsByNameAsync(name);
        }

        // Post an album
        public async Task<Album> PostAlbumAsync(Album album)
        {
            return await _albumRepo.PostAlbumAsync(album);
        }

        // Update album   => To 'delete' (make isVisible = false) or to change the name of the album
        public async Task<Album> PutAlbumAsync(Album album)
        {
            return await _albumRepo.PutAlbumAsync(album);
        }
    }
}
