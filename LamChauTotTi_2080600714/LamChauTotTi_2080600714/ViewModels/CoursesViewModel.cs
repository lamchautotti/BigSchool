using LamChauTotTi_2080600714.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LamChauTotTi_2080600714.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}