using MediaSaver.Models._core;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaSaver.Models
{
    public class ErrorLog : IEntity
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        public string Description { get; set; }

        public DateTime DateOfError { get; set; }
    }
}
