using MediaSaver.Models;
using MediaSaver.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSaver.Repositories
{
    public class MediaObjectRepo : IMediaObjectRepo
    {
        private readonly MediaSaverDBContext _mediaSaverDBContext;

        public MediaObjectRepo(MediaSaverDBContext mediaSaverDBContext)
        {
            this._mediaSaverDBContext = mediaSaverDBContext;
        }

        // TODO: Get all objects by UserID
        public async Task<IEnumerable<MediaObject>> GetAllObjectsByUserIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        // Get object by ID
        public async Task<MediaObject> GetObjectByIdAsync(int id)
        {
            return await _mediaSaverDBContext.MediaObjects
                                             .Where(e => e.ID == id)
                                             .SingleAsync();
        }

        // Get all objects by name
        public async Task<IEnumerable<MediaObject>> GetAllObjectsByNameAsync(string name)
        {
            return await _mediaSaverDBContext.MediaObjects
                                             .Where(e => e.ObjectName == name)
                                             .ToListAsync();
        }

        // Get all objects by type
        public async Task<IEnumerable<MediaObject>> GetAllObjectsByTypeAsync(string type)
        {
            return await _mediaSaverDBContext.MediaObjects
                                             .Where(e => e.Type == type)
                                             .ToListAsync();
        }

        // Get all objects by description
        public async Task<IEnumerable<MediaObject>> GetAllObjectsByDescriptionAsync(string description)
        {
            return await _mediaSaverDBContext.MediaObjects
                                             .Where(e => e.Description == description)
                                             .ToListAsync();
        }

        // TODO: Post object
        public async Task<MediaObject> PostObjectAsync(MediaObject mediaObject)
        {
            throw new NotImplementedException();
        }

        // TODO: Update object
        public async Task<MediaObject> UpdateObjectAsync(MediaObject mediaObject)
        {
            throw new NotImplementedException();
        }
    }
}
