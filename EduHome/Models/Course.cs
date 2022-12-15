using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Course : BaseEntity
    {
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<CourseTag> CourseTags { get; set; }
        public IEnumerable<CourseDetailTitle> CourseDetailTitles { get; set; }

        [StringLength(255)]
        public string FormName { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Subject { get; set; }
        [StringLength(800)]
        public string Message { get; set; }
    }
}
