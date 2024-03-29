﻿using EduHome.DAL;
using EduHome.ViewModels.About;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            AboutVM aboutVM = new AboutVM
            {          
                Testimonials = await _context.Testimonials.Where(t => t.IsDeleted == false).ToListAsync(),
                AboutContents = await _context.AboutContents.Where(t => t.IsDeleted == false).ToListAsync(),
                AboutNotices = await _context.AboutNotices.Where(t => t.IsDeleted == false).ToListAsync(),
                AboutVideos = await _context.AboutVideo.Where(t => t.IsDeleted == false).ToListAsync(),
                Teachers = await _context.Teachers.Where(t => t.IsDeleted == false).ToListAsync(),

            };

            return View(aboutVM);
        }
    }
}
