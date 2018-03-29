using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForeingKeyTest.Models
{
    public class Faculty
    {
        public int FacultyID { set; get; }
        public int Name { get; set; }
        public ICollection<Tribune> Tribunes { set; get; }
        public Faculty()
        {
            Tribunes = new List<Tribune>();
        }
    }
}