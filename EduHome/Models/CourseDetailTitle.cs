using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class CourseDetailTitle : BaseEntity
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public Nullable<int> DetailTitleId { get; set; }
        public DetailTitle DetailTitle { get; set; }

        [StringLength(855)]
        public string Description { get; set; }

    }
}
