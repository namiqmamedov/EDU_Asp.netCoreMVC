using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Testimonial : BaseEntity
    {
        [StringLength(2500)]
        public string Img { get; set; }
        [StringLength(2500)]
        public string Content { get; set; }
        [StringLength(2500)]
        public string Fullname { get; set; }
        [StringLength(2500)]
        public string About { get; set; }
        [StringLength(2500)]
        public string BackgroundImg { get; set; }
    }
}
