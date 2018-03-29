using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForeingKeyTest.Models
{
    public class Tribune
    {
        public int TribuneID { set; get; }
        public string Name { set; get; }
        public int FacultyID { set; get; }
        public Faculty Faculty { set; get; }
    }
}