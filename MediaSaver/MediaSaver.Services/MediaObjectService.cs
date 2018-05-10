using MediaSaver.Models;
using MediaSaver.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MediaSaver.Services
{
    public class MediaObjectService : IMediaObjectService
    {
        private readonly IMediaObjectRepo _mediaObjectRepo;

        public MediaObjectService(IMediaObjectRepo mediaObjectRepo)
        {
            this._mediaObjectRepo = mediaObjectRepo;
        }

        // Get all objects by UserID
        public async Task<IEnumerable<MediaObject>> GetAllObjectsByUserIdAsync(int id)
        {
            return await _mediaObjectRepo.GetAllObjectsByUserIdAsync(id);
        }

        // Get object by ID
        public async Task<MediaObject> GetObjectByIdAsync(int id)
        {
            return await _mediaObjectRepo.GetObjectByIdAsync(id);
        }

        // Get all objects by name
        public async Task<IEnumerable<MediaObject>> GetAllObjectsByNameAsync(string name)
        {
            return await _mediaObjectRepo.GetAllObjectsByNameAsync(name);
        }

        // Get all objects by type
        public async Task<IEnumerable<MediaObject>> GetAllObjectsByTypeAsync(string type)
        {
            return await _mediaObjectRepo.GetAllObjectsByTypeAsync(type);
        }

        // Get all objects by description
        public async Task<IEnumerable<MediaObject>> GetAllObjectsByDescriptionAsync(string description)
        {
            return await _mediaObjectRepo.GetAllObjectsByDescriptionAsync(description);
        }

        // Post object
        public async Task<MediaObject> PostObjectAsync(MediaObject mediaObject)
        {
            return await _mediaObjectRepo.PostObjectAsync(mediaObject);
        }

        // Update object
        public async Task<MediaObject> UpdateObjectAsync(MediaObject mediaObject)
        {
            return await _mediaObjectRepo.UpdateObjectAsync(mediaObject);
        }
    }
}
