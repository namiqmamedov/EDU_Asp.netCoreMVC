using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels.Courses
{
    public class CourseDetailVM
    {
        public Course Course { get; set; }
        public List<Course> Courses { get; set; }
        public Blog Blog { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Category> categories { get; set; }
    }
}
