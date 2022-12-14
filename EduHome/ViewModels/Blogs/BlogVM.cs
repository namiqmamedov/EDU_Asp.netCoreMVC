using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels.Blogs
{
    public class BlogVM
    {
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<BlogCategory> BlogCategories { get; set; }
        public IEnumerable<BlogDescription> BlogDescriptions { get; set; }
        public IEnumerable<BlogTag> BlogTags { get; set; }

    }
}
