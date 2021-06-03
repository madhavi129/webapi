using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StdentsBreakOutAssignMVC.Models
{
    public class Student
    {
        public int Roll_Number { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}