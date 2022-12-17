using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Teacher : BaseEntity
    {
        [StringLength(255)]
        [Required]
        public string Fullname { get; set; }
        [StringLength(255)]

        public string Rank { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Degree { get; set; }
        [StringLength(255)]
        public string Experince { get; set; }
        [StringLength(255)]
        public string Faculty { get; set; }
        [StringLength(255)]
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(55)]
        public string Number { get; set; }
        [StringLength(255)]
        public string Skype { get; set; }
        [StringLength(100)]
        public string FacebookURL { get; set; }
        [StringLength(100)]
        public string PinterestURL { get; set; }
        [StringLength(100)]
        public string TwitterURL { get; set; }
        [StringLength(100)]
        public string VimeoURL { get; set; }
        [StringLength(255)]
        public string Image { get; set; }

        [StringLength(255)]
        public string Hobby { get; set; }
        public IEnumerable<TeacherSkill> TeacherSkills { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }


    }
}
