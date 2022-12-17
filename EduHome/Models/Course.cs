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

        [StringLength(1000)]
        public string Description { get; set; }

        [StringLength(1000)]
        public string TitleDesc { get; set; }
        [StringLength(1000)]
        public string AboutDesc { get; set; }
        [StringLength(1000)]
        public string ApplyDesc { get; set; }
        [StringLength(1000)]
        public string LastDesc { get; set; }
        [StringLength(1000)]
        public string CertificationDesc { get; set; }
        [StringLength(255)]
        public DateTime CourseStarts { get; set; }
        [StringLength(255)]
        public string CourseDuration { get; set; }
        [StringLength(255)]
        public string CourseClassDuration { get; set; }
        [StringLength(255)]
        public string CourseSkillLevel { get; set; }
        [StringLength(255)]
        public string CourseLanguage { get; set; }
        [StringLength(255)]
        public string CourseStudents { get; set; }
        [StringLength(255)]
        public string CourseAssesments { get; set; }
        [StringLength(255)]
        public string FEE { get; set; }

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
