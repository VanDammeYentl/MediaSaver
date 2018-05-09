using MediaSaver.Models._core;
using System;
using System.Collections.Generic;

namespace MediaSaver.Models
{
    public class Album : IEntity
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public string AlbumName { get; set; }

        public DateTime DateOfCreation { get; set; }

        public bool IsVisible { get; set; }

        // Foreign Key constraint
        public User User { get; set; }

        public ICollection<MediaObject> MediaObject { get; set; }
    }
}
