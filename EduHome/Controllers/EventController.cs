using EduHome.DAL;
using EduHome.Models;
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

        public async Task<IActionResult> Index(int? id)
        {
            EventVM eventVM = new EventVM
            {
                Events = await _context.Events.Where(e => e.IsDeleted == false).ToListAsync(),
                //EventCategories = await _context.EventCategories.Where(e => e.IsDeleted == false).ToListAsync(),
                EventSpeakers = await _context.EventSpeakers.Where(e => e.IsDeleted == false).ToListAsync(),
                EventDescriptions = await _context.EventDescriptions.Where(e => e.IsDeleted == false).ToListAsync(),
                EventTags = await _context.EventTags.Where(e => e.IsDeleted == false).ToListAsync(),
                Blogs = await _context.Blogs.Where(b => b.IsDeleted == false).ToListAsync(),

            };

            return View(eventVM);
        }

        public IActionResult EventDetail(int? id)
        {
            EventDetailVM eventDetailVM = new EventDetailVM
            {
                Event = _context.Events/*.Include(e => e.EventCategories).ThenInclude(e => e.Category)*/.Include(e => e.EventDescriptions).Include(t => t.EventTags).ThenInclude(t => t.Tag).Include(e=>e.EventSpeakers).ThenInclude(e=>e.Teacher).FirstOrDefault(e => e.Id == id),
                Events = _context.Events.Where(e => !e.IsDeleted).ToList(),
                Blogs = _context.Blogs.Where(b => !b.IsDeleted).ToList(),
                categories = _context.Categories.Where(c => !c.IsDeleted).Include(e => e.Events).ToList(),
            };


            return View(eventDetailVM);
        }


    }
}
