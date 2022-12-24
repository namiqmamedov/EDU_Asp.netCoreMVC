using EduHome.DAL;
using EduHome.Extension;
using EduHome.Helpers;
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
                .Include(b => b.Category)
                .Include(bd => bd.BlogDescriptions)
                .Include(bt => bt.BlogTags).ThenInclude(bt => bt.Tag)
                .Where(b => b.IsDeleted == false)
                .ToListAsync();

            return View(blogs);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(b => b.IsDeleted == false).ToListAsync();
            ViewBag.BlogDescriptions = await _context.BlogDescriptions.Where(bd => bd.IsDeleted == false).ToListAsync();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Blog blogs)
        {
            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(b => b.IsDeleted == false).ToListAsync();
            ViewBag.BlogDescriptions = await _context.BlogDescriptions.Where(bd => bd.IsDeleted == false).ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(blogs);
            }

            if (!await _context.Blogs.AnyAsync(b => b.IsDeleted == false && b.Id == blogs.CategoryId))
            {
                ModelState.AddModelError("CategoryId", "Selected category is not correct.");
                return View(blogs);
            }

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

     
            List<BlogTag> blogTags = new List<BlogTag>();


            foreach (int tagId in blogs.TagIds)
            {
                if (blogs.TagIds.Where(t => t == tagId).Count() > 1)
                {
                    ModelState.AddModelError("TagIds", "You can't use the same tag more than once !");
                    return View(blogs);
                }

                if (!await _context.Tags.AnyAsync(c => c.IsDeleted == false && c.Id == tagId))
                {
                    ModelState.AddModelError("TagIds", "Selected category is not correct.");
                    return View(blogs);
                }

                BlogTag blogTag = new BlogTag
                {
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "System", 
                    IsDeleted = false,
                    TagId = tagId
                };

                blogTags.Add(blogTag);
            }

            blogs.BlogTags = blogTags;

            await _context.Blogs.AddAsync(blogs);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        [HttpGet]

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return BadRequest("ID cannot be null!");
            }

            Blog blog = await _context.Blogs.FirstOrDefaultAsync(b => b.IsDeleted == false && b.Id == id);

            if (blog == null)
            {
                return NotFound("The entered ID is wrong");
            }

            blog.TagIds = await _context.BlogTags.Where(bt => bt.BlogId == id)
           .Select(t => t.TagId).ToListAsync();

            ViewBag.Description = await _context.Descriptions.Where(b => b.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(t => t.IsDeleted == false).ToListAsync();
            
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Blog blog)
        {

            ViewBag.Description = await _context.Descriptions.Where(b => b.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(t => t.IsDeleted == false).ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(blog);
            }
            if (id == null)
            {
                return BadRequest("ID cannot be null!");
            }

            if (blog.Id != id)
            {
                return BadRequest("ID cannot be empty!");
            }

            Blog existedBlog = await _context.Blogs.FirstOrDefaultAsync(b => b.IsDeleted == false && b.Id == id);


            List<BlogTag> blogTags = new List<BlogTag>();

            foreach (int tagId in blog.TagIds)
            {
                if (blog.TagIds.Where(t => t == tagId).Count() > 1)
                {
                    ModelState.AddModelError("TagIds", "You can't use the same tag more than once !");
                    return View(blog);
                }

                if (!await _context.Tags.AnyAsync(c => c.IsDeleted == false && c.Id == tagId))
                {
                    ModelState.AddModelError("TagIds", "Selected category is not correct.");
                    return View(blog);
                }

                BlogTag blogTag = new BlogTag
                {
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "System",
                    IsDeleted = false,
                    TagId = tagId
                };

                blogTags.Add(blogTag);
            }

            if (blog.File != null)
            {
                Helper.DeleteFile(_env, existedBlog.Image, "assets", "img", "blog");
                existedBlog.Image = blog.File.CreateImage(_env, "assets", "img", "blog");
            }

            existedBlog.BlogTags = blogTags;
            existedBlog.Title = blog.Title;
            existedBlog.File = blog.File;
            existedBlog.BlogDate = blog.BlogDate;
            existedBlog.Name = blog.Name;
       

            blog.IsDeleted = false;
            blog.CreatedAt = DateTime.Now;
            blog.CreatedBy = "System";

            await _context.Blogs.AddAsync(blog);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("ID not a null");
            }

            Blog blog = await _context.Blogs
                .FirstOrDefaultAsync(b => b.IsDeleted == false && b.Id == id);

            if (blog == null)
            {
                return NotFound("Id not correct");
            }

            blog.IsDeleted = true;
            blog.DeletedBy = "";
            blog.DeletedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }


        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest("ID is not a null");
            }

            Blog blog = await _context.Blogs
            .Include(b => b.BlogDescriptions)
            .Include(et => et.BlogTags).ThenInclude(et => et.Tag)
            .FirstOrDefaultAsync(e => e.IsDeleted == false && e.Id == id);

            if (blog == null)
            {
                return NotFound("ID is not correct");
            }

            return View(blog);
        }

    }
}
