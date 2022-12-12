using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class AboutContent : BaseEntity
    {
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string MainDescription { get; set; }
        [StringLength(255)]
        public string SubDescription { get; set; }
        [StringLength(255)]
        public string CourseLink { get; set; }
        [StringLength(255)]
        public string Image { get; set; }

    }
}
