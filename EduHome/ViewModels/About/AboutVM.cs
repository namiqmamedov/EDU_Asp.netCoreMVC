using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels.About
{
    public class AboutVM
    {
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<AboutContent> AboutContents { get; set; }
        public IEnumerable<AboutNotice> AboutNotices { get; set; }
        public IEnumerable<AboutVideo> AboutVideos { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
    }
}
