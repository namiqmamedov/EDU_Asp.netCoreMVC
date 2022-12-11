using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Choose : BaseEntity
    {
        public string Title { get; set; }
        public string MainDescription { get; set; }
        public string SubDescription { get; set; }
        public string CourseDetail { get; set; }
        public string BackgroundImg { get; set; }


    }
}
