using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Manage.Controllers
{
    [Area("manage")]
    public class TagController : Controller
    {
        private readonly AppDbContext _context;
        public TagController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Tag> tags = (await _context.Tags
            .Where(t=>t.IsDeleted == false).ToListAsync());

            return View(tags);     
        }

        [HttpGet]
        
        public async Task<IActionResult> Create()
        {
            ViewBag.Tags = await _context.Tags.Where(t => t.IsDeleted == false).ToListAsync();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Tag tag)
        {
            ViewBag.Tags = await _context.Tags
                .Where(t => t.IsDeleted == false)
                .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(tag);
            }

            if (await _context.Tags.AnyAsync(t => t.IsDeleted == false && t.Name.ToLower() == tag.Name.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", $"This Name '{tag.Name}' is Already Exists ");
                return View(tag);
            }

            tag.Name = tag.Name.Trim();
            tag.IsDeleted = false;
            tag.CreatedAt = DateTime.Now;
            tag.CreatedBy = "System";

            await _context.Tags.AddAsync(tag);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return BadRequest("ID Cannot be null !");
            }

            Tag tag = await _context.Tags.FirstOrDefaultAsync(t => t.IsDeleted == false && t.Id == id);

            if (tag == null)
            {
                return NotFound("ID is not correct");
            }

            return View(tag);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Tag tag)
        {
            ViewBag.Tags = await _context.Tags
            .Where(t => t.IsDeleted == false)
            .ToListAsync();


            if (id == null)
            {
                return BadRequest("ID Cannot be null !");
            }

            if (tag.Id != id)
            {
                return BadRequest("ID is not correct");
            }

            if (await _context.Tags.AnyAsync(t => t.IsDeleted == false && t.Name.ToLower() == tag.Name.ToLower().Trim() && t.Id != id))
            {
                ModelState.AddModelError("Name", $"This Name '{tag.Name}' Already Exists ");
                return View(tag);
            }

            Tag existedTag = await _context.Tags.FirstOrDefaultAsync(t => t.IsDeleted == false && t.Id == id);

            if (existedTag == null)
            {
                return NotFound("ID is not correct");
            }

            existedTag.Name = tag.Name;

            await _context.SaveChangesAsync();


            return RedirectToAction("Index");

        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("ID is not a null");
            }

            Tag tag = await _context.Tags
                .FirstOrDefaultAsync(t => t.IsDeleted == false && t.Id == id);

            if (tag == null)
            {
                return NotFound("ID is not correct");
            }


            tag.IsDeleted = true;
            tag.DeletedBy = "";
            tag.DeletedAt = DateTime.UtcNow;


            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

    }
}
