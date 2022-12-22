using EduHome.DAL;
using EduHome.Extension;
using EduHome.Helpers;
using EduHome.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
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
            IEnumerable<Teacher> teachers = await _context.Teachers
                .Include(sk=>sk.TeacherSkills).ThenInclude(sk=>sk.Skill)
                .Where(t => t.IsDeleted == false).ToListAsync();

            return View(teachers);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Skills = await _context.Skills.Where(s => s.IsDeleted == false).ToListAsync();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Teacher teacher)
        {
            ViewBag.Skill = await _context.Skills.Where(s => s.IsDeleted == false).ToListAsync();

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
                ModelState.AddModelError("File", "File extension must be JPG or JPEG !");
                return View(teacher);
            }
            if (teacher.File.Length > 45096)
            {
                ModelState.AddModelError("File", "Maximum size is 45096 kb");
                return View(teacher);
            }

            teacher.Image = teacher.File.CreateImage(_env, "assets", "img", "teacher");


            List<TeacherSkill> teacherSkills = new List<TeacherSkill>();

            foreach (int skillId in teacher.SkillIds)
            {
                if (! await _context.Skills.AnyAsync(t=>t.IsDeleted == false && t.Id == skillId))
                {
                    ModelState.AddModelError("SkillIds","Error");
                }

                TeacherSkill teacherSkill = new TeacherSkill
                {
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "System",
                    IsDeleted = false,
                    SkillId = skillId
                };
                teacherSkills.Add(teacherSkill);
            }

            teacher.TeacherSkills = teacherSkills;
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
                return BadRequest("ID cannot be null!");
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
        public async Task<IActionResult> Update(int? id, Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return View(teacher);
            }

            if (id == null)
            {
                return BadRequest("ID cannot be empty!");
            }

            if (teacher.Id != id)
            {
                return BadRequest("ID cannot be empty!");
            }


            Teacher existedTeacher = await _context.Teachers.FirstOrDefaultAsync(t => t.IsDeleted == false && t.Id == id);

            if (teacher == null)
            {
                return NotFound("The entered ID is wrong");
            }

            if (existedTeacher.Image == null && teacher.File == null)
            {
                ModelState.AddModelError("File", "File extension must be required!");
                return View(teacher);
            }


            if (existedTeacher.File != null)
            {
                if (teacher.File.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("File", "File extension must be JPG or JPEG !");
                    return View(teacher);
                }
                if (teacher.File.Length > 45096)
                {
                    ModelState.AddModelError("File", "Maximum size is 45 kb");
                    return View(teacher);
                }
             
            }

            if (teacher.File != null)
            {
                Helper.DeleteFile(_env, existedTeacher.Image, "assets", "img", "teacher");
                existedTeacher.Image = teacher.File.CreateImage(_env, "assets", "img", "teacher");
            }
           

            existedTeacher.Fullname = teacher.Fullname.Trim();
            existedTeacher.Rank = teacher.Rank;
            existedTeacher.Description = teacher.Description;
            existedTeacher.Experince = teacher.Experince;
            existedTeacher.Hobby = teacher.Hobby;
            existedTeacher.Faculty = teacher.Faculty;
            existedTeacher.Number = teacher.Number;
            existedTeacher.Email = teacher.Email;
            existedTeacher.FacebookURL = teacher.FacebookURL;
            existedTeacher.PinterestURL = teacher.PinterestURL;
            existedTeacher.VimeoURL = teacher.VimeoURL;
            existedTeacher.TwitterURL = teacher.TwitterURL;
            existedTeacher.UpdatedAt = DateTime.UtcNow;
            existedTeacher.UpdatedBy = "System";


            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id not a null");
            }

            Teacher teacher = await _context.Teachers
                .Include(sk => sk.TeacherSkills)
                .ThenInclude(sk => sk.Skill)
                .FirstOrDefaultAsync(t => t.IsDeleted == false && t.Id == id);

            if (teacher == null)
            {
                return NotFound("Id not correct");
            }

            return View(teacher);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("ID not a null");
            }

            Teacher teachers = await _context.Teachers
                .FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (teachers == null)
            {
                return NotFound("Id not correct");
            }


            teachers.IsDeleted = true;
            teachers.DeletedBy = "";
            teachers.DeletedAt = DateTime.UtcNow.AddHours(+4);



            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

    }
}
