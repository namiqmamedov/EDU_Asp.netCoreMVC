using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels.Course
{
    public class CourseVM
    {
        public IEnumerable<CourseCategory> CourseCategories { get; set; }
        public IEnumerable<CourseTag> CourseTags { get; set; }
        public IEnumerable<CourseDetailTitle> CourseDetailTitles { get; set; }
    }
}
