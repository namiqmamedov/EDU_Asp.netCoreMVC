using EduHome.DAL;
using EduHome.Models;
using EduHome.ViewModels.Blogs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            BlogVM blogVM = new BlogVM
            {
                Blogs = await _context.Blogs.Where(t => t.IsDeleted == false).ToListAsync(),
                BlogDescriptions = await _context.BlogDescriptions.Where(t => t.IsDeleted == false).ToListAsync(),
                BlogTags = await _context.BlogTags.Where(t => t.IsDeleted == false).ToListAsync(),
   

            };

            return View(blogVM);
        }

        public IActionResult BlogDetail(int? id)
        {
            BlogDetailVM blogDetailVM = new BlogDetailVM
            {
                Blog = _context.Blogs.Include(d => d.BlogDescriptions).Include(tg => tg.BlogTags).ThenInclude(tg => tg.Tag).FirstOrDefault(b => b.Id == id),
                Blogs = _context.Blogs.Where(b => !b.IsDeleted).ToList(),
                categories = _context.Categories.Where(b => !b.IsDeleted).Include(c => c.Courses).ToList()
            };

            return View(blogDetailVM);
        }
    }
}
