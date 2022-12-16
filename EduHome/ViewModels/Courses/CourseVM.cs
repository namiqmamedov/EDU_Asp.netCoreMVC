using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels.Courses
{
    public class CourseVM
    {
        public IEnumerable<Course> Courses { get; set; }
        //public IEnumerable<CourseCategory> CourseCategories { get; set; }
        public IEnumerable<CourseTag> CourseTags { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
    }
}
