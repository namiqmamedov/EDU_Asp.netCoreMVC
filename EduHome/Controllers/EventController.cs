﻿using EduHome.DAL;
using EduHome.ViewModels.Events;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        public EventController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            EventVM eventVM = new EventVM
            {
                Events = await _context.Events.Where(e => e.IsDeleted == false).ToListAsync(),
                EventCategories = await _context.EventCategories.Where(e => e.IsDeleted == false).ToListAsync(),
                EventSpeakers = await _context.EventSpeakers.Where(e => e.IsDeleted == false).ToListAsync(),

            };


            return View(eventVM);
        }
    }
}
