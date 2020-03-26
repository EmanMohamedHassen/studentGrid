using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainWep.Domains.StudentDomain.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public double Age { get; set; }
        public string collage  { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }
    }
}