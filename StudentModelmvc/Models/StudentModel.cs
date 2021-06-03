using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentModelmvc.Models
{
    public class StudentModel
    {
        public int StudentRollNo { get; set; }
        public string StudentName { get; set; }
        public string StudentCity { get; set; }
        public string StudentState { get; set; }
        public string StudentCountry { get; set; }
    }
}