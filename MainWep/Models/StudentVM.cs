using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainWep.Models
{
    public class StudentVM
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string collage { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }
    }
}