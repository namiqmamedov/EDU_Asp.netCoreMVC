using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class CourseDetailTitle : BaseEntity
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int TitleId { get; set; }
        public DetailTitle DetailTitle { get; set; }

    }
}
