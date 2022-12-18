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
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Category> categories = (await _context.Categories
            .Where(t => t.IsDeleted == false).ToListAsync());

            return View(categories);
        }

        [HttpGet]

        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Category category)
        {
            ViewBag.Categories = await _context.Categories
                .Where(c=> c.IsDeleted == false)
                .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(category);
            }

            if (await _context.Categories.AnyAsync(c => c.IsDeleted == false && c.Name.ToLower() == category.Name.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", $"This name '{category.Name}' is already exists ");
                return View(category);
            }

            category.Name = category.Name.Trim();
            category.IsDeleted = false;
            category.CreatedAt = DateTime.Now;
            category.CreatedBy = "System";

            await _context.Categories.AddAsync(category);
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

            Category category = await _context.Categories.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (category == null)
            {
                return NotFound("ID is not correct");
            }

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Category category)
        {
            ViewBag.Categories = await _context.Categories
            .Where(c => c.IsDeleted == false)
            .ToListAsync();


            if (id == null)
            {
                return BadRequest("ID Cannot be null !");
            }

            if (category.Id != id)
            {
                return BadRequest("ID is not correct");
            }

            if (await _context.Categories.AnyAsync(c => c.IsDeleted == false && c.Name.ToLower() == category.Name.ToLower().Trim() && c.Id != id))
            {
                ModelState.AddModelError("Name", $"This name '{category.Name}'is  already exists ");
                return View(category);
            }

            Category existedCategory = await _context.Categories.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (existedCategory == null)
            {
                return NotFound("ID is not correct");
            }

            existedCategory.Name = category.Name;

            await _context.SaveChangesAsync();


            return RedirectToAction("Index");

        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("ID is not a null");
            }

            Category category = await _context.Categories
                .FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (category == null)
            {
                return NotFound("ID is not correct");
            }


            category.IsDeleted = true;
            category.DeletedBy = "";
            category.DeletedAt = DateTime.UtcNow;


            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

    }
}
