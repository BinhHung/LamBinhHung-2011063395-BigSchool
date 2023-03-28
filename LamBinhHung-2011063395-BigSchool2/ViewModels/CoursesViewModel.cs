using LamBinhHung_2011063395_BigSchool2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LamBinhHung_2011063395_BigSchool2.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}