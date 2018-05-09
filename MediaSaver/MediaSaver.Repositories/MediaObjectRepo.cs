using MediaSaver.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MediaSaver.Repositories
{
    public class MediaObjectRepo : IMediaObjectRepo
    {
        // Get all objects by UserID
        public async Task<IEnumerable<MediaObject>> GetAllObjectsByUserIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        // Get object by ID
        public async Task<MediaObject> GetObjectByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        // Get all objects by name
        public async Task<IEnumerable<MediaObject>> GetAllObjectsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        // Get all objects by type
        public async Task<IEnumerable<MediaObject>> GetAllObjectsByTypeAsync(string type)
        {
            throw new NotImplementedException();
        }

        // Get all objects by description
        public async Task<IEnumerable<MediaObject>> GetAllObjectsByDescriptionAsync(string description)
        {
            throw new NotImplementedException();
        }

        // Post object
        public async Task<MediaObject> PostObjectAsync(MediaObject mediaObject)
        {
            throw new NotImplementedException();
        }

        // Update object
        public async Task<MediaObject> UpdateObjectAsync(MediaObject mediaObject)
        {
            throw new NotImplementedException();
        }
    }
}
