using MediaSaver.Models._core;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaSaver.Models
{
    public class MediaObject : IEntity
    {
        public int ID { get; set; }

        public int AlbumID { get; set; }

        public string ObjectName { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public string Url { get; set; }

        public DateTime DateOfUpload { get; set; }

        public bool IsVisible { get; set; }

        // Foreign key constraint
        public Album Album { get; set; }
    }
}
