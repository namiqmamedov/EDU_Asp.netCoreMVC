﻿using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels.Blogs
{
    public class BlogDetailVM
    {
        public Blog Blog { get; set; }
        public List<Blog> Blogs { get; set; }

        public List<Category> categories { get; set; }
    }
}
