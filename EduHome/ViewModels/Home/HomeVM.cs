using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels.Home
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<NoticeLeft> NoticeLefts { get; set; }
        public IEnumerable<NoticeRight> NoticeRights { get; set; }
        public IEnumerable<Choose> Chooses { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Event> Events { get; set; }
        
       
    }
}
