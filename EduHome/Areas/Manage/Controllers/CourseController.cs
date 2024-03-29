﻿using EduHome.DAL;
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
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public CourseController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Course> courses = await _context.Courses
                .Include(c => c.Category)
                .Include(c => c.CourseTags).ThenInclude(ct => ct.Tag)
                .Where(c => c.IsDeleted == false)
                .ToListAsync();

            return View(courses);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(t => t.IsDeleted == false).ToListAsync();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Course course)
        {
            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(t => t.IsDeleted == false).ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(course);
            }

            if (!await _context.Categories.AnyAsync(c => c.IsDeleted == false && c.Id == course.CategoryId))
            {
                ModelState.AddModelError("CategoryId", "Selected category is not correct.");
                return View(course);
            }


            if (course.File == null)
            {
                ModelState.AddModelError("File", "File is required");
                return View(course);
            }

            if (course.File.ContentType != "image/jpeg")
            {
                ModelState.AddModelError("File", "File extension must be JPG or JPEG !");
                return View(course);
            }
            if (course.File.Length > 124096)
            {
                ModelState.AddModelError("File", "Maximum size is 124096 kb");
                return View(course);
            }

            course.Image = course.File.CreateImage(_env, "assets", "img", "course");

            List<CourseTag> courseTags = new List<CourseTag>();

            foreach (int tagId in course.TagIds)
            {
                if (course.TagIds.Where(t => t == tagId).Count() > 1)
                {
                    ModelState.AddModelError("TagIds", "You can't use the same tag more than once !");
                    return View(course);
                }

                if (!await _context.Tags.AnyAsync(c => c.IsDeleted == false && c.Id == tagId))
                {
                    ModelState.AddModelError("TagIds", "Selected category is not correct.");
                    return View(course);
                }

                CourseTag courseTag = new CourseTag
                {
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "System",
                    IsDeleted = false,
                    TagId = tagId
                };

                courseTags.Add(courseTag);
            }

            course.CourseTags = courseTags;


            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Course course = await _context.Courses.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (course == null)
            {
                return NotFound();
            }

            course.TagIds = await _context.CourseTags.Where(ct => ct.CourseId == id)
            .Select(x => x.TagId).ToListAsync();

            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(t => t.IsDeleted == false).ToListAsync();

            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Course course)
        {
            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(t => t.IsDeleted == false).ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(course);
            }

            Course existedCourse = await _context.Courses.Include(c => c.CourseTags).FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            _context.CourseTags.RemoveRange(existedCourse.CourseTags);

            List<CourseTag> courseTags = new List<CourseTag>();

            foreach (int tagId in course.TagIds)
            {
                if (course.TagIds.Where(t => t == tagId).Count() > 1)
                {
                    ModelState.AddModelError("TagIds", "You can't use the same tag more than once !");
                    return View(course);
                }

                if (!await _context.Tags.AnyAsync(c => c.IsDeleted == false && c.Id == tagId))
                {
                    ModelState.AddModelError("TagIds", "Selected category is not correct.");
                    return View(course);
                }

                CourseTag courseTag = new CourseTag
                {
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "System",
                    IsDeleted = false,
                    TagId = tagId
                };

                courseTags.Add(courseTag);
            }

            if (course.File != null)
            {
                Helper.DeleteFile(_env, existedCourse.Image, "assets", "img", "course");
                existedCourse.Image = course.File.CreateImage(_env, "assets", "img", "course");
            }


            existedCourse.CourseTags = courseTags;
            existedCourse.Title = course.Title;
            existedCourse.Description = course.Description;
            existedCourse.CourseStarts = course.CourseStarts;
            existedCourse.AboutDesc = course.AboutDesc;
            existedCourse.ApplyDesc = course.ApplyDesc;
            existedCourse.CertificationDesc = course.CertificationDesc;
            existedCourse.CourseAssesments = course.CourseAssesments;
            existedCourse.CourseDuration = course.CourseDuration;
            existedCourse.CourseClassDuration = course.CourseClassDuration;
            existedCourse.CourseLanguage = course.CourseLanguage;
            existedCourse.CourseSkillLevel = course.CourseSkillLevel;
            existedCourse.CourseStudents = course.CourseStudents;
            existedCourse.FEE = course.FEE;
            existedCourse.LastDesc = course.LastDesc;
            existedCourse.TitleDesc = course.TitleDesc;
            existedCourse.CategoryId = course.CategoryId;
            existedCourse.UpdatedAt = DateTime.UtcNow;
            existedCourse.UpdatedBy = "System";

            await _context.SaveChangesAsync();


            return RedirectToAction("Index");

        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("ID not a null");
            }

            Course course = await _context.Courses
                .FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (course == null)
            {
                return NotFound("Id not correct");
            }

            course.IsDeleted = true;
            course.DeletedBy = "";
            course.DeletedAt = DateTime.UtcNow.AddHours(+4);



            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id not a null");
            }


            Course course = await _context.Courses
                .Include(c => c.Category)
                .Include(c => c.CourseTags).ThenInclude(ct => ct.Tag)
                .FirstOrDefaultAsync(t => t.IsDeleted == false && t.Id == id);

            if (course == null)
            {
                return NotFound("Id not correct");
            }

            return View(course);
        }
    }
}
