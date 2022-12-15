using EduHome.DAL;
using EduHome.ViewModels.Courses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        public CourseController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            CourseVM courseVM = new CourseVM
            {
                Courses = await _context.Courses.Where(e => e.IsDeleted == false).ToListAsync(),
                CourseCategories = await _context.CourseCategories.Where(e => e.IsDeleted == false).ToListAsync(),
                CourseTags = await _context.CourseTags.Where(e => e.IsDeleted == false).ToListAsync(),
                CourseDetailTitles = await _context.CourseDetailTitles.Where(e => e.IsDeleted == false).ToListAsync(),
                Blogs = await _context.Blogs.Where(b => b.IsDeleted == false).ToListAsync(),

            };

            return View(courseVM);
        }

        public IActionResult CourseDetail(int? id)
        {
            CourseDetailVM courseDetailVM = new CourseDetailVM
            {
                Course = _context.Courses.Include(c=>c.CourseCategories).ThenInclude(c=>c.Category).Include(c=>c.CourseTags).ThenInclude(c=>c.Tag).Include(c=>c.CourseDetailTitles).ThenInclude(c=>c.DetailTitle).FirstOrDefault(c=>c.Id == id),
                Courses = _context.Courses.Where(c => !c.IsDeleted).ToList(),
                Blogs = _context.Blogs.Where(b => !b.IsDeleted).ToList()
            };

            return View(courseDetailVM);
        }
    }
}
