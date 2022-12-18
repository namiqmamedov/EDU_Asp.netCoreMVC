using EduHome.DAL;
using EduHome.Extension;
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
                .Include(bd => bd.BlogDescriptions)
                .Include(bt => bt.BlogTags).ThenInclude(bt => bt.Tag)
                .Include(c => c.BlogDescriptions)
                .Where(b => b.IsDeleted == false)
                .ToListAsync();

            return View(blogs);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.BlogTags = await _context.BlogTags.Where(b => b.IsDeleted == false).ToListAsync();
            ViewBag.BlogDescriptions = await _context.BlogDescriptions.Where(bd => bd.IsDeleted == false).ToListAsync();
            //ViewBag.Categories = await _context.Categories.Where(bd => bd.IsDeleted == false).ToListAsync();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Blog blogs)
        {
            ViewBag.BlogTags = await _context.BlogTags.Where(b => b.IsDeleted == false).ToListAsync();
            ViewBag.BlogDescriptions = await _context.BlogDescriptions.Where(bd => bd.IsDeleted == false).ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(blogs);
            }

            //if (!await _context.Blogs.AnyAsync(b=>b.IsDeleted == false && b.Id == CategoryId))
            //{
            //    ModelState.AddModelError("CategoryId", "Selected category is not correct.");
            //    return View(events);
            //}

            if (blogs.File == null)
            {
                ModelState.AddModelError("File", "File is required");
                return View(blogs);
            }

            if (blogs.File.ContentType != "image/jpeg")
            {
                ModelState.AddModelError("File", "File extension must be JPG or JPEG !");
                return View(blogs);
            }
            if (blogs.File.Length > 255096)
            {
                ModelState.AddModelError("File", "Maximum size is 255096 kb");
                return View(blogs);
            }

            blogs.Image = blogs.File.CreateImage(_env, "assets", "img", "blog");

            blogs.IsDeleted = false;
            blogs.Date = blogs.Date;
            blogs.CreatedAt = DateTime.Now;
            blogs.CreatedBy = "System";

            await _context.Blogs.AddAsync(blogs);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

            //List<BlogTag> blogTags = new List<BlogTag>();


            //foreach (int tagId in blog.TagIds)
            //{
            //    if (blog.TagIds.Where(t => t == tagId).Count() > 1)
            //    {
            //        ModelState.AddModelError("TagIds", "You can't use the same tag more than once !");
            //        return View(blog);
            //    }

            //    if (!await _context.Tags.AnyAsync(c => c.IsDeleted == false && c.Id == tagId))
            //    {
            //        ModelState.AddModelError("TagIds", "Selected category is not correct.");
            //        return View(blog);
            //    }

            //    BlogTag blogTag = new BlogTag
            //    {
            //        CreatedAt = DateTime.UtcNow,
            //        CreatedBy = "System", // bunu bilmedim
            //        IsDeleted = false,
            //        TagId = tagId
            //    };

            //    blogTags.Add(blogTag);
            //}




        }
    }
}
