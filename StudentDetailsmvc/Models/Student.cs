using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentDetailsmvc.Models
{
    public class Student
    {
        public int StudentRollNo { get; set; }
        public string StudentName { get; set; }
        public string StudentCity { get; set; }
        public string StudentState { get; set; }
        public string StudenrCountry { get; set; }
    }
}