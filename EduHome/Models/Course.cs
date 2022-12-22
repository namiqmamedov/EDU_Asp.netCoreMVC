using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [StringLength(1000)]
        public string TitleDesc { get; set; }
        [StringLength(1000)]
        [Display(Name ="About Description")]
        public string AboutDesc { get; set; }
        [StringLength(1000)]
        [Display(Name = "Apply Description")]
        public string ApplyDesc { get; set; }
        [StringLength(1000)]
        [Display(Name = "Last Description")]
        public string LastDesc { get; set; }
        [StringLength(1000)]
        [Display(Name = "Certification Description")]
        public string CertificationDesc { get; set; }
        [StringLength(255)]
        public DateTime? CourseStarts { get; set; }
        [StringLength(255)]
        [Display(Name = "Duration")]
        public string CourseDuration { get; set; }
        [StringLength(255)]
        [Display(Name = "Class Duration")]
        public string CourseClassDuration { get; set; }
        [StringLength(255)]
        [Display(Name = "Skill Level")]

        public string CourseSkillLevel { get; set; }
        [StringLength(255)]
        [Display(Name = "Language")]

        public string CourseLanguage { get; set; }
        [StringLength(255)]
        [Display(Name = "Student")]

        public string CourseStudents { get; set; }
        [StringLength(255)]
        [Display(Name = "Assesment")]

        public string CourseAssesments { get; set; }
        [StringLength(255)]
        [Display(Name = "FEE")]

        public string FEE { get; set; }

        public IEnumerable<CourseTag> CourseTags { get; set; }
        //public IEnumerable<CourseDetailTitle> CourseDetailTitles { get; set; }


        [StringLength(255)]
        public string FormName { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Subject { get; set; }
        [StringLength(800)]
        public string Message { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }

        [NotMapped]
        [MaxLength(5)]
        public IEnumerable<int> TagIds { get; set; }
    }
}
