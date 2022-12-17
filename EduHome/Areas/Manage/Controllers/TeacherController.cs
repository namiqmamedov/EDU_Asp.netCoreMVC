using EduHome.DAL;
using EduHome.Extension;
using EduHome.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Manage.Controllers
{
    [Area("manage")]
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public TeacherController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Teacher> teachers = await _context.Teachers.
                Where(t => t.IsDeleted == false).ToListAsync();

            return View(teachers);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.TeacherSkills = await _context.TeacherSkills
               .Where(t => t.IsDeleted == false)
               .ToListAsync();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Teacher teacher)
        {
            ViewBag.TeacherSkills = await _context.TeacherSkills
              .Where(t => t.IsDeleted == false)
              .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(teacher);
            }

            if (teacher.File == null)
            {
                ModelState.AddModelError("File", "File is required");
                return View(teacher);
            }

            if (teacher.File.ContentType != "image/jpeg")
            {
                ModelState.AddModelError("File", ".jpg or .jpeg");
                return View(teacher);
            }
            if (teacher.File.Length > 24096)
            {
                ModelState.AddModelError("File", "Maximum size is 24096 kb");
                return View(teacher);
            }

            teacher.Image = teacher.File.CreateImage(_env, "assets", "images");


            teacher.IsDeleted = false;
            teacher.CreatedAt = DateTime.UtcNow;
            teacher.CreatedBy = "System";

            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return BadRequest("ID cannot be empty!");
            }

            Teacher teacher = await _context.Teachers.FirstOrDefaultAsync(t => t.IsDeleted == false && t.Id == id);

            if (teacher == null)
            {
                return NotFound("The entered ID is wrong");
            }

            ViewBag.TeacherSkills = await _context.TeacherSkills
               .Where(t => t.IsDeleted == false)
               .ToListAsync();

            return View(teacher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return View(teacher);
            }

            if (id == null)
            {
                return BadRequest("ID cannot be empty!");
            }

            Teacher existedTeacher = await _context.Teachers.FirstOrDefaultAsync(t => t.IsDeleted == false && t.Id == id);

            if (teacher == null)
            {
                return NotFound("The entered ID is wrong");
            }

            if (teacher.Id != id)
            {
                return BadRequest("ID cannot be empty!");
            }

            if (teacher.File.ContentType != "image/jpeg")
            {
                ModelState.AddModelError("File", "File extension must be JPG or JPEG !");
                return View(teacher);
            }
            if (teacher.File.Length > 24096)
            {
                ModelState.AddModelError("File", "Maximum size is 24096 kb");
                return View(teacher);
            }

            if (teacher.Image != null)
            {
                existedTeacher.Image = teacher.File.CreateImage(_env, "assets", "images");
            }

            else
            {
                existedTeacher.Image = null;
            }

            existedTeacher.Fullname = teacher.Fullname;
            existedTeacher.UpdatedAt = DateTime.UtcNow;
            existedTeacher.UpdatedBy= "System";
            

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }
    }
}
