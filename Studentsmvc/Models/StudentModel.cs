﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Studentsmvc.Models
{
    public class StudentModel
    {
        public int stu_rollno { get; set; }
        public string stu_name { get; set; }
        public string stu_city { get; set; }
        public string stu_state { get; set; }
        public string stu_country { get; set; }
    }
}