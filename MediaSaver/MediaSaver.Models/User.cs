using MediaSaver.Models._core;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaSaver.Models
{
    public class User : IEntity
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime DateOfCreation { get; set; }

        public bool IsVisible { get; set; }

        public bool IsAdmin { get; set; }

        // Foreign key constraint
        public ICollection<Album> Album { get; set; }
    }
}
