using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Manage.Controllers
{
    [Area("manage")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Blog> blogs = await _context.Blogs
                //.Include(b => b.Category)
                .Include(bd=>bd.BlogDescriptions)
                .Include(bt => bt.BlogTags).ThenInclude(bt => bt.Tag)
                .Where(b => b.IsDeleted == false)
                .ToListAsync();

            return View(blogs);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.BlogTags = await _context.BlogTags.Where(b => b.IsDeleted == false).ToListAsync();
            ViewBag.BlogDescriptions = await _context.BlogDescriptions.Where(bd => bd.IsDeleted == false).ToListAsync();
            //ViewBag.Categories = await _context.Categories.Where(bd => bd.IsDeleted == false).ToListAsync();

            return View();
        }
    }
}
