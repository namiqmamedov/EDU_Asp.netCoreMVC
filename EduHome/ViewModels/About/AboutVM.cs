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
    }
}
