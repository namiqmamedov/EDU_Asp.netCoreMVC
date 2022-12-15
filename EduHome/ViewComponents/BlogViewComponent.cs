using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class BlogViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(IEnumerable<Blog> blogs)
        {
            return View(await Task.FromResult(blogs));
        }
    }
}
