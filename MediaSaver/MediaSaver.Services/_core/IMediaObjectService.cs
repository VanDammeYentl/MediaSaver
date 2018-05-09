using MediaSaver.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MediaSaver.Services
{
    public interface IMediaObjectService
    {
        // Get all objects by UserID
        Task<IEnumerable<MediaObject>> GetAllObjectsByUserIdAsync(int id);

        // Get object by ID
        Task<MediaObject> GetObjectByIdAsync(int id);

        // Get all objects by name
        Task<IEnumerable<MediaObject>> GetAllObjectsByNameAsync(string name);

        // Get all objects by type
        Task<IEnumerable<MediaObject>> GetAllObjectsByTypeAsync(string type);

        // Get all objects by description
        Task<IEnumerable<MediaObject>> GetAllObjectsByDescriptionAsync(string description);

        // Post object
        Task<MediaObject> PostObjectAsync(MediaObject mediaObject);

        // Update object
        Task<MediaObject> UpdateObjectAsync(MediaObject mediaObject);
    }
}
