using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaSaver.Models.Data
{
    public class MediaSaverDBContext : DbContext
    {
        public MediaSaverDBContext(DbContextOptions options) : base(options)
        {
        }

        // Linking all the models to the tables from the database
        public DbSet<User> Users { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<MediaObject> MediaObjects { get; set; }

        public DbSet<ErrorLog> ErrorLogs { get; set; }
    }
}
