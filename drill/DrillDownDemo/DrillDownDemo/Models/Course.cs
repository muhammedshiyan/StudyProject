using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrillDownDemo.Models
{
    public class Course
    {
        public String CourseName { get; set; }
        public String SemesterName { get; set; }
        public int ID { get; internal set; }
    }
}