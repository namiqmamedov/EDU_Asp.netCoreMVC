using EduHome.DAL;
using EduHome.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
          

            HomeVM homeVM = new HomeVM
            {
                Sliders = await _context.Sliders.Where(s => s.IsDeleted == false).ToListAsync(),
                Chooses = await _context.Chooses.Where(c => c.IsDeleted == false).ToListAsync(),
                Testimonials = await _context.Testimonials.Where(t => t.IsDeleted == false).ToListAsync(),
                NoticeLefts = await _context.NoticeLefts.Where(s => s.IsDeleted == false).ToListAsync(),
                NoticeRights = await _context.NoticeRights.Where(s => s.IsDeleted == false).ToListAsync(),
                Blogs = await _context.Blogs.Where(s => s.IsDeleted == false).ToListAsync(),
                Courses = await _context.Courses.Where(s => s.IsDeleted == false).ToListAsync(),
            };

            return View(homeVM);
        }
    }
}
